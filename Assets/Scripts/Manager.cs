using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    private int score = 0;
    public Text scoreText;
    public int obstacleCountMax = 10;
    public float obstacleSpacing = 50f;
    public GameObject spawn;
    public GameObject spawnableObstacle;
    public GameObject spawnableObstacle2;
   

	// Use this for initialization
	void Awake () 
    {
        for (int i = 0; i < obstacleCountMax; i++)
        {
            int randDist = Random.Range(2, 8);
            int obstacleSelect = 2;

            if(obstacleSelect%2 == 0)
            {
                Vector3 adjustSpawn = spawn.transform.position + new Vector3(0, randDist, i * obstacleSpacing);
                GameObject obstacle = Instantiate(spawnableObstacle, adjustSpawn, spawn.transform.rotation);
            }

            else if(obstacleSelect%2 != 0)
            {
                Vector3 adjustSpawn = spawn.transform.position + new Vector3(0, 0, i * obstacleSpacing);
                GameObject obstacle = Instantiate(spawnableObstacle2, adjustSpawn, spawn.transform.rotation);
            }
           
        }

       
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    public int Score
    {
        get; set;
    }

}
