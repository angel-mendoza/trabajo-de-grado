using UnityEngine;
using System.Collections;

public class TutorialController : MonoBehaviour {
    public bool contacto;
    public GameObject area1;
    public GameObject ventana1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (contacto)
        {
            ventana1.SetActive(true);
        }else
        {
            ventana1.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            contacto = false;
           
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            contacto = true;
        }

    }
}
