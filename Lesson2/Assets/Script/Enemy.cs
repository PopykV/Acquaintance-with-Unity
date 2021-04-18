using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private GameObject _enemySpawn;

    private void Awake()
    {   if (_enemySpawn.transform.childCount > 0)
        {
            for (int i = 0; i < _enemySpawn.transform.childCount; i++)
            {
                var value = _enemySpawn.transform.GetChild(i);
                GameObject.Instantiate(_enemyPrefab, value.transform.position, Quaternion.identity);
            }
        }

    }
}
