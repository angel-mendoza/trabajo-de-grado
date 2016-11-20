using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour {

    public string nivel;
    public int vidaDelJugador;
    public string level1Tag;


    public void NewGame()
    {
        PlayerPrefs.SetInt("Vidas", vidaDelJugador);
        PlayerPrefs.SetInt("Puntuacion", 0);
        //PlayerPrefs.SetInt("level1Tag", 1);
        SceneManager.LoadScene(nivel);
       
    }

    public void Quit()
    {
        Application.Quit();
    }
}
