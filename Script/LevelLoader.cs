using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

    public bool enLaZona;
    public string siguienteNivel;

	// Use this for initialization
	void Start () {
        enLaZona = false;
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetAxisRaw("Vertical") > 0 && enLaZona)
        {
            SceneManager.LoadScene(siguienteNivel);
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            enLaZona = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            enLaZona = false;
        }
    }
}
