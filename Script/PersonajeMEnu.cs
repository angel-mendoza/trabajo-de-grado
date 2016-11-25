using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PersonajeMEnu : MonoBehaviour {
    public int vidaDelJugador;
    public string bolivar;
    public string miranda;
    public string sucre;
    public string zamora;
    public GameObject preloader;

    //----------------------------------------

    public void Bolivar()
    {
        StartCoroutine("cargandoBolivar");
        PlayerPrefs.SetInt("Vidas", vidaDelJugador);
        PlayerPrefs.SetInt("Puntuacion", 0);
    }

    public void Sucre()
    {
        StartCoroutine("cargandoSucre");
        PlayerPrefs.SetInt("Vidas", vidaDelJugador);
        PlayerPrefs.SetInt("Puntuacion", 0);
    }

    public void Miranda()
    {
        StartCoroutine("cargandoMiranda");
        PlayerPrefs.SetInt("Vidas", vidaDelJugador);
        PlayerPrefs.SetInt("Puntuacion", 0);
    }

    public void Zamora()
    {
        StartCoroutine("cargandoZamora");
        PlayerPrefs.SetInt("Vidas", vidaDelJugador);
        PlayerPrefs.SetInt("Puntuacion", 0);
    }

    public IEnumerator cargandoBolivar()
    {
        preloader.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(bolivar);
    }

    public IEnumerator cargandoSucre()
    {
        preloader.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sucre);
    }

    public IEnumerator cargandoMiranda()
    {
        preloader.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(miranda);
    }
    public IEnumerator cargandoZamora()
    {
        preloader.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(zamora);
    }
}
