using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Listener
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public override void Execute()
    {
        Die();
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
