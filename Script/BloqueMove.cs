using UnityEngine;
using System.Collections;

public class BloqueMove : MonoBehaviour {
    public bool muevete;
    public Transform puntoLlegada;
    public Transform puntoSalida;
    public float velocidad;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (muevete)
        {
            transform.position = Vector3.MoveTowards(transform.position, puntoLlegada.transform.position, velocidad * Time.deltaTime);
            return;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, puntoSalida.transform.position, velocidad * Time.deltaTime);
            return;
        }
	}
}
