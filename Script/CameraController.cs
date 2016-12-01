using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public PlayerController player;

    public bool teEstoySiguiendo;
    public bool moverCamara;

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
            if (moverCamara)
            {
                CamaraMovimiento();
            }
            else
            {
                CamaraFija();
            }
           
        }
	}

    void CamaraFija()
    {
        transform.position = new Vector3(player.transform.position.x + ultimaX, ultimaY, transform.position.z);
    }

    void CamaraMovimiento()
    {
        transform.position = new Vector3(player.transform.position.x + ultimaX, player.transform.position.y + ultimaY, transform.position.z);
    }
}
