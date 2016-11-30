using UnityEngine;
using System.Collections;

public class MisionController : MonoBehaviour {
    private PauseMenu pause;
	// Use this for initialization
	void Start () {
        pause = FindObjectOfType<PauseMenu>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Atras()
    {
        Time.timeScale = 1f;
        pause.mision.SetActive(false);
    }
}
