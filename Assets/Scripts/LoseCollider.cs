using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

    private LevelManager manager;

    private void Start()
    {
        manager = GameObject.FindObjectOfType<LevelManager>();
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        print("Trigger");
        manager.LoadLevel("Loose");

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
        
    }
}
