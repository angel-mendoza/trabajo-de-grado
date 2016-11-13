using UnityEngine;
using System.Collections;

public class EstacaController : MonoBehaviour {
    public GameObject estaca;
    
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            //GetComponent<Rigidbody2D>().gravityScale = 2;
            estaca.GetComponent<Rigidbody2D>().gravityScale = 2;
        }
    }
}
