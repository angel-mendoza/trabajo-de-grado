using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour {

    public string nivel;
    public int vidaDelJugador;

    

    public void NewGame()
    {
        PlayerPrefs.SetInt("Vidas", vidaDelJugador);
        PlayerPrefs.SetInt("Puntuacion", 0);
        SceneManager.LoadScene(nivel);
       
    }

    public void Quit()
    {
        Application.Quit();
    }
}
