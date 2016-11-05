using UnityEngine;
using System.Collections;

public class ShootAtPlayerInRange : MonoBehaviour {

    public float rangoDelJugador;
    public GameObject proyectilEnemigo;
    public PlayerController player;
    public Transform puntoDeLanzamiento;
    public float tiempoParaDisparar;
    private float contadorDeDisparo;

	// Use this for initialization
	void Start () {

        player = FindObjectOfType<PlayerController>();
        contadorDeDisparo = tiempoParaDisparar;
;
	}
	
	// Update is called once per frame
	void Update () {

        Debug.DrawLine(new Vector3(transform.position.x + rangoDelJugador, transform.position.y, transform.position.z), new Vector3(transform.position.x - rangoDelJugador, transform.position.y, transform.position.z));
        contadorDeDisparo -= Time.deltaTime;
        if (transform.localScale.x > 0 && player.transform.position.x > transform.position.x && player.transform.position.x < transform.position.x + rangoDelJugador && contadorDeDisparo < 0)
        {
            Instantiate(proyectilEnemigo, puntoDeLanzamiento.position, puntoDeLanzamiento.rotation);
            contadorDeDisparo = tiempoParaDisparar;

        }

        if (transform.localScale.x < 0 && player.transform.position.x < transform.position.x && player.transform.position.x > transform.position.x - rangoDelJugador && contadorDeDisparo < 0)
        {
            Instantiate(proyectilEnemigo, puntoDeLanzamiento.position, puntoDeLanzamiento.rotation);
            contadorDeDisparo = tiempoParaDisparar;

        }

    }


}
