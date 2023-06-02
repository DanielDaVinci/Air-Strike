using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Utility;

public class Gun : PlanePart
{
    #region constants
    const float MaxBulletSpeed = 1000;
    #endregion

    [Header("Individual Properties")]
    [SerializeField] private float BulletSpeed;
    [SerializeField] private float AttackRange;
    [Header("Data")]
    [SerializeField] private GameObject bulletPrefab;

    public GameObject BulletPrefab
    {
        get { return bulletPrefab; }
    }

    private void Start()
    {
        Bullet bullet = bulletPrefab.GetComponent<Bullet>() ?? bulletPrefab.AddComponent<Bullet>();
    }

    // Combat
    Coroutine process;

    public void Attack()
    {
        process = StartCoroutine(CreateBullets());
    }

    public void StopAttack()
    {
        StopCoroutine(process);
    }

    private IEnumerator CreateBullets()
    {
        while (true)
        {
            GameObject bulletObject = Instantiate(bulletPrefab);
            bulletObject.transform.position = transform.position;
            bulletObject.tag = gameObject.tag;

            // Set properties
            Bullet bullet = bulletObject.GetComponent<Bullet>();
            bullet.Damage = Properties.Damage;
            bullet.Speed = BulletSpeed;
            bullet.Range = AttackRange;

            Vector3 direction = transform.parent.TransformPoint(transform.localPosition + new Vector3(0, -1, 0)) - transform.position;
            bullet.Direction = direction;

            yield return new WaitForSeconds((MaxBulletSpeed - Properties.AttackSpeed) / MaxBulletSpeed);
        }
    }
}
