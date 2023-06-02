using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct Properties
{
    [Header("Basic")]
    [Min(0)]
    public float Weight;
    [Min(0)]
    public float Health;
    [Min(0)]
    public float Shield;
    [Min(0)]
    public float MoveSpeed;
    [Header("Combat")]
    [Min(0)]
    public float Damage;
    [Range(0, 1000)]
    public float AttackSpeed;

    public static Properties operator + (Properties first, Properties second)
    {
        Properties result = new Properties
        {
            Weight      = first.Weight + second.Weight,
            Health      = first.Health + second.Health,
            Shield      = first.Shield + second.Shield,
            MoveSpeed   = first.MoveSpeed + second.MoveSpeed,
            Damage      = first.Damage + second.Damage,
            AttackSpeed = first.AttackSpeed + second.AttackSpeed,
        };

        return result;
    }
}
