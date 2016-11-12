using UnityEngine;
using System.Collections;

public class CadenaController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void destruirCadena()
    {
        GetComponent<HingeJoint2D>().enabled = false;
    }
}
