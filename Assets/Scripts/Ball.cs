using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public PaddleScript paddle;
    private bool isStarted = true;
    // Use this for initialization

    private Vector3 paddleToBallVector; 

	void Start () {
        paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (isStarted) { this.transform.position = paddle.transform.position + paddleToBallVector;}
        

        if (isStarted && Input.GetMouseButtonDown(0)) {
            print("Lauch ball");
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-2f, 8f);
            isStarted = false;
        }
	}
}
