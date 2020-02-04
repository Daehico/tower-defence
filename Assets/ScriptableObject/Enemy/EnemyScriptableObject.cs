using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy data", menuName = "Enemy Data", order = 51)]
public class EnemyScriptableObject : ScriptableObject
{

	[SerializeField] private float health;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float enemyDamage;
    [SerializeField] private float minGoldForKill;
    [SerializeField] private float maxGoldForKill;

    public float Health
    {
        get
        {
            return health;
        }
    }

    public float MoveSpeed
    {
        get
        {
            return moveSpeed;
        }
    }

    public float EnemyDamage
    {
        get
        {
            return enemyDamage;
        }
    }

    public float MinGoldForKill
    {
        get
        {
            return minGoldForKill;
        }
    }

    public float MaxGoldForKill
    {
        get
        {
            return maxGoldForKill;
        }
    }
}
