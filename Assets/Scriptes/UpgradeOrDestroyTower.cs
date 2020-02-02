using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeOrDestroyTower : MonoBehaviour {

    [SerializeField] private TowerSpawner towerSpawner;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DestroyTower()
    {
        Destroy(towerSpawner.PickableGameObject);
    }

    public void UpgradeTower()
    {
        var test = towerSpawner.PickableGameObject.GetComponent<TowerArack>().towers;
        test = test.NextUpgrate;
    }

}
