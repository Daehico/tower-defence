using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerArack : MonoBehaviour
{

    public float Health;
    public Towers towers;

    [SerializeField] private Enemy enemy;

    private Vector2 rangeOfTower;
    private Vector2 capsuleCollider;
    private float towerDamage;
    private float shootSpeed;
    private float coolDown = 0;

    private void Start()
    {
        
        shootSpeed = towers.ShhotInterval;
        towerDamage = towers.Damage;
        rangeOfTower = towers.Range;
        capsuleCollider =  gameObject.GetComponent<CapsuleCollider2D>().size;
        gameObject.GetComponent<CapsuleCollider2D>().size = rangeOfTower;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Enemy>())
        {
           collision.GetComponent<Enemy>().EnemyHP -= towerDamage;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<Enemy>())
        {
            Atack(collision.GetComponent<Enemy>().enemy.Health);
            coolDown += Time.deltaTime;
        }
    }

    private void Atack(float health)
    {
        if(coolDown > shootSpeed)
        {
            health -= towerDamage;
        }
        
    }

    public void Upgrade()
    {
        towers = towers.NextUpgrate;
    }
}
