using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEngineBase : MonoBehaviour
{
    public enum EngineStatus
    {
        Working,
        NotWorking
    }
    
    [SerializeField] protected TankFire tankFire;
    [SerializeField] protected TankMoveBase tankMove;
    [SerializeField] protected TankRotate tankRotate;
    private EngineStatus _status = EngineStatus.Working;

    public virtual void StartEngine(){ }

    public virtual void StopEngine() { }
    
    public void EngineDead()
    {   
        StopEngine();
        _status = EngineStatus.NotWorking;
    }

    public EngineStatus GetStatus()
    {
        return _status;
    }
}
