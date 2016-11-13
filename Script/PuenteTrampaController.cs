using UnityEngine;
using System.Collections;

public class PuenteTrampaController : MonoBehaviour {
    public Transform disparador;
    public GameObject piso;
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
            GetComponent<Rigidbody2D>().gravityScale = 2;
        }
    }

    public void Restaurar()
    {
        Instantiate(piso, disparador.position, disparador.rotation);
    }
}
