using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Wing : PlanePart
{
    [Header("Individual Properties")]
    [SerializeField] private Direction direction;

    public Direction Direction
    {
        get { return direction; }
        set
        {
            direction = value;
            if (value == Direction.Left)
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            else
                transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }

    private void OnValidate()
    {
        Direction = direction;
    }
}