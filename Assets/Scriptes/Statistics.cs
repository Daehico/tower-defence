using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statistics : MonoBehaviour
{
    private float gold;
    public int CurentWawe;
    public int AllWaweInLevel;

    [SerializeField] private BaseScriptableObject baseScriptableObject;
    [SerializeField] private EnemySpawner waves;

    public float Gold
    {
        get
        {
            return gold;
        }

       set
        {
            gold = value;
        }
    }

    private void Start()
    {
        Gold = baseScriptableObject.Gold;
        AllWaweInLevel = waves.wavesScriptableObjects.Length;
        CurentWawe = waves.idOfWave;
    }

    private void Update()
    {
        CurentWawe = waves.idOfWave + 1;
        
    }

    public void AddGold(float goldForKill)
    {
        Gold += goldForKill;
    }
    

}
