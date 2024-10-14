using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;   // Action은 무조건 void만 반환해야 한다. 아니면 Func를 사용
    public event Action<Vector2> OnLookEvent;

    protected CharacterStatsHandler stats { get; private set; }

    protected virtual void Awake()
    {
        stats = GetComponent<CharacterStatsHandler>();
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }
    
    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
