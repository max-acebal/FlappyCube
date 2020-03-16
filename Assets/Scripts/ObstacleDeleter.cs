using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDeleter : MonoBehaviour {

    private Manager managerScript;


	// Use this for initialization
	void Start () 
    {
        managerScript = GetComponent<Manager>();

		
	}
	
	// Update is called once per frame
	void Update () 
    {

		
	}

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        managerScript.Score += 1;
        managerScript.scoreText.text = "Score: " + managerScript.Score.ToString(); 

        int randDist = Random.Range(2, 8);
        int obstacleSelect = 2;

        if (obstacleSelect % 2 == 0)
        {
            Vector3 adjustSpawn = managerScript.spawn.transform.position + new Vector3(0, randDist, (managerScript.obstacleCountMax - 1) * managerScript.obstacleSpacing);
            GameObject obstacle = Instantiate(managerScript.spawnableObstacle, adjustSpawn, managerScript.transform.rotation);
        }
        else if (obstacleSelect% 2 != 0)
        {
            Vector3 adjustSpawn = managerScript.spawn.transform.position + new Vector3(0, 0, (managerScript.obstacleCountMax - 1) * managerScript.obstacleSpacing);
            GameObject obstacle = Instantiate(managerScript.spawnableObstacle2, adjustSpawn, managerScript.transform.rotation);
        }



    }
}
