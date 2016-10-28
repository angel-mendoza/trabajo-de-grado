﻿using UnityEngine;
using System.Collections;

public class CheckPoints : MonoBehaviour {

    
    public LevelManager levelmanager;

    // Use this for initialization
    void Start()
    {
        levelmanager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            GetComponent<AudioSource>().Play();
            GetComponent<Animator>().SetBool("activa", true);
            levelmanager.puestoDeControl = gameObject;
        }
    }
}
