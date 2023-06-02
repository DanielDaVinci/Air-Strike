using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerPlane playerPlane;

    private Vector3 lastTouchPosition;
    private bool    isTouching;

    private Vector3 minPosition;
    private Vector3 maxPosition;

    private void Start()
    {
        minPosition = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        minPosition.z = 0;
        maxPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        maxPosition.z = 0;
    }

    void Update()
    {
#if UNITY_IPHONE || UNITY_ANDROID
        if (Input.touchCount > 0)
        {
            isTouching = true;
            OnTouchDown();
        }
        else
        {
            isTouching = false;
            OnTouchUp();
        }

        if (isTouching)
            OnTouching();
#endif
#if UNITY_STANDALONE_WIN
        if (Input.GetMouseButtonDown(0))
        {
            isTouching = true;
            OnTouchDown();
        }
        if (Input.GetMouseButtonUp(0))
        {
            isTouching = false;
            OnTouchUp();
        }

        if (isTouching)
            OnTouching();
#endif
    }

    private void OnTouchDown()
    {
#if UNITY_IPHONE || UNITY_ANDROID
        lastPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
#endif
#if UNITY_STANDALONE_WIN
        lastTouchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
#endif
    }

    private void OnTouchUp()
    {

    }

    private void OnTouching()
    {
#if UNITY_IPHONE || UNITY_ANDROID
        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
#endif
#if UNITY_STANDALONE_WIN
        Vector3 currentTouchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
#endif
        Vector3 delta = currentTouchPosition - lastTouchPosition;
        transform.position = Clamp(transform.position + delta, minPosition, maxPosition);
        lastTouchPosition = currentTouchPosition;
    }

    private static Vector3 Clamp(Vector3 value, Vector3 min, Vector3 max)
    {
        value.x = Mathf.Clamp(value.x, min.x, max.x);
        value.y = Mathf.Clamp(value.y, min.y, max.y);
        value.z = Mathf.Clamp(value.z, min.z, max.z);

        return value;
    }
}