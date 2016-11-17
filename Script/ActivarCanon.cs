using UnityEngine;
using System.Collections;

public class ActivarCanon : MonoBehaviour {
    public CanonController canon;
	// Use this for initialization
	void Start () {
        canon = FindObjectOfType<CanonController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            canon.dispara = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            canon.dispara = false;
        }
    }
}
