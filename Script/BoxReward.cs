using UnityEngine;
using System.Collections;

public class BoxReward : MonoBehaviour {

    public int contadorDePremios;
    public GameObject premio;
    public Transform lanzador;
    public int puntosParaAgregados;
    public int oroParaAgregar;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            
            ScoreManager.AgergarPuntos(puntosParaAgregados);
            GoldManager.AgergarOro(oroParaAgregar);
            Instantiate(premio, lanzador.position, lanzador.rotation);
            contadorDePremios--;

            if(contadorDePremios <= 0)
            {
                GetComponent<Animator>().SetBool("ativado", true);
                GetComponent<BoxCollider2D>().enabled = false;
            }

        }
    }
}
