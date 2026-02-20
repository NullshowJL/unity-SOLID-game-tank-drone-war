using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketShellProjectile : MonoBehaviour, IProjectile
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float speed;
    // [SerializeField] private ProjectileSO projectileSO;
    

    public void Fire(Transform firePos)
    {
        GameObject projectile = Instantiate(projectilePrefab, firePos.position, firePos.rotation);
        projectile.GetComponent<Rigidbody2D>().AddForce( firePos.up * speed, ForceMode2D.Impulse);
    }
}
