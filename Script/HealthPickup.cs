using UnityEngine;
using System.Collections;

public class HealthPickup : MonoBehaviour {
    public int vida;
    public AudioSource sonido;
	// Use this for initialization

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>() == null)
            return;
            HealthManager.HurtPlayer(-vida);
            sonido.Play();
            Destroy(gameObject);
        
    }
}
