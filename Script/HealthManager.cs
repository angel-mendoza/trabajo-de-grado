using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {

    public int dañoPlayerMax;

    public static int dañoDelPalyer; //score

    private LevelManager levelmanager;

    public bool estaMuerto;

    Text text;

    // Use this for initialization
    void Start () {
        text = GetComponent<Text>();
        levelmanager = FindObjectOfType<LevelManager>();
        dañoDelPalyer = dañoPlayerMax;
        estaMuerto = false;
    }
	
	// Update is called once per frame
	void Update () {
	    if (dañoDelPalyer <= 0 && !estaMuerto)
        {
            dañoDelPalyer = 0;
            levelmanager.RespawnPlayer();
            estaMuerto = true;
        }

        text.text = "" + dañoDelPalyer;
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
