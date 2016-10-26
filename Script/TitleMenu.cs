using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour {

    public string nivel;

    public void NewGame()
    {
        SceneManager.LoadScene(nivel);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
