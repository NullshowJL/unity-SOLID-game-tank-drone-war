using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDroneMove : DroneMoveBase, IMoveY
{
    public void MoveY(float inputValue)
    {
        moveObject.transform.Translate(Vector2.up * inputValue * speed * Time.deltaTime);
    }
}
