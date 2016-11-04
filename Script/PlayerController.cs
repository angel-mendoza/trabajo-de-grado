﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float velocidadDeMovimiento;       //moveSpeed
    public float fuerzaDeSalto;               //jumpHeigth
    private float friccion;                   //moveVelocity

    public Transform checkDelSuelo;           //groundCheck
    public float radioDelCheckDelSuelo;       // groundCheckRadius
    public LayerMask esSuelo;                 //whatIsGround
    private bool conectadoASuelo;             //grounded
    private bool dobleSalto;                  //dobleJumped
    private Animator anim;

    public Transform disparador;
    public GameObject proyectil;

    public float restrasoDeDisparo;
    private float contadorRetrasoDeDisparo;

    public AudioSource saltoSonido;

    public float derribo;                   //knockback
    public float longitudDeDerribo;         //knockBackLength
    public float derriboContador;           //knockBackCount
    public bool derriboDerecha;             //knockBackRigth

    public bool enLasEscaleras;             //onLadder
    public float rapidesDeEscalar;          //climbSpeed
    private float velocidadDeEscalar;       //climbVelocity
    private float gravedad;                 //gravityStore



    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        gravedad = GetComponent<Rigidbody2D>().gravityScale;
    }

    void FixedUpdate()
    {
        conectadoASuelo = Physics2D.OverlapCircle(checkDelSuelo.position, radioDelCheckDelSuelo, esSuelo);
    }
	
	// Update is called once per frame
	void Update () {

        if (conectadoASuelo)
        {
            dobleSalto = false;
        }

        anim.SetBool("Suelo", conectadoASuelo);
	
        if (Input.GetButtonDown("Jump") && conectadoASuelo)
        {
            Salto();
            saltoSonido.Play();
        }

        if (Input.GetButtonDown("Jump") && !dobleSalto && !conectadoASuelo)
        {
            Salto();
            saltoSonido.Play();
            dobleSalto = true;
        }

        friccion = velocidadDeMovimiento * Input.GetAxisRaw("Horizontal");

        //friccion = 0f;

/*        if (Input.GetKey(KeyCode.D))
        {
            friccion = velocidadDeMovimiento;
        }


        if (Input.GetKey(KeyCode.A))
        {
            friccion = -velocidadDeMovimiento;
        }
*/
        
        if(derriboContador <= 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(friccion, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            if (derriboDerecha)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-derribo, derribo);
            }

            if (!derriboDerecha)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(derribo, derribo);
            }

            derriboContador -= Time.deltaTime;
        }
        

        anim.SetFloat("Velocidad", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x) );
        

        if (GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }else if (GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        if (anim.GetBool("disparo"))
        {
            anim.SetBool("disparo", false);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("disparo", true);
            Instantiate(proyectil, disparador.position, disparador.rotation);
            contadorRetrasoDeDisparo = restrasoDeDisparo;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            contadorRetrasoDeDisparo -= Time.deltaTime;
            if(contadorRetrasoDeDisparo <= 0)
            {
                contadorRetrasoDeDisparo = restrasoDeDisparo;
            }
        }

        if (enLasEscaleras)
        {
            GetComponent<Rigidbody2D>().gravityScale = 0f;
            velocidadDeEscalar = rapidesDeEscalar * Input.GetAxisRaw("Vertical");
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, velocidadDeEscalar);
        }
        if (!enLasEscaleras)
        {
            GetComponent<Rigidbody2D>().gravityScale = gravedad;
        }
    }

    public void Salto()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, fuerzaDeSalto);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "plataforma")
        {
            transform.parent = other.transform;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "plataforma")
        {
            transform.parent = null;
        }
    }
}
