using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour, IDamageable
{
    private float _health = 100f;
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

        float progressBarValue = _health / 100;
        healthProgressBar.fillAmount = progressBarValue;
    }

    private void ResetHealth()
    {
        _health = 100f;
        healthProgressBar.fillAmount = 1;
    }
}
