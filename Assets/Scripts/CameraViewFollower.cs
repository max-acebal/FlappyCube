using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraViewFollower : MonoBehaviour {

    // Use this for initialization


    public GameObject toFollow;

    

    // Update is called once per frame
    void Update () {
        if(toFollow != null)
        {
            transform.LookAt(toFollow.transform);
        }
       
	}
}
