using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TankMoveBase : MonoBehaviour
{
    [SerializeField] protected GameObject moveObject;
    [SerializeField] protected float speed = 1f;
    
    private IMoveY imoveY;
    
    [Serializable]
    public struct BorderY
    {
        public float minY;
        public float maxY;
    }
    
    [SerializeField] private BorderY borderY;

    private void Start()
    {
        imoveY = this as IMoveY;
    }

    private void Update()
    {
        Move();
    }
    
    private void Move()
    {
        float inputValue = Input.GetAxis("Vertical");
        
         if(inputValue != 0)
        {
            imoveY?.MoveY(inputValue);   
            
            Vector3 pos = moveObject.transform.position;
            pos.y = Mathf.Clamp(pos.y + inputValue * speed * Time.deltaTime,borderY.minY, borderY.maxY);
            moveObject.transform.position = pos;
        }
    }
}
