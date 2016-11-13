using UnityEngine;
using System.Collections;

public class BoxRewardDona : MonoBehaviour {
    public GameObject premio;
    public Transform lanzador;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            Instantiate(premio, lanzador.position, lanzador.rotation);
            GetComponent<Animator>().SetBool("Activado", true);
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
