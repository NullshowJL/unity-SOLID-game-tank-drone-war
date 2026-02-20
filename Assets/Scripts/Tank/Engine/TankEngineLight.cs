using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEngineLight : TankEngineBase
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
    
    // 如果Light Tank有自己的特性，可以写在这里
}
