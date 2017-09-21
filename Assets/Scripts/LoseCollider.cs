using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

    public LevelManager manager;

    void OnTriggerEnter2D(Collider2D trigger)
    {
        print("Trigger");
        manager.LoadLevel("Win");

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
        
    }
}
