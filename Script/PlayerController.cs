using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float velocidadDeMovimiento;       //moveSpeed
    public float fuerzaDeSalto;               //jumpHeigth

    public Transform checkDelSuelo;           //groundCheck
    public float radioDelCheckDelSuelo;       // groundCheckRadius
    public LayerMask esSuelo;                 //whatIsGround
    private bool conectadoASuelo;             //grounded
    private bool dobleSalto;                  //dobleJumped
    private Animator anim;


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


        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadDeMovimiento,GetComponent<Rigidbody2D>().velocity.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-velocidadDeMovimiento, GetComponent<Rigidbody2D>().velocity.y);
        }

        anim.SetFloat("Velocidad", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x) );
        if (GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }else if (GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }

    public void Salto()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, fuerzaDeSalto);
    }
}
