using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeOrDestroyTower : MonoBehaviour {

    [SerializeField] private TowerSpawner towerSpawner;
    [SerializeField] private GameObject upgradePanel;

    private Statistics statistics;
    private Towers towers;
    private BoxCollider2D boxCollider;
    private TowerSpawner[] spawner;
    
    
	void Start ()
    {
        spawner = null;
        statistics = FindObjectOfType<Statistics>();
	}

    public void DestroyTower()
    {
        Destroy(towerSpawner.PickableGameObject);
        upgradePanel.SetActive(false);
        statistics.Gold += towerSpawner.PickableGameObject.GetComponent<TowerArack>().towers.BuildPrice;
        spawner = FindObjectsOfType<TowerSpawner>();
        for(int i = 0; i < spawner.Length; i++)
        {
            if(spawner[i].gameObject.transform.position == towerSpawner.gameObject.transform.position)
            {
                spawner[i].GetComponent<BoxCollider2D>().enabled = true;
                break;
            }
        }
       
    }

    public void UpgradeTower()
    {
        
        towers = towerSpawner.PickableGameObject.gameObject.GetComponent<TowerArack>().towers;
        if (statistics.Gold >= towers.NextUpgrate.BuildPrice && towers.NextUpgrate != null)
        {
            upgradePanel.SetActive(false);
            towerSpawner.PickableGameObject.GetComponent<TowerArack>().Upgrade();
            statistics.Gold -= towerSpawner.PickableGameObject.GetComponent<TowerArack>().towers.BuildPrice;
        }
        
    }

}
