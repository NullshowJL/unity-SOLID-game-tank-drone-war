using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEngineMedium : TankEngineBase
{
    public override void StartEngine()
    {
        base.StartEngine();
        if (tankFire != null)
        {
            tankFire.enabled = true;
        }
        if (tankMove != null)
        {
            tankMove.enabled = true;
        }
        if (tankRotate != null)
        {
            tankRotate.enabled = true;
        }
    }
    
    public override void StopEngine()
    {
        base.StopEngine();
        if (tankFire != null)
        {
            tankFire.enabled = false;
        }
        if (tankMove != null)
        {
            tankMove.enabled = false;
        }
        if (tankRotate != null)
        {
            tankRotate.enabled = false;
        }
    }
}
