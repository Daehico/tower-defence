using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public WavesScriptableObject[] wavesScriptableObjects;
    public int idOfWave;

    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject spawnPoint;
  

    private float cooldown;
    private float curentTimeOfWave;
   

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
