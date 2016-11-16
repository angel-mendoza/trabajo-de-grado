using UnityEngine;
using System.Collections;

public class BloqueGiratorioController : MonoBehaviour {
    public float velocidad;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().angularVelocity = velocidad;
	}
}
