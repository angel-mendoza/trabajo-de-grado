using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public float velocidadMovimiento;         //movespeed
    public bool mueveteDerecha;               //moveRigth

    public Transform checkDeCaminar;           //wallCheck
    public float radioDelCheckDeCaminar;       // walldCheckRadius
    public LayerMask estaCaminando;            //whatIsWall
    private bool tropesar;                     //hittingWall

    private bool atCaida;                      //atEdge
    public Transform caidaCkeck;                //edgeCheck

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update() {

        tropesar = Physics2D.OverlapCircle(checkDeCaminar.position, radioDelCheckDeCaminar, estaCaminando);

        //atCaida = Physics2D.OverlapCircle(caidaCkeck.position, radioDelCheckDeCaminar, estaCaminando);
        atCaida = Physics2D.OverlapCircle(caidaCkeck.position, radioDelCheckDeCaminar, estaCaminando);
        if (tropesar || !atCaida)
        {
            mueveteDerecha = !mueveteDerecha;
        }


        if (mueveteDerecha)
        {
            transform.localScale = new Vector3(1, 1, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadMovimiento, GetComponent<Rigidbody2D>().velocity.y);
        }else
        {
            transform.localScale = new Vector3(-1, 1, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-velocidadMovimiento, GetComponent<Rigidbody2D>().velocity.y);
        }
	}
}
