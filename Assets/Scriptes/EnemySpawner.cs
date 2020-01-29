using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject spawPoint;
    [SerializeField] private int wavesOfEnemy;
    [SerializeField] private int numberOfEnemyInWave;
    [SerializeField] private float pauseBetwenTheEnemyWaves;

    void Start ()
    {
        Instantiate(enemyPrefab);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
