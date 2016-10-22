﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public GameObject puestoDeControl;   //currentCheckpoint

    private PlayerController player;
    public GameObject animacionDeMuerte;
    public GameObject animacionDeRevivir;

    public float respawnDelay;

    // Use this for initialization
    void Start() {
        player = FindObjectOfType<PlayerController>();
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
        Debug.Log("Player respawn");
        yield return new WaitForSeconds(respawnDelay);
        player.transform.position = puestoDeControl.transform.position;
        player.enabled = true;
        player.GetComponent<Renderer>().enabled = true;
        Instantiate(animacionDeRevivir, puestoDeControl.transform.position, puestoDeControl.transform.rotation);
    }
}
