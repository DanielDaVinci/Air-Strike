using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlane : MonoBehaviour
{
    [SerializeField] private Properties properties;

    public Properties Properties
    {
        get { return properties; }
    }
}
