using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

    public bool enLaZona;
    public string siguienteNivel;
    public int levelTag;
    public int nivel;

    public TimeMAnager tiempo;
    public int puntos;
    private int tiempoScore;
    private int puntosScore;



    // Use this for initialization
    void Start () {
        enLaZona = false;
        tiempo = FindObjectOfType<TimeMAnager>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetAxisRaw("Vertical") > 0 && enLaZona)
        {
            tiempoScore = (int)tiempo.startingTime;
            puntosScore = ScoreManager.puntuacion;
            puntos = tiempoScore + puntosScore;
            PlayerPrefs.SetInt("Level" + levelTag, 1);
            PlayerPrefs.SetInt("Puntuacion" + nivel, puntos);
            SceneManager.LoadScene(siguienteNivel);



            //-----------------------------------------------
           //PlayerPrefs.SetInt("Level2", 1);
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            enLaZona = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            enLaZona = false;
        }
    }
}
