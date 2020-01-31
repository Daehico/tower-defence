using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private WavesScriptableObject[] wavesScriptableObjects;

    private float cooldown;
    private float curentTimeOfWave;
    private int idOfWave;

    void Start ()
    {
        idOfWave = 0;
        cooldown = 0;
        Instantiate(enemyPrefab,spawnPoint.transform.position,Quaternion.identity);
	}
	

	void Update ()
    {
        if(curentTimeOfWave <= wavesScriptableObjects[idOfWave].TimeOfWaves)
        {
            curentTimeOfWave += Time.deltaTime;
            if (cooldown >= wavesScriptableObjects[idOfWave].TimeBeetweenSpaunOfMob)
            {
                Instantiate(enemyPrefab, spawnPoint.transform.position, Quaternion.identity);
                cooldown = 0;
            }
            else
            {
                cooldown += Time.deltaTime;
            }
        }
        else
        {
            idOfWave++;
            curentTimeOfWave = 0;
        }
        
	}
}
