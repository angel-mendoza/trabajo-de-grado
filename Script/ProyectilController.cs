using UnityEngine;
using System.Collections;

public class ProyectilController : MonoBehaviour {

    public float velocidad;

    public PeldanoController cadena;
    public PlayerController player;
    public BloqueController bloque;

    public int daño;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
        cadena = FindObjectOfType<PeldanoController>();
        bloque = FindObjectOfType<BloqueController>();

        if (player.transform.localScale.x < 0)
        {
            velocidad = -velocidad;
        }
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(velocidad, GetComponent<Rigidbody2D>().velocity.y);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "enemigo")
        {
            other.GetComponent<EnemyHealthManager>().dañoQueDara(daño);
        }

        if (other.tag == "cadena")
        {
            cadena.destruirUnion();
            other.GetComponent<CadenaController>().destruirCadena();
        }

        Destroy(gameObject);
    }
}
