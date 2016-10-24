using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public GameObject puestoDeControl;   //currentCheckpoint

    private PlayerController player;
    public GameObject animacionDeMuerte;
    public GameObject animacionDeRevivir;

    public int penalidadPorMuerte;

    public float respawnDelay;

    private float gravityStore;

    private CameraController camara;

    public HealthManager healthManager;

    // Use this for initialization
    void Start() {
        player = FindObjectOfType<PlayerController>();
        camara = FindObjectOfType<CameraController>();
        healthManager = FindObjectOfType<HealthManager>();
    }

    // Update is called once per frame
    void Update() {

    }

    public void RespawnPlayer()
    {
        StartCoroutine("respawnPlayerCO");
    } 

    public IEnumerator respawnPlayerCO()
    {
        Instantiate(animacionDeMuerte, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;
        camara.teEstoySiguiendo = false;
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        ScoreManager.AgergarPuntos(-penalidadPorMuerte);
        Debug.Log("Player respawn");
        yield return new WaitForSeconds(respawnDelay);
        player.transform.position = puestoDeControl.transform.position;
        player.enabled = true;
        player.GetComponent<Renderer>().enabled = true;
        healthManager.FullHelalth();
        healthManager.estaMuerto = false;
        camara.teEstoySiguiendo = true;
        Instantiate(animacionDeRevivir, puestoDeControl.transform.position, puestoDeControl.transform.rotation);
    }
}
