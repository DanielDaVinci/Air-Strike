using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerPlane playerPlane;

    private void Start()
    {
        playerPlane.Attack();
    }
}
