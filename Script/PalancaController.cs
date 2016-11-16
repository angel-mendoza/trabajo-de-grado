using UnityEngine;
using System.Collections;

public class PalancaController : MonoBehaviour {
    public PuenteController puente;
    // Use this for initialization
    void Start () {
        puente = FindObjectOfType<PuenteController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            
                GetComponent<AudioSource>().Play();
                GetComponent<Animator>().SetBool("activo", true);
                puente.activo = true;
                GetComponent<Collider2D>().enabled = false;
        }
    }
}
