using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnergyBarController : MonoBehaviour {

    public Slider barraDeEnergia;
    public float tiempo;
    public float tiempoDeEspera;
    public bool dispararCombo;

	// Use this for initialization
	void Start () {
        barraDeEnergia = GetComponent<Slider>();
        dispararCombo = false;
	}
	
	// Update is called once per frame
	void Update () {

        barraDeEnergia.maxValue = tiempoDeEspera;
        tiempo += Time.deltaTime;
        barraDeEnergia.value = tiempo;

        if(tiempo >= tiempoDeEspera)
        {
            dispararCombo = true;
        }
	}
}
