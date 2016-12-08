using UnityEngine;
using System.Collections;

public class BtnBloque : MonoBehaviour {
    public GameObject bloque;
    public bool activo;
    public Transform puntoLlegada;
    public Transform puntoSalida;
    public float velocidad;
    // Use this for initialization
    void Start () {
        
        activo = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (activo)
        {
            bloque.transform.position = Vector3.MoveTowards(bloque.transform.position, puntoSalida.transform.position, velocidad * Time.deltaTime);
        }else
        {
            bloque.transform.position = Vector3.MoveTowards(bloque.transform.position, puntoLlegada.transform.position, velocidad * Time.deltaTime);
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            if (activo)
            {
                GetComponent<AudioSource>().Play();
                GetComponent<Animator>().SetBool("activo", true);
                //bloque.transform.position = Vector3.MoveTowards(transform.position, puntoLlegada.transform.position, velocidad * Time.deltaTime);
                activo = false;
                //return;
               
            }else
            {
                GetComponent<AudioSource>().Play();
                GetComponent<Animator>().SetBool("activo", false);
                //bloque.transform.position = Vector3.MoveTowards(transform.position, puntoSalida.transform.position, velocidad * Time.deltaTime);
                activo = true;
                //return;
            }

            
        }
    }
}
