using UnityEngine;
using System.Collections;

public class EnemyHealthManager : MonoBehaviour {

    public int dañoParaMatarEnemigo;
    public GameObject efectoDemuerte;
    public int puntosPorMuerte;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (dañoParaMatarEnemigo <= 0)
        {
            Instantiate(efectoDemuerte, transform.position, transform.rotation);
            ScoreManager.AgergarPuntos(puntosPorMuerte);
            Destroy(gameObject);
        }
	}

    public void dañoQueDara(int daño)
    {
        dañoParaMatarEnemigo -= daño;
    }
}
