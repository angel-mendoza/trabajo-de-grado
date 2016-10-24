using UnityEngine;
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


	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
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
	
        if (Input.GetKeyDown(KeyCode.Space) && conectadoASuelo)
        {
            Salto();
        }

        if (Input.GetKeyDown(KeyCode.Space) && !dobleSalto && !conectadoASuelo)
        {
            Salto();
            dobleSalto = true;
        }

        friccion = 0f;

        if (Input.GetKey(KeyCode.D))
        {
            friccion = velocidadDeMovimiento;
        }


        if (Input.GetKey(KeyCode.A))
        {
            friccion = -velocidadDeMovimiento;
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(friccion, GetComponent<Rigidbody2D>().velocity.y);

        anim.SetFloat("Velocidad", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x) );
        

        if (GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }else if (GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            Instantiate(proyectil, disparador.position, disparador.rotation);
            contadorRetrasoDeDisparo = restrasoDeDisparo;
        }

        if (Input.GetKey(KeyCode.M))
        {
            contadorRetrasoDeDisparo -= Time.deltaTime;
            if(contadorRetrasoDeDisparo <= 0)
            {
                contadorRetrasoDeDisparo = restrasoDeDisparo;
            }
        }
    }

    public void Salto()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, fuerzaDeSalto);
    }
}
