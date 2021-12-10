using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour
{

	public int maxHealth = 40;
	public int currentHealth;
	public healthBar healthBar;
	public float twoSec = 1;
	public bool timer = true;
	public GameObject Player;
	public Rigidbody PlayerBody;
	int i;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
        gameObject.tag = "Player";
        PlayerBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(currentHealth<=0){
    		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    	}

        
        if(timer){
        	twoSec -= Time.smoothDeltaTime;
        	if(twoSec >= 0){
        		Debug.Log(i++);
        	}
        	else{
        		Debug.Log("Done");
        		timer = false;
        	}
        }
    
}

    void TakeDamage(int damage){
    	currentHealth -= damage;
    	healthBar.SetHealth(currentHealth);
    }
    
    void OnCollisionEnter(){

    	TakeDamage(4);
    	
    	
    }
    void playerDeath(){
    	if(currentHealth<=0){
    		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    	}
    }
}
