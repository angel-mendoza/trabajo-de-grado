using UnityEngine;
using System.Collections;

public class FlyerEnemyMove : MonoBehaviour {

    private PlayerController player;
    public float velocidad;
    public float rango;
    public LayerMask playerLayer;
    public bool enLaZona;

    public bool facingAway;
    public bool followOnLookAway;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (player.transform.position.x < transform.position.x)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }


        enLaZona = Physics2D.OverlapCircle(transform.position, rango, playerLayer);

        if (!followOnLookAway)
        {
            if (enLaZona)
            {
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, velocidad * Time.deltaTime);
                return;
            }
        }
        /* 
                if((player.transform.position.x < transform.position.x && player.transform.position.x < 0) || (player.transform.position.x > transform.position.x && player.transform.position.x > 0))
                {
                    facingAway = true;
                }
                else
                {
                    facingAway = false;
                }

               if (enLaZona && facingAway)
                {
                    transform.position = Vector3.MoveTowards(transform.position, player.transform.position, velocidad * Time.deltaTime);
                    return;
                }
        */
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawSphere(transform.position, rango);
 
    }
}
