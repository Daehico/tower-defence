using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New BaseData", menuName = "Base Data", order = 51)]
public class BaseScriptableObject : ScriptableObject {

    [SerializeField] private float healthOfBase;
    [SerializeField] private float gold;

    public float HealthOfBase
    {
        get
        {
            return healthOfBase;
        }
    }

    public float Gold
    {
        get
        {
            return gold;
        }       
    }
}
