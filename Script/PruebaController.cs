using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PruebaController : MonoBehaviour {
    public Text texto;
    public int variable;
    public int variable1;
    public int variable2;
    public int variable3;
    // Use this for initialization
    void Start () {
        texto = GetComponent<Text>();
        variable = PlayerPrefs.GetInt("Puntuacion");
        variable1 = PlayerPrefs.GetInt("tiempo");
        variable2 = PlayerPrefs.GetInt("llave");
        variable3 = PlayerPrefs.GetInt("llave1");
        // texto.text = "" + variable + "   " + variable1 + "  " + variable2 + "  " + variable3;
        texto.text = "" + PlayerPrefs.GetInt("levelTag");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
