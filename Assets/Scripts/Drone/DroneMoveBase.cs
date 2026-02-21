using System;
using UnityEngine;

public class DroneMoveBase : MonoBehaviour
{
    [Serializable]
    public struct BorderY
    {
        public float minY;
        public float maxY;
    }
    
    [SerializeField] private BorderY borderY;
    
    [SerializeField] protected GameObject moveObject;
    [SerializeField] protected float speed = 1f;
    private IMoveY _imoveY;
    
    protected virtual void Start()
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
        {
            _imoveY.MoveY(1);

            Vector3 pos = moveObject.transform.position;
            pos.y = Mathf.Clamp(pos.y, borderY.minY, borderY.maxY);
            moveObject.transform.position = pos;
        }
        
    }
}
