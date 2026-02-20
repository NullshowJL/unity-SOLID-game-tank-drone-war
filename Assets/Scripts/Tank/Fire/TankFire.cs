using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankFire : MonoBehaviour
{
    [SerializeField] private IProjectile projectile;
    [SerializeField] private MonoBehaviour projectileComponent;
    [SerializeField] private Transform firePos;

    private void Start()
    {
        // 优先用 Inspector 指定的组件；否则自动在本物体上找
        if (projectileComponent != null)
        {
            projectile = projectileComponent as IProjectile;
        }
        else
        {
            projectile = GetComponent<IProjectile>();
        }
    }
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameEvents.OnTankFired?.Invoke();
            
            print(projectile);
            
            if (projectile != null)
            {
                projectile.Fire(firePos);
            }
               
        }
    }
}
