using UnityEngine;
using System.Collections;

public class DonaPremio : MonoBehaviour {
    public float fuerza;
    public int vida;
    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody2D>().AddRelativeForce(transform.right * fuerza, ForceMode2D.Impulse);
        GetComponent<Rigidbody2D>().AddRelativeForce(transform.up * fuerza, ForceMode2D.Impulse);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        //       if (other.GetComponent<PlayerController>() == null)
        //            return;


        if (other.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
            HealthManager.HurtPlayer(-vida);
            Destroy(gameObject);
        }


    }

}
