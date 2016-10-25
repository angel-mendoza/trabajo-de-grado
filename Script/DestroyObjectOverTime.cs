using UnityEngine;
using System.Collections;

public class DestroyObjectOverTime : MonoBehaviour {

    public float tiempoDeVida;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        tiempoDeVida -= Time.deltaTime;

        if(tiempoDeVida <= 0)
        {
            Destroy(gameObject);
        }
	}
}
