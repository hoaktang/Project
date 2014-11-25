﻿using UnityEngine;

public class EnemyManager : MonoBehaviour
{
	public PlayerHealth playerHealth;       // Reference to the player's heatlh.
	public GameObject enemy;                // The enemy prefab to be spawned.
	public float spawnTime = 1f;            // How long between each spawn.
	public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
	
	
	void Start ()
	{
		// Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	
	
	void Spawn ()
	{
		// If the player has no health left...
		if(playerHealth.currentHealth <= 0f)
		{
			// ... exit the function.
			return;
		}

		
		// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
		Instantiate (enemy, new Vector3(-3.3F, 0,37.1F), Quaternion.identity);
		Instantiate (enemy, new Vector3(-38.70989F, 0,37.1F), Quaternion.identity);
		Instantiate (enemy, new Vector3(33.7F, 0,36.5F), Quaternion.Euler(0,180F,0));
	
	}
}