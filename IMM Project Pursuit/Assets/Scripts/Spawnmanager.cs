using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmanager : MonoBehaviour
{

	RoadSpawner RoadSpawner;
    // Start is called before the first frame update
    void Start()
    {
        RoadSpawner = GetComponent<RoadSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTriggerEntered()
    {
    	RoadSpawner.MoveRoad();
    }

}
