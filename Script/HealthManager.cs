using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {

    public int dañoPlayerMax;

    public static int dañoDelPalyer;

    private LevelManager levelmanager;

    public bool estaMuerto;

    public Slider barraDeVida;
    //Text text;

    private LifeManager sistemaDeVida;

    // Use this for initialization
    void Start () {
        //text = GetComponent<Text>();
        barraDeVida = GetComponent<Slider>();
        levelmanager = FindObjectOfType<LevelManager>();
        dañoDelPalyer = dañoPlayerMax;
        estaMuerto = false;

        sistemaDeVida = FindObjectOfType<LifeManager>();
    }
	
	// Update is called once per frame
	void Update () {

        if  (dañoDelPalyer > dañoPlayerMax)
        {
            dañoDelPalyer = dañoPlayerMax;
        }

	    if (dañoDelPalyer <= 0 && !estaMuerto)
        {
            dañoDelPalyer = 0;
            levelmanager.RespawnPlayer();
            estaMuerto = true;
            sistemaDeVida.TakeLife();
        }

        //text.text = "" + dañoDelPalyer;
        barraDeVida.value = dañoDelPalyer; 
	}

    public static void HurtPlayer(int daño)
    {
        dañoDelPalyer -= daño;
    }

    public void FullHelalth()
    {
        dañoDelPalyer = dañoPlayerMax;
    }
}
