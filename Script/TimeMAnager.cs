using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeMAnager : MonoBehaviour {

    public float startingTime;
    public float tiempoDePartida;
    private Text theText;
    private PauseMenu pause;
    public int dañoPorPerderTiempo;

    // Use this for initialization
    void Start() {

        theText = GetComponent<Text>();
        pause = FindObjectOfType<PauseMenu>();

    }
	
	// Update is called once per frame
	void Update () {

        if (pause.enPause)
        {
            return;
        }
        
        startingTime -= Time.deltaTime;
        theText.text = "" + Mathf.Round(startingTime);

        if (startingTime <= 0)
        {
            HealthManager.HurtPlayer(dañoPorPerderTiempo);
            RestaurarTiempo();
        }
       
	
	}

    public void RestaurarTiempo()
    {
        startingTime = tiempoDePartida;
    }
}
