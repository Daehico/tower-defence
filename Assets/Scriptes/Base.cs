using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour {

    [SerializeField] private EnemyScriptableObject enemy;
    [SerializeField] private float heathPointOfBase;

    private void Update()
    {
        if(heathPointOfBase <= 0)
        {
            Debug.Log("Death");
        }
        Debug.Log(Statistics.Gold);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.GetComponent<Enemy>())
        {
            heathPointOfBase -= collision.GetComponent<Enemy>().enemy.EnemyDamage;
            Destroy(collision.gameObject);
        }
    }
}
