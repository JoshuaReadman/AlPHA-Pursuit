using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{


	public float movementSpeed = 10f;
	public Spawnmanager spawnManager;
    public bool Moving = true;
    public float maxSpeed = 1000f;
    public Transform position;
    public float turnSpeedx = 0f;
    public float turnSpeedy = 10f;
    public float turnSpeedz = 0f;
    
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    		float hMovement = Input.GetAxis("Horizontal")*movementSpeed;
            float rMovement = Input.GetAxis("Horizontal")*5;

            transform.Rotate(new Vector3(0,rMovement,0)/1);
//dick



    		transform.Translate(Vector3.left*Time.deltaTime*(movementSpeed/2));
    		
            if(Moving == true)
            {
                movementSpeed += 0.00018f;
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
