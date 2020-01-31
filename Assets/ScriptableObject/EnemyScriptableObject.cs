using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy data", menuName = "Enemy Data", order = 51)]
public class EnemyScriptableObject : ScriptableObject
{

	[SerializeField] private float health;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float enemyDamage;

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
}
