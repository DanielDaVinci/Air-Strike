using UnityEngine;

class Utility
{
    public static Vector3 DirectionToVector(Direction value)
    {
        switch(value)
        {
            case Direction.Left:
                return Vector3.left;
            case Direction.Right:
                return Vector3.right;
            case Direction.Up:
                return Vector3.up;
            case Direction.Down:
                return Vector3.down;
            default:
                return Vector3.zero;
        }
    }

    public static Direction VectorToDirection(Vector3 value)
    {
        if (value == Vector3.left)
            return Direction.Left;
        else if (value == Vector3.right)
            return Direction.Right;
        else if (value == Vector3.up)
            return Direction.Up;
        else if (value == Vector3.down)
            return Direction.Down;
        else
            return Direction.Zero;
    }

    public static Vector3 Abs(Vector3 value)
    {
        value.x = Mathf.Abs(value.x);
        value.y = Mathf.Abs(value.y);
        value.z = Mathf.Abs(value.z);

        return value;
    }
}

public enum Direction
{
    Left,
    Right,
    Up,
    Down,
    Zero,
}
