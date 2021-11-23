using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RoadSpawner : MonoBehaviour
{

	public List<GameObject> Roads;
	private float offset = 32f;
    // Start is called before the first frame update
    void Start()
    {
        if(Roads != null && Roads.Count > 0)
        {
        	Roads = Roads.OrderBy(R=> R.transform.position.z).ToList();
        }
    }

    public void MoveRoad()
    {
    	GameObject movedRoad = Roads[0];
    	Roads.Remove(movedRoad);
    	float newZ = Roads[Roads.Count - 1].transform.position.z + offset;
    	movedRoad.transform.position = new Vector3(1, 4, newZ);
    	Roads.Add(movedRoad);
    }
    
}
