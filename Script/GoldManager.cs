using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoldManager : MonoBehaviour {

    public static int oro; //score
    private LifeManager sistemaDeVida;

    Text text;

    void Start()
    {
        sistemaDeVida = FindObjectOfType<LifeManager>();
        text = GetComponent<Text>();
    }

    void Update()
    {
        if (oro < 0)
        {
            oro = 0;
        }

        if (oro > 99)
        {
            sistemaDeVida.GiveLife();
            oro = 0;
        }

        text.text = "" + oro;
    }

    public static void AgergarOro(int oroAgregado)
    {
        oro += oroAgregado;
    }

    public static void ResetearOro()
    {
        oro = 0;
    }
}
