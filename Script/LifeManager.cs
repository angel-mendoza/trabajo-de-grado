using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour {

    private int contadorDeVidas;
    private Text thetext;
    public GameObject ventanaDeGameOver;
    public PlayerController player;

    public string mainMenu;
    public float tiempoDeEsperaDespuesDelGameOver;

	// Use this for initialization
	void Start () {
        thetext = GetComponent<Text>();
        contadorDeVidas = PlayerPrefs.GetInt("Vidas");
        player = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {

        if (contadorDeVidas <= 0)
        {
            ventanaDeGameOver.SetActive(true);
            player.gameObject.SetActive(false);
        }
        thetext.text = "" + contadorDeVidas;

        if (ventanaDeGameOver.activeSelf)
        {
            tiempoDeEsperaDespuesDelGameOver -= Time.deltaTime;
        }

        if (tiempoDeEsperaDespuesDelGameOver < 0)
        {
            SceneManager.LoadScene(mainMenu);
        }
	}

    public void GiveLife()
    {
        contadorDeVidas++;
        PlayerPrefs.SetInt("Vidas", contadorDeVidas);
    }

    public void TakeLife()
    {
        contadorDeVidas--;
        PlayerPrefs.SetInt("Vidas", contadorDeVidas);
    }

}
