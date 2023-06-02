using UnityEngine;
using static Utility;

[RequireComponent(typeof(BoxCollider2D))]
public class Bullet : MonoBehaviour
{
    [Header("Properties")]
    public float   Damage;
    public float   Speed;
    public float   Range = 0;
    public Vector3 Direction;

    private float currentRange;

    private Transform _transform;

    private void Start()
    {
        _transform = transform;

        float angle = -1 * Mathf.Sign(Direction.x) * Vector3.Angle(Direction, Vector3.up);
        _transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    private void Update()
    {
        Vector3 shift = Direction * Speed * Time.deltaTime;
        _transform.localPosition += shift;

        currentRange += Speed * Time.deltaTime;

        CheckExitRange();
        CheckExitScreen();
    }

    private void CheckExitRange()
    {
        if (currentRange > Range)
            Destroy(gameObject);
    }

    private void CheckExitScreen()
    {
        if (!gameObject.GetComponent<Renderer>().isVisible)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != gameObject.tag)
            ; // something
    }
}
