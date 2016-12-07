using UnityEngine;
using System.Collections;

public class ActivarCanon : MonoBehaviour {
    public GameObject bala;
    public Transform disparador;
    public bool activo;
    public float tiempoParaDisparar;
    public float contadorDeDisparo;

    void Start()
    {
        contadorDeDisparo = tiempoParaDisparar;

    }

    // Update is called once per frame
    void Update()
    {

        contadorDeDisparo -= Time.deltaTime;
        if (activo && contadorDeDisparo <= 0)
        {
            Instantiate(bala, disparador.position, disparador.rotation);
            contadorDeDisparo = tiempoParaDisparar;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            activo = true;
            
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            activo = false;
        }
    }
}
