using UnityEngine;
using System.Collections;

public class GoldPickup : MonoBehaviour {

    public int oroParaAgregar;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>() == null)
        {
            return;
        }

        GoldManager.AgergarOro(oroParaAgregar);
        //ScoreManager.AgergarPuntos(puntosParaAgregados);
        //Destroy(gameObject);
    }
}
