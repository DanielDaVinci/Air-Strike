using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cockpit : PlanePart
{
    [Header("Individual Properties")]
    [SerializeField] private float maxWeight;

    public float MaxWeight
    {
        get { return maxWeight; }
    }
}
