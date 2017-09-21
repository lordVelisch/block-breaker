using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {
    
    static MusicPlayer tmp = null; 
	// Use this for initialization
	void Start () {
        if (tmp != null)
        {
            Destroy(gameObject);
        }
        else {
            tmp = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
