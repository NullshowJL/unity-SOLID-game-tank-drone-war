using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEngineSelector : MonoBehaviour
{
    [SerializeField] private TankEngineBase lightEngine;
    [SerializeField] private TankEngineBase mediumEngine;
    [SerializeField] private TankEngineBase heavyEngine;

    private void Start()
    {
        StopAllEngines();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (lightEngine.GetStatus() == TankEngineBase.EngineStatus.NotWorking)
                return;
            
            StopAllEngines();
            lightEngine.StartEngine();
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            if (mediumEngine.GetStatus() == TankEngineBase.EngineStatus.NotWorking)
                return;

            StopAllEngines();
            mediumEngine.StartEngine();
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            if (heavyEngine.GetStatus() == TankEngineBase.EngineStatus.NotWorking)
                return;
            
            StopAllEngines();
            heavyEngine.StartEngine();
        }
    }

    private void StopAllEngines()
    {
        lightEngine.StopEngine();
        mediumEngine.StopEngine();
        heavyEngine.StopEngine();
    }
}
