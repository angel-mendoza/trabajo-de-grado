using UnityEngine;
using System.Collections;

public class BloqueController : MonoBehaviour {
    public int daño;

    // Use this for initialization
    void Start () {
        /*
         * de esta forma hago la parabola de bala de cañon 
        GetComponent<Rigidbody2D>().AddRelativeForce(transform.right * fuerza, ForceMode2D.Impulse);
        GetComponent<Rigidbody2D>().AddRelativeForce(transform.up * fuerza, ForceMode2D.Impulse);
        */
        
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemigo")
        {
            other.GetComponent<EnemyHealthManager>().dañoQueDara(daño);
            
        }
    }

}
