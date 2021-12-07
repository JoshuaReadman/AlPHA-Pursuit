using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public float movementSpeed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float hMovement = Input.GetAxis("Horizontal")*movementSpeed;
       transform.Translate(Vector3.up*Time.deltaTime*(movementSpeed/2));
    		transform.Translate(new Vector3(hMovement,0)*Time.deltaTime	);
    }
}
