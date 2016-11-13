using UnityEngine;
using System.Collections;

public class CorazonPremio : MonoBehaviour {
    private LifeManager sistemaDeVida;
    public float fuerza;
    // Use this for initialization
    void Start () {
        sistemaDeVida = FindObjectOfType<LifeManager>();
        GetComponent<Rigidbody2D>().AddRelativeForce(transform.right * fuerza, ForceMode2D.Impulse);
        GetComponent<Rigidbody2D>().AddRelativeForce(transform.up * fuerza, ForceMode2D.Impulse);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            sistemaDeVida.GiveLife();
            Destroy(gameObject);
        }
    }
}
