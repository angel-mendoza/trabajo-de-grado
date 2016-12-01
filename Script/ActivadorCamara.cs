using UnityEngine;
using System.Collections;

public class ActivadorCamara : MonoBehaviour {
    private CameraController camara;
	// Use this for initialization
	void Start () {
        camara = FindObjectOfType<CameraController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            camara.moverCamara = true;
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            camara.moverCamara = false;
        }

    }
}
