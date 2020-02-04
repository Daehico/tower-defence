using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    [SerializeField] private GameObject[] waypoints;

    private Enemy enemy;
    private int currentWaypoint = 0;
    private float lastWaypointSwitchTime;
    private Vector3 curentEnemyPosition;
    private Vector3 curentTargetPosition;
    private int idOfWaypoint = 0;
    private float speed;
   

    void Start()
    {
       
        curentEnemyPosition = gameObject.transform.position;
        curentTargetPosition = waypoints[idOfWaypoint].transform.localPosition;
        enemy = gameObject.GetComponent<Enemy>();
        speed = enemy.enemy.MoveSpeed;
    }

    private void Update()
    {
        if(transform.position != curentTargetPosition)
        {
            EnemyMovement();
        }

        else
        {
            idOfWaypoint++;
            GetNewCurentPosition();

        }
    }

    private void EnemyMovement()
    {
        transform.position = Vector3.MoveTowards(transform.position, curentTargetPosition, speed * Time.deltaTime);
    }

    private void GetNewCurentPosition()
    {
        curentTargetPosition = waypoints[idOfWaypoint].transform.position;
    }
}
