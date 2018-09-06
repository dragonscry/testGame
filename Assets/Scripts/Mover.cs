using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public float speed;

	
	// Update is called once per frame
    void Update () {
        Move();
		
	}

    void Move()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
