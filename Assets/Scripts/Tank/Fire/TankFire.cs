using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankFire : MonoBehaviour
{
    [SerializeField] private IProjectile projectile;
    [SerializeField] private MonoBehaviour projectileComponent;
    [SerializeField] private Transform firePos;
    [SerializeField] private float cooldownSeconds;
    
    private float timer;

    private void Start()
    {
        if (projectileComponent != null)
        {
            projectile = projectileComponent as IProjectile;
        }
        
        timer = cooldownSeconds;
    }
    

    private void Update()
    {
        if (timer < cooldownSeconds)
        {
            timer += Time.deltaTime;
        }
        print(timer);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(projectile == null) 
                return;

            if (timer >= cooldownSeconds)
            {
                projectile.Fire(firePos);
                GameEvents.OnTankFired?.Invoke();

                timer = 0;
            }


        }
    }
}
