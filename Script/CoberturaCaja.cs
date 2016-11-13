using UnityEngine;
using System.Collections;

public class CoberturaCaja : MonoBehaviour {
    public GameObject efecto;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Eliminar()
    {
        Instantiate(efecto, transform.position, transform.rotation);
        GetComponent<AudioSource>().Play();
        Destroy(gameObject);
    }
}
