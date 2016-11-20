using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

    public bool enLaZona;
    public string siguienteNivel;
    //public string levelTag;
    public string puntos;
    public int clave;
    // Use this for initialization
    void Start () {
        enLaZona = false;
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetAxisRaw("Vertical") > 0 && enLaZona)
        {
            PlayerPrefs.SetInt("llave", clave);
            PlayerPrefs.SetInt("Puntuacion", ScoreManager.puntuacion);
            SceneManager.LoadScene(siguienteNivel);
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
