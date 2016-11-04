using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static int puntuacion; //score

    Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        if ( puntuacion < 0)
        {
            puntuacion = PlayerPrefs.GetInt("Puntuacion");
        }

        text.text = "" + puntuacion;
    }

    public static void AgergarPuntos( int puntosAgregados)
    {
        puntuacion += puntosAgregados;
        PlayerPrefs.SetInt("Puntuacion", puntuacion);
    }

    public static void Reset()
    {
        puntuacion = 0;
        PlayerPrefs.SetInt("Puntuacion", puntuacion);
    }
}