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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Enemy>())
        {
            Instantiate(arrow, gameObject.transform.position, Quaternion.identity);
            curentTargetPosition = FindObjectOfType<Enemy>().gameObject.transform.position;
            arrow.transform.position = Vector3.MoveTowards(transform.position, curentTargetPosition, speed * Time.deltaTime);
            if (arrow.GetComponent<Arrow>().CollideOrNot == true)
            {
                collision.GetComponent<Enemy>().EnemyHP -= towerDamage;
                coolDown += Time.deltaTime;
            }
            
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<Enemy>())
        {
            Instantiate(arrow, gameObject.transform.position, Quaternion.identity);
            arrow.transform.position =  Vector3.MoveTowards(transform.position, curentTargetPosition, speed * Time.deltaTime);
            if (arrow.GetComponent<Arrow>().CollideOrNot == true)
            {
                Atack(collision.GetComponent<Enemy>().enemy.Health);
                coolDown += Time.deltaTime;
            }
           
        }
    }

    private void Atack(float health)
    {
        if(coolDown > shootSpeed)
        {
            health -= towerDamage;
            arrow.GetComponent<Arrow>().CollideOrNot = false;
            Destroy(arrow.gameObject);
            
        }
        
    }

    public void Upgrade()
    {
        towers = towers.NextUpgrate;
    }
}
