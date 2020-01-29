using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    [SerializeField] private GameObject[] waypoints;
    [SerializeField] private float speed;

    private int currentWaypoint = 0;
    private float lastWaypointSwitchTime;
    private Vector3 curentEnemyPosition;
    private Vector3 curentTargetPosition;
    private int idOfWaypoint = 0;


    void Start()
    {
        curentEnemyPosition = gameObject.transform.position;
        curentTargetPosition = waypoints[idOfWaypoint].transform.position;
    }


    //void Update ()
    //   {
    //       Vector3 startPosition = waypoints[currentWaypoint].transform.position;
    //       Vector3 endPosition = waypoints[currentWaypoint + 1].transform.position;
    //       // 2 
    //       float pathLength = Vector3.Distance(startPosition, endPosition);
    //       float totalTimeForPath = pathLength / speed;
    //       float currentTimeOnPath = Time.time - lastWaypointSwitchTime;
    //       gameObject.transform.position = Vector2.Lerp(startPosition, endPosition, currentTimeOnPath / totalTimeForPath);
    //       // 3 
    //       if (gameObject.transform.position.Equals(endPosition))
    //       {
    //           if (currentWaypoint < waypoints.Length - 2)
    //           {
    //               // 3.a 
    //               currentWaypoint++;
    //               lastWaypointSwitchTime = Time.time;
    //               // TODO: поворачиваться в направлении движения
    //           }
    //           else
    //           {
    //               // 3.b 
    //               Destroy(gameObject);

    //               AudioSource audioSource = gameObject.GetComponent<AudioSource>();
    //               AudioSource.PlayClipAtPoint(audioSource.clip, transform.position);
    //               // TODO: вычитать здоровье
    //           }
    //       }
    //   }

    private void Update()
    {
        if(transform.localPosition != curentTargetPosition)
        {
            EnemyMovement();
        }

        else
        {
            idOfWaypoint++;
            GetNewCurentPosition();

        }

        //transform.position = Vector3.Lerp(curentEnemyPosition, curentTargetPosition, speed);
    }

    private void EnemyMovement()
    {
        transform.position = Vector3.MoveTowards(transform.localPosition, curentTargetPosition, speed * Time.deltaTime);
    }

    private void GetNewCurentPosition()
    {
        curentTargetPosition = waypoints[idOfWaypoint].transform.position;
    }
}
