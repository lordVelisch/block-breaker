using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int maxHits;
    public int hits;

    public GameObject hit1;
    public GameObject hit2;
    public GameObject hit3;
	// Use this for initialization
	void Start () {
        hits = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hits++;
        Debug.Log("Brick has been hit. " + (maxHits - hits) + " hits left");
        if ((maxHits - hits) <= 0)
        {
            Destroy(this.gameObject);
        }
        else if (maxHits - hits == 1) {
            GameObject temp = this.gameObject;
            Destroy(this.gameObject);
            Instantiate(hit1);
        }
    }
}
