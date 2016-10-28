using UnityEngine;
using System.Collections;

public class HurtPlayerOnContact : MonoBehaviour {

    public int dañoQueDara;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            HealthManager.HurtPlayer(dañoQueDara);
            other.GetComponent<AudioSource>().Play();

            var player = other.GetComponent<PlayerController>();
            player.derriboContador = player.longitudDeDerribo;
            if(other.transform.position.x < transform.position.x)
            {
                player.derriboDerecha = true;
            }
            else
            {
                player.derriboDerecha = false;
            }
        }
    }
}
