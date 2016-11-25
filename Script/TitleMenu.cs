using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour {

    public string nivel;

    public GameObject preloader;
    public AudioSource btn;


    public void NewGame()
    {
        btn.Play();
        StartCoroutine("cargando");
    }

    public void Quit()
    {
        btn.Play();
        Application.Quit();
    }

    public IEnumerator cargando()
    {
        preloader.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(nivel);
    }
}
