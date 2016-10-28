using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public PlayerController player;

    public bool teEstoySiguiendo;

    public float ultimaX;
    public float ultimaY;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
        teEstoySiguiendo = true;
	}
	
	// Update is called once per frame
	void Update () {
	    if (teEstoySiguiendo)
        {
            transform.position = new Vector3(player.transform.position.x + ultimaX, player.transform.position.y + ultimaY, transform.position.z);
        }
	}
}
