using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour, IDamageable
{
    [SerializeField] private float healthMax = 100f;
    
    private float _health;
    [SerializeField] private Image healthProgressBar;
    [SerializeField] private TankEngineBase currentTankEngine;

    private void OnEnable()
    {
        GameEvents.OnGameStarted += ResetHealth;
    }

    private void OnDisable()
    {
        GameEvents.OnGameStarted -= ResetHealth;
    }

    private void Start()
    {
        _health = healthMax;
    }

    public void TakeDamage(int damageValue)
    {
        _health -= damageValue;
        CheckStatus();
        GameEvents.OnTankDamaged?.Invoke();
    }

    private void CheckStatus()
    {
        if (_health <= 0)
        {
            _health = 0;
            currentTankEngine.EngineDead();
        }

        float progressBarValue = _health / healthMax;
        healthProgressBar.fillAmount = progressBarValue;
    }

    private void ResetHealth()
    {
        _health = healthMax;
        healthProgressBar.fillAmount = 1;
    }
}
