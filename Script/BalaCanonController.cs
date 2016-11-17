using UnityEngine;
using System.Collections;

public class BalaCanonController : MonoBehaviour {
    public int daño;
    public float fuerzaX;
    public float fuerzaY;
    public GameObject efecto;
    public float velocidad;
    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().AddRelativeForce(transform.right * fuerzaX, ForceMode2D.Impulse);
        GetComponent<Rigidbody2D>().AddRelativeForce(transform.up * fuerzaY, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().angularVelocity = velocidad;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(efecto, transform.position, transform.rotation);
        if (other.name == "Player")
        {
            HealthManager.HurtPlayer(daño);
            //GetComponent<AudioSource>().Play();
          
        }

        Destroy(gameObject);
    }
}
