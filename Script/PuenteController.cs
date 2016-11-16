using UnityEngine;
using System.Collections;

public class PuenteController : MonoBehaviour {
    public float anguloInicial;
    public float anguloFinal;
    public bool activo;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (activo)
        {
            transform.rotation = Quaternion.FromToRotation(new Vector3(transform.rotation.x, transform.rotation.y, anguloInicial), new Vector3(transform.rotation.x, transform.rotation.y, anguloFinal));
        }
    }
}
