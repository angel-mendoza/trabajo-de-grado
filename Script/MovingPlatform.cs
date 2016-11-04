using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

    public GameObject plataforma;
    public float velocidad;
    public Transform currentPoints;
    public Transform[] puntos;
    public int pointSelection;

	// Use this for initialization
	void Start () {
        currentPoints = puntos[pointSelection];
	}
	
	// Update is called once per frame
	void Update () {
        plataforma.transform.position = Vector3.MoveTowards(plataforma.transform.position, currentPoints.position, Time.deltaTime * velocidad);
        if (plataforma.transform.position == currentPoints.position)
        {
            pointSelection++;

            if (pointSelection == puntos.Length)
            {
                pointSelection = 0;
            }

            currentPoints = puntos[pointSelection];
        }
	}
}
