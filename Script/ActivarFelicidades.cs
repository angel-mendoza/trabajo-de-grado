using UnityEngine;
using System.Collections;

public class ActivarFelicidades : MonoBehaviour {
    public GameObject felicidades;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            felicidades.SetActive(true);
        }

    }
}
