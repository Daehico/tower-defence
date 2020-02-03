using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class TowerSpawner : MonoBehaviour
{
    public GameObject PickableGameObject;

    [SerializeField] private GameObject[] towers;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject upgradePanel;
    

    private Touch touch;
    private Vector2 gameObjectVector2Position;
    private Statistics statistics;
    private bool upgradeOrBuildTower;
    
    private void Start()
    {
        statistics = FindObjectOfType<Statistics>();
        gameObjectVector2Position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
       
    }

    private void Update ()
    {
        if (Input.touchCount > 0)
        {
            touch =  Input.GetTouch(0);
           
        
        if (touch.phase == TouchPhase.Began)
        {
                FindGameObjectUnderMouse();
                
        }
        }
    }

    private void FindGameObjectUnderMouse()
    {
        
        var mousePosition3D = Camera.main.ScreenToWorldPoint(touch.position);
        var origin = new Vector2(mousePosition3D.x, mousePosition3D.y);
        RaycastHit2D hit = Physics2D.Raycast(origin, Vector2.zero, 0f);
        if (hit.collider != null)
        {
            if (hit.collider.GetComponent<TowerSpawner>())
            {       if(upgradePanel.activeSelf == false)
                {
                    PickableGameObject = hit.collider.gameObject;
                    panel.SetActive(true);
                }
                              
            }

            if (hit.collider.GetComponent<TowerArack>())
            {
                if (panel.activeSelf == false)
                {
                    upgradeOrBuildTower = true;
                    upgradePanel.SetActive(true);
                    PickableGameObject = hit.collider.gameObject;
                    upgradeOrBuildTower = false;
                    
                }
            }
           
        }
           
    }

    public void BuildTower(int idOfTower, GameObject pick)
    {
        if(statistics.Gold >= towers[idOfTower].GetComponent<TowerArack>().towers.BuildPrice)
        {
            Instantiate(towers[idOfTower], pick.transform.position, Quaternion.identity);
            panel.SetActive(false);
            statistics.Gold -= towers[idOfTower].GetComponent<TowerArack>().towers.BuildPrice;
            pick.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
        
    }

   

    
}
