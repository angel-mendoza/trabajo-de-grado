using UnityEngine;
using System.Collections;

public class BtnBloque : MonoBehaviour {
    public BloqueMove bloque;
    public bool activo;
	// Use this for initialization
	void Start () {
        bloque = FindObjectOfType<BloqueMove>();
        activo = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            if (activo)
            {
                GetComponent<AudioSource>().Play();
                GetComponent<Animator>().SetBool("activo", true);
                bloque.muevete = true;
                activo = false;
            }else
            {
                GetComponent<AudioSource>().Play();
                GetComponent<Animator>().SetBool("activo", false);
                bloque.muevete = false;
                activo = true;
            }

            
        }
    }
}
