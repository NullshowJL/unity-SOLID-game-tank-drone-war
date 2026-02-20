using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameEvents
{
    public static Action OnGameStarted;
    public static Action OnGameOver;
    public static Action OnTankFired;
    public static Action OnTankDamaged;
    public static Action OnDroneDestroy;
}
