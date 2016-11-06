using UnityEngine;
using System.Collections;

public class ComboAtackController : MonoBehaviour {

    public float velocidad;
    public int dañoQueHara;
    public PlayerController player;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
        if (player.transform.localScale.x < 0)
        {
            velocidad = -velocidad;
        }
	}
	
	// Update is called once per frame
	void Update () {

        GetComponent<Rigidbody2D>().velocity = new Vector2(velocidad, GetComponent<Rigidbody2D>().velocity.y);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemigo")
        {
            other.GetComponent<EnemyHealthManager>().dañoQueDara(dañoQueHara);
        }
    }
}
