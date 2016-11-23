using UnityEngine;
using System.Collections;

public class MusicController : MonoBehaviour {
   
    public AudioSource pista1;
    public AudioSource pista2;
    public AudioSource pista3;
    public AudioSource pista4;
    public AudioSource pista5;
    public AudioSource pista6;
    public AudioSource pista7;
    public AudioSource pista8;
    public AudioSource pista9;
    public AudioSource pista10;
    public AudioSource pista11;
    public AudioSource pista12;
    public AudioSource pista13;
    public AudioSource pista14;
    public AudioSource boss;
    public float indice;
    public bool nivelBoss;

    // Use this for initialization

    void Start()
    {

        indice = Mathf.Round(Random.Range(0, 13));
        //otro = (int) indice;
        //sourse.clip = musica[otro];

        if (nivelBoss)
        {
            boss.Play();
        }
        else
        {
            if (indice == 0)
            {
                pista1.Play();
            }

            if (indice == 1)
            {
                pista2.Play();
            }

            if (indice == 2)
            {
                pista3.Play();
            }

            if (indice == 3)
            {
                pista4.Play();
            }

            if (indice == 4)
            {
                pista5.Play();
            }

            if (indice == 5)
            {
                pista6.Play();
            }

            if (indice == 6)
            {
                pista7.Play();
            }

            if (indice == 7)
            {
                pista8.Play();
            }

            if (indice == 8)
            {
                pista9.Play();
            }

            if (indice == 9)
            {
                pista10.Play();
            }

            if (indice == 10)
            {
                pista11.Play();
            }

            if (indice == 11)
            {
                pista12.Play();
            }

            if (indice == 12)
            {
                pista13.Play();
            }
            if (indice == 13)
            {
                pista14.Play();
            }
        }

       



    }

    // Update is called once per frame


     
    void Update()
    {

    }


}
