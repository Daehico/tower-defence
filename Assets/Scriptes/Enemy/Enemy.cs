using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{  
    public EnemyScriptableObject enemy;
    public float EnemyHP;
    
    [SerializeField] private float goaldForKill;
    private Statistics statistics;

    private void Start()
    {
        EnemyHP = enemy.Health;
        statistics = FindObjectOfType<Statistics>();
    }
    private void Update()
    {
        if(EnemyHP <= 0)
        {
            statistics.AddGold(Random.Range(enemy.MinGoldForKill, enemy.MaxGoldForKill));
            Destroy(gameObject);
           
        }
        
    }
}
