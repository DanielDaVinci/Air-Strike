using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : PlanePart
{
    //[Header("Individual Properties")]
    [Header("Data")]
    [SerializeField] private GameObject fireTrail;

    public GameObject FireTrail
    {
        get { return fireTrail; }
    }

}
