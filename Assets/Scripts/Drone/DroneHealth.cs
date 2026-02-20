using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneHealth : MonoBehaviour
{
    [SerializeField] private int damage = 20;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Shell"))
        {
            GameEvents.OnDroneDestroy?.Invoke(); // 飞机被子弹击中才会播放声音
        }
        else
        {
            // 通过接口调用TakeDamage
            IDamageable damageable = other.gameObject.GetComponent<IDamageable>();
            if (damageable != null)
            {
                damageable.TakeDamage(damage);
            }
        }
        
        Destroy(gameObject);
    }
    
    // 因为在子弹中已经调用过一次TakeDamage了，所以飞机自身的脚本不再调用，以免检测两次，计分有误
}
