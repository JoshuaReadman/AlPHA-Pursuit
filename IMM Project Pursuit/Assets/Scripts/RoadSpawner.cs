using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{

	public List<GameObject> roads;
	private float offset = 36f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MoveRoad()
    {
    	GameObject movedRoad = roads[0];
    	roads.Remove(movedRoad);
    	float newZ = roads[roads.Count - 1].transform.position.z + offset;
    	movedRoad.transform.position = new Vector3(0, 0, newZ);
    	roads.Add(movedRoad);
    }
    
}
