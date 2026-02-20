using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMoveBase : MonoBehaviour
{
    [SerializeField] protected GameObject moveObject;
    [SerializeField] protected float speed = 1f;
    private IMoveY _imoveY;
    
    private void Start()
    {
        _imoveY = this as IMoveY;
    }
    
    private void Update()
    {
        Move();
    }
    
    private void Move()
    {
        if (_imoveY != null)
            _imoveY.MoveY(1);
    }
}
