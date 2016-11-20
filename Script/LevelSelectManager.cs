using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelectManager : MonoBehaviour {


    public Button[] mundos;
    public string tutorial;
    public string n1;
    public string n2;
    public string n3;
    public GameObject candado1;
    public GameObject candado2;
    public GameObject candado3;
    public Button nivel1;
    public Button nivel2;
    public Button nivel3;


    // Use this for initialization
    void Start () {
        
        //PlayerPrefs.DeleteAll();
        for (int i= 0; i<mundos.Length; i++)
        {
            mundos[i].interactable = false;
        }

	}
    //mundos[i].interactable = true; si es true esta activo
    // Update is called once per frame
    void Update () {
	if (PlayerPrefs.GetInt("llave")== 1)
        {
            candado1.SetActive(false);
            nivel1.interactable = true;
        }

        if (PlayerPrefs.GetInt("llave") == 2)
        {
            nivel1.interactable = true;
            nivel2.interactable = true;
            candado1.SetActive(false);
            candado2.SetActive(false);
        }

        if (PlayerPrefs.GetInt("llave") == 3)
        {
            nivel1.interactable = true;
            nivel2.interactable = true;
            nivel3.interactable = true;
            candado1.SetActive(false);
            candado2.SetActive(false);
            candado3.SetActive(false);
        }
    }

    public void GoToLeveltutorial()
    {
        SceneManager.LoadScene(tutorial);
    }

    public void GoToLevelN1()
    {
        SceneManager.LoadScene(n1);
    }
    public void GoToLevelN2()
    {
        SceneManager.LoadScene(n2);
    }
    public void GoToLevelN3()
    {
        SceneManager.LoadScene(n3);
    }
}
