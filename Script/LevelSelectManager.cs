using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelectManager : MonoBehaviour {


    public Button[] mundos;
    public GameObject[] candados;
    //public string[] levelTags;
    //public bool[] nivelesDesbloqueados;
    public bool nivel1;
    public bool nivel2;
    public bool nivel3;

    public string tutorial;
    public string n1;
    public string n2;
    public string n3;


    // Use this for initialization
    void Awake () {
        //PlayerPrefs.DeleteAll();
        //candados[0].SetActive(false);
        //mundos[0].interactable = true;
        /*

        */

        for (int i = 0; i < mundos.Length; i++)
        {
            mundos[i].interactable = false;
        }

        if (PlayerPrefs.GetInt("levelTag")== 1)
        {
            nivel1 = true;
        }else if (PlayerPrefs.GetInt("levelTag") == 2)
        {

            nivel2 = true;
        }else if(PlayerPrefs.GetInt("levelTag") == 3)
        {
            nivel3 = true;
        }


            if (nivel1)
            {
                candados[0].SetActive(false);
                mundos[0].interactable = true;
            }
            if (nivel2)
            {
                candados[1].SetActive(false);
                mundos[1].interactable = true;
            }
            if (nivel3)
            {
                candados[2].SetActive(false);
                mundos[2].interactable = true;
            }

    }

    void Update () {



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
