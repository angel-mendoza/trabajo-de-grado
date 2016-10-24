using UnityEngine;
using System.Collections;

public class DestroyFinishParticle : MonoBehaviour {

    private ParticleSystem EsteSistemaDeParticulas;

    // Use this for initialization
    void Start() {
        EsteSistemaDeParticulas = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update() {
        if (EsteSistemaDeParticulas.isPlaying)
        {
            return;
        }

        Destroy(gameObject);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
