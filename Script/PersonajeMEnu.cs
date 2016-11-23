using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PersonajeMEnu : MonoBehaviour {
    public string bolivar;
    public string miranda;
    public string sucre;
    public string zamora;
    public GameObject preloader;
    public AudioSource btn;

    //----------------------------------------

    public void Bolivar()
    {
        btn.Play();
        StartCoroutine("cargandoBolivar");
    }

    public void Sucre()
    {
        btn.Play();
        StartCoroutine("cargandoSucre");
    }

    public void Miranda()
    {
        btn.Play();
        StartCoroutine("cargandoMiranda");
    }

    public void Zamora()
    {
        btn.Play();
        StartCoroutine("cargandoZamora");
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
