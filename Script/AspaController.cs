using UnityEngine;
using System.Collections;

public class AspaController : MonoBehaviour {
    public float velocidadDeRotacion;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().angularVelocity = velocidadDeRotacion;
	}
}
