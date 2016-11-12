using UnityEngine;
using System.Collections;

public class PeldanoController : MonoBehaviour {

	// Use this for initialization
	void Start () {
       

    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void destruirUnion()
    {
        GetComponent<DistanceJoint2D>().enabled = false;
    }
}
