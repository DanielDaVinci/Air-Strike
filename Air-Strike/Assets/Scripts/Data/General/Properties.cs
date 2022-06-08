using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Properties
{
    [Header("Basic")]
    [SerializeField] private float weight;
    [SerializeField] private float health;
    [SerializeField] private float moveSpeed;
    [Header("Combat")]
    [SerializeField] private float damage;
    [SerializeField] private float attackSpeed;
    [SerializeField] private float attackRange;


    public float Weight
    {
        get { return weight; }
    }

    public float Health
    {
        get { return health; }
    }

    public float MoveSpeed
    {
        get { return moveSpeed; }
    }

    public float Damage
    {
        get { return damage; }
    }

    public float AttackSpeed
    {
        get { return attackSpeed; }
    }

    public float AttackRange
    {
        get { return attackRange; }
    }
}
