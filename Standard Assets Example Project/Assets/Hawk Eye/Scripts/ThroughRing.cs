using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThroughRing : MonoBehaviour {
    Renderer rend;
    AudioSource audioSource;
    [SerializeField]Collider playerCollider;
    void Start()
    {
        rend = GetComponent<Renderer>();
        audioSource = GetComponent<AudioSource>();
        if(playerCollider == null)
        {
            playerCollider = GameObject.Find("Colliders").GetComponent<Collider>();
        }
    }

    void OnTriggerEnter(Collider collider) {
        if (collider == playerCollider && (!GameManager.GameFinished))
        {
            GameManager.Score += 300;
            rend.enabled = false;
            audioSource.Play();
            Destroy(this.gameObject, 5f);
        }
    }
}
