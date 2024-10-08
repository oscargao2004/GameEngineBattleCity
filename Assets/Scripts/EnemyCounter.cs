using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyCounter : MonoBehaviour
{
    private EnemyCounter Instance { get; set; }
    private float _enemyCount;
    Enemy[] _enemies;

    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            if (Instance != this)
            {
                Destroy(this.gameObject);
            }
        }
    }

    void Update()
    {
        _enemies = FindObjectsOfType<Enemy>();
        if (_enemies.Length > 0)
        {
            _enemyCount = _enemies.Length - 1;
        }
        else
        {
            _enemyCount = 0;
        }

    }
}
