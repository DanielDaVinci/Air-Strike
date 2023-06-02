using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class PlanePart : MonoBehaviour
{
    [SerializeField] private Properties properties;

    public Properties Properties
    {
        get { return properties; }
    }
}