using UnityEngine;
using System.Collections;

public class CanonController : MonoBehaviour {
    public bool dispara;
    public GameObject bala;
    public GameObject Activador;
    public Transform disparador;
    public float tiempoParaDisparar;
    public float contadorDeDisparo;
	// Use this for initialization
	void Start () {
        contadorDeDisparo = tiempoParaDisparar;

    }
	
	// Update is called once per frame
	void Update () {

        contadorDeDisparo -= Time.deltaTime;
	if (dispara && contadorDeDisparo <= 0)
        {
            Instantiate(bala, disparador.position, disparador.rotation);
            contadorDeDisparo = tiempoParaDisparar;
        }
	}
}
