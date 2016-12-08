using UnityEngine;
using System.Collections;

public class PalancaController : MonoBehaviour {
    public GameObject puente;
    public float anguloInicial;
    public float anguloFinal;
    public bool puenteActivo;
    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
	    if (puenteActivo)
        {
            puente.transform.rotation = Quaternion.FromToRotation(new Vector3(puente.transform.rotation.x, puente.transform.rotation.y, anguloInicial), new Vector3(puente.transform.rotation.x, puente.transform.rotation.y, anguloFinal));
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            
            GetComponent<AudioSource>().Play();
            GetComponent<Animator>().SetBool("activo", true);
            puenteActivo = true;
            GetComponent<Collider2D>().enabled = false;
        }
    }
}
