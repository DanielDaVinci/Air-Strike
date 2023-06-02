using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Data/Main Data", order = 1)]
public class MainData : ScriptableObject
{
    [SerializeField] private Amounts amounts;

    public Amounts Amounts
    {
        get { return amounts; }
    }
}

[Serializable]
public struct Amounts
{
    public uint money;
    public uint stars;
}
