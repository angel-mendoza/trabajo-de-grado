using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
    
    public bool enPause;
    public GameObject pantallaDePausa;

	
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
}
