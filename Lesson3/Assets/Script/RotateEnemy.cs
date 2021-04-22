using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEnemy : MonoBehaviour
{
    private Transform _Target;

    private void Awake()
    {
        _Target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Update()
    {
        transform.rotation = Quaternion.LookRotation(_Target.position - transform.position);
       
    }
}
