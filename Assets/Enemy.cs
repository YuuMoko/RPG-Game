using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb { get; private set; }
    public Animator anim { get; private set; }
    
    public EnemyStateMachine StateMachine { get; private set; }

    private void Awake()
    {
        StateMachine = new EnemyStateMachine();
    }

    private void Update()
    {
        StateMachine.currentState.Update();
    }
}
