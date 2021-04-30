using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject _EnemyPrefab;
    [SerializeField] private GameObject _EnemySpawn;

    void Awake()
    {
        if (_EnemySpawn.transform.childCount > 0)
        {
            for (int i = 0; i < _EnemySpawn.transform.childCount; i++)
            {
                var value = _EnemySpawn.transform.GetChild(i);
                GameObject.Instantiate(_EnemyPrefab, value.transform.position, Quaternion.identity);
            }
        }
    }
}
