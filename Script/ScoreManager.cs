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
            puntuacion = 0;
        }

        text.text = "" + puntuacion;
    }

    public static void AgergarPuntos( int puntosAgregados)
    {
        puntuacion += puntosAgregados;
    }

    public static void Reset()
    {
        puntuacion = 0;
    }
}