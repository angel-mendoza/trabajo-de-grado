using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PruebaController : MonoBehaviour {
    public Text texto;
    public int variable;
	// Use this for initialization
	void Start () {
        texto = GetComponent<Text>();
        variable = PlayerPrefs.GetInt("llave");
        texto.text = "" + variable;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
