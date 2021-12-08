using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{


	public float movementSpeed = 5f;
	public Spawnmanager spawnManager;
    public bool Moving = true;
    public float maxSpeed = 1000f;
    public Transform position;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    		float hMovement = Input.GetAxis("Horizontal")*movementSpeed;




    		transform.Translate(Vector3.forward*Time.deltaTime*(movementSpeed/2));
    		transform.Translate(new Vector3(hMovement,0)*Time.deltaTime	);
            if(Moving == true)
            {
                movementSpeed += 0.00005f;
            }
            if(movementSpeed>=maxSpeed){
                movementSpeed = maxSpeed;
            }
    }
    private void OnTriggerEnter(Collider other)
    {
    	spawnManager.SpawnTriggerEntered();
    }
}
