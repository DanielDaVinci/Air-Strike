using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Wing : PlanePart
{
    //[Header("Individual Properties")]
    private Direction  direction;

    public Direction Direction
    {
        get { return direction; }
        set
        {
            Debug.Log("asd");
            direction = value;
            if (value == Direction.Left)
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            else
                transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }
}

public enum Direction
{
    Left,
    Right,
}
