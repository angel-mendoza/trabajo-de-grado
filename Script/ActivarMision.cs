using UnityEngine;
using System.Collections;

public class ActivarMision : MonoBehaviour {
    public GameObject mision;
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
            mision.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            mision.SetActive(false);
        }
    }
}
