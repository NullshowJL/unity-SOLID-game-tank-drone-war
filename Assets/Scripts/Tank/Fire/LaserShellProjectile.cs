using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShellProjectile : MonoBehaviour, IProjectile
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float speed;
    private static readonly float[] Angles = { 0, 30, -30, 60, -60 };
    

    public void Fire(Transform firePos)
    {
        foreach (float angle in Angles)
        {
            Quaternion rotation = firePos.rotation * Quaternion.Euler(0, 0, angle);
            GameObject projectile = Instantiate(projectilePrefab, firePos.position, rotation);
            projectile.GetComponent<Rigidbody2D>().AddForce(rotation * Vector3.up * speed, ForceMode2D.Impulse);
        }
    }
}
