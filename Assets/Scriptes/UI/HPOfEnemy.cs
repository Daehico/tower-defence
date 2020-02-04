using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPOfEnemy : MonoBehaviour {

    private Enemy enemy;
    private float maxHp;
    private float currentHP;
    private float originalScale;

    void Start ()
    {
       enemy = GetComponentInParent<Enemy>();
        maxHp = enemy.EnemyHP;
        originalScale = gameObject.transform.localScale.x;
    }
	
	// Update is called once per frame
	void Update ()
    {
        currentHP = enemy.EnemyHP;
        Vector3 tmpScale = gameObject.transform.localScale;
        tmpScale.x = currentHP / maxHp * originalScale;
        gameObject.transform.localScale = tmpScale;
    }
}
