using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerArack : MonoBehaviour
{

    public float Health;
    public Towers towers;

    [SerializeField] private Enemy enemy;
    [SerializeField] private GameObject arrow;
    [SerializeField] private float speed;

    private Vector3 curentTargetPosition;
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

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<Enemy>())
        {
            if(coolDown >= shootSpeed)
            {
                enemy = FindObjectOfType<Enemy>();
                enemy.EnemyHP -= enemy.enemy.EnemyDamage;
            }
            else
            {
                coolDown += Time.deltaTime;
            }
            
        }
    }

    public void Upgrade()
    {
        towers = towers.NextUpgrate;
    }

    private void Update()
    {
        Debug.Log(coolDown);
    }
}
