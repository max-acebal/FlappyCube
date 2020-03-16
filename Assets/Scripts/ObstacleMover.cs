using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMover : MonoBehaviour {

    public float speedPerSecond = 10f;
    public GameObject endpoint;

	// Use this for initialization
	void Start ()
    {
        endpoint = GameObject.FindGameObjectWithTag("Endpoint");
	}
	
	// Update is called once per frame
	void Update () 
    {
        float speed = speedPerSecond * Time.deltaTime;
        Vector3 path = Vector3.MoveTowards(transform.position, endpoint.transform.position, speed);
        path.x = transform.position.x;
        path.y = transform.position.y;
        transform.position = path;
	}
}
