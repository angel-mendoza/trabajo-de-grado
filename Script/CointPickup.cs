using UnityEngine;
using System.Collections;

public class CointPickup : MonoBehaviour {

    public int puntosParaAgregados;

    public AudioSource monedaSonido;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>()== null)
        {
            return;
        }

        ScoreManager.AgergarPuntos(puntosParaAgregados);
        monedaSonido.Play();
        Destroy(gameObject);
    }
}
