using UnityEngine;
using System.Collections;

public class ActivarPendulo : MonoBehaviour {
    public GameObject soporte;
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
            soporte.GetComponent<Collider2D>().enabled = false;
        }
    }
}
