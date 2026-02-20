using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    [SerializeField] private List<TankEngineBase> engines;
    
    private void OnEnable()
    {
        GameEvents.OnTankDamaged += CheckEngine;
    }

    private void OnDisable()
    {
        GameEvents.OnTankDamaged -= CheckEngine;
    }

    public void CheckEngine()
    {
        bool isGameOver = true;
        for (int i = 0; i < engines.Count; i++)
        {
            if (engines[i].GetStatus() == TankEngineBase.EngineStatus.Working)
            {
                isGameOver = false;
                break;
            }
        }

        if(isGameOver)
            GameEvents.OnGameOver?.Invoke();
    }
}
