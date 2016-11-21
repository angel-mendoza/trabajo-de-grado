using UnityEngine;
using System.Collections;

public class TrampolinController : MonoBehaviour {
    public PlayerController player;
    private Animator anim;
    // Use this for initialization
    void Start () {
        player = FindObjectOfType<PlayerController>();
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            GetComponent<AudioSource>().Play();
            anim.SetBool("trampolin", true);
        }

    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            anim.SetBool("trampolin", false);
        }

    }
}
