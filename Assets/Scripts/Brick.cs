using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public Sprite[] hitSprites;

    private int maxHits;
    private int hits;
    private LevelManager levelManager;

	// Use this for initialization
	void Start () {
        hits = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        maxHits = hitSprites.Length + 1;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool isBreakable = (this.tag == "Breakable");
        if (isBreakable)
        {
            HandleCollision();
        }
    }

    void HandleCollision()
    {
        hits++;
        Debug.Log("Brick has been hit. " + (maxHits - hits) + " hits left");
        if (maxHits <= hits)
        {
            Destroy(this.gameObject);
        }
        else
        {
            LoadScript();
        }
    }

    void LoadScript()
    {
        if (hitSprites[(maxHits - hits) - 1]) {
            GetComponent<SpriteRenderer>().sprite = hitSprites[(maxHits - hits) - 1];
        }
    }

    void SimulateWin()
    {
        levelManager.LoadNextLevel();
    }
}
