using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
    
    public bool enPause;
    public GameObject pantallaDePausa;
    public GameObject preloader;
    public AudioSource btn;
    public GameObject mision;
    public string nivel;
    public string personaje;
    public string salir;


    // Update is called once per frame
    void Update () {

        if (enPause)
        {
           
            pantallaDePausa.SetActive(true);
            Time.timeScale = 0f;
        }else
        {
           
            pantallaDePausa.SetActive(false);
            Time.timeScale = 1f;
        }


	if (Input.GetKeyDown(KeyCode.Return))
        {
            GetComponent<AudioSource>().Play();
            enPause = !enPause;
        }
	}

    public void Resumen()
    {
        enPause = false;
    }

    public void Mision()
    {
        enPause = false;
        mision.SetActive(true);
    }

    public void elegirNivel()
    {
        btn.Play();
        StartCoroutine("Elegirnivel");
    }

    public void elegirPersonaje()
    {
        btn.Play();
        StartCoroutine("Elegirpersonaje");
    }

    public void Salirnivel()
    {
        btn.Play();
        StartCoroutine("Salir");
    }


    public IEnumerator Elegirnivel()
    {
       
        enPause = false;
        preloader.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(nivel);
    }

    public IEnumerator Elegirpersonaje()
    {
       
        enPause = false;
        preloader.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(personaje);
    }

    public IEnumerator Salir()
    {
        
        preloader.SetActive(true);
        enPause = false;
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(salir);
    }
}
