using UnityEngine;
using System.Collections;

public class LifePickup : MonoBehaviour {
    private LifeManager sistemaDeVida;
    public AudioSource iconoSonido;

    // Use this for initialization
    void Start () {
        sistemaDeVida = FindObjectOfType<LifeManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            sistemaDeVida.GiveLife();
            iconoSonido.Play();
            Destroy(gameObject);
        }
    }
}
