using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int _Damage = 10;
    [SerializeField] private float _SpeedBullet = 5;
    private Transform _Target;
    private Vector3 _TargetPosition;
    public  Transform Target 
    {
        set
        {
            _Target = value;
            _TargetPosition = _Target.position;
        }
    }

    void Start()
    {
       Destroy(gameObject, 3f);
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _TargetPosition, _SpeedBullet * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
