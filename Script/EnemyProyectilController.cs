using UnityEngine;
using System.Collections;

public class EnemyProyectilController : MonoBehaviour {
    public float velocidad;

    public EnemyController enemigo;

    public int daño;

    // Use this for initialization
    void Start()
    {
        enemigo = FindObjectOfType<EnemyController>();

      if (enemigo.transform.localScale.x < 0)
        {
            velocidad = -velocidad;
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(velocidad, GetComponent<Rigidbody2D>().velocity.y);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            HealthManager.HurtPlayer(daño);
        }

        Destroy(gameObject);
    }
}
