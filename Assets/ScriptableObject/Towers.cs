using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New TowerData", menuName = "Tower Data", order = 51)]
public class Towers : ScriptableObject
{

    [SerializeField] private int Id;
    [SerializeField] private ClassesOfTowers classes;
    [SerializeField] private float buildPrice;
    [SerializeField] private Vector2 range;
    [SerializeField] private float shhotInterval;
    [SerializeField] private float damage;


    public int Id1
    {
        get
        {
            return Id;
        }

    }

    public float BuildPrice
    {
        get
        {
            return buildPrice;
        }

    }

   

    public float ShhotInterval
    {
        get
        {
            return shhotInterval;
        }

    }

    public float Damage
    {
        get
        {
            return damage;
        }
    }

    public Vector2 Range
    {
        get
        {
            return range;
        }

        
    }

    private ClassesOfTowers Classes
    {
        get
        {
            return classes;
        }


    }


    enum ClassesOfTowers
    {
        FirstClassOfTower,
        SecondClassOfTower,
        ThirdClassOfTower,
        ForthClassOfTower
    };
}
