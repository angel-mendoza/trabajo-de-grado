﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DontDEstroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void Awake()
    {

        DontDestroyOnLoad(gameObject);
    }
}
