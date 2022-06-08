using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePart : MonoBehaviour
{
    [SerializeField] private Properties properties;

    public Properties Properties
    {
        get { return properties; }
    }
}
