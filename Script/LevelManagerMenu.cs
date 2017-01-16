using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelManagerMenu : MonoBehaviour {
    [System.Serializable]
    public class level
    {
        public string LevelText;
        public int Unlocked;
        public bool IsInteractable;
        public string ruta; //---mio
       
    }

    public GameObject levelbutton;
    public Transform Spacer;
    public List<level> LevelList;

    // Use this for initialization
    void Start () {
        //DeleteAll();
        FillList(); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FillList()
    {
        foreach(var level in LevelList)
        {
            GameObject newbutton = Instantiate(levelbutton) as GameObject;
            LevelButton button = newbutton.GetComponent<LevelButton>();
            button.LevelText.text = level.LevelText;

            if (PlayerPrefs.GetInt("Level" + button.LevelText.text) == 1)
            {
                level.Unlocked = 1;
                level.IsInteractable = true;
            }

            button.unlocked = level.Unlocked;
            button.GetComponent<Button>().interactable = level.IsInteractable;
            button.ruta = level.ruta;

            button.GetComponent<Button>().onClick.AddListener(() => LoadLevels(button.ruta));
       

            if (PlayerPrefs.GetInt("Puntuacion" + button.LevelText.text)> 0)
            {
                button.start1.SetActive(true);
            }
            if (PlayerPrefs.GetInt("Puntuacion" + button.LevelText.text) > 2000)
            {
                button.start2.SetActive(true);
            }
            if (PlayerPrefs.GetInt("Puntuacion" + button.LevelText.text) > 3000)
            {
                button.start3.SetActive(true);
            }


            newbutton.transform.SetParent(Spacer, false);
        }
        SaveAll();
    }

    void SaveAll()
    {
        if (PlayerPrefs.HasKey("Level1"))
        {
            return;
        }
        else
        {

       
            GameObject[] allbuttons = GameObject.FindGameObjectsWithTag("LevelButton");
            foreach (GameObject buttons in allbuttons)
            {
                LevelButton button = buttons.GetComponent<LevelButton>();
                PlayerPrefs.SetInt("Level" + button.LevelText.text, button.unlocked);
            }

        }
    }

    void DeleteAll()
    {
        PlayerPrefs.DeleteAll();
    }

    void LoadLevels(string value)
    {
        //Application.LoadLevel(value);

        SceneManager.LoadScene(value);
    }
}
