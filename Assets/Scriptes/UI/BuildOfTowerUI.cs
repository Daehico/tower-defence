using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildOfTowerUI : MonoBehaviour {

    [SerializeField] private GameObject towerSpawner;

    private TowerSpawner _towerSpawner;

    private void Start()
    {
        _towerSpawner = towerSpawner.GetComponent<TowerSpawner>();
    }

    public void BuildFirstClassTower()
    {
        _towerSpawner.BuildTower(0,_towerSpawner.PickableGameObject);
    }
    public void BuildSecondClassTower()
    {
        _towerSpawner.BuildTower(1, _towerSpawner.PickableGameObject);
    }
    public void BuildThirdClassTower()
    {
        _towerSpawner.BuildTower(2, _towerSpawner.PickableGameObject);
    }
    public void BuildFourthClassTower()
    {
        _towerSpawner.BuildTower(3, _towerSpawner.PickableGameObject);
    }

}
