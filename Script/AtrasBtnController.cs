using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AtrasBtnController : MonoBehaviour {
    public string atras;
    public GameObject preloader;
    // Use this for initialization

    public void Atras()
    {
        
        StartCoroutine("cargandoAtras");
    }
    public IEnumerator cargandoAtras()
    {
        preloader.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(atras);
    }
}
