using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonEgg : MonoBehaviour {

    public static float bottomY = -30;

    void Start() {
        
    }

    private void OnTriggerEnter(Collider collider) {
        ParticleSystem ps = GetComponent<ParticleSystem>();
        var em = ps.emission;

        em.enabled = true;

        Renderer renderer;
        renderer = GetComponent<Renderer>();
        renderer.enabled = false;
    }

    void Update() {
        if (transform.position.y < bottomY) {
            Destroy(this.gameObject);
        }
    }
}
