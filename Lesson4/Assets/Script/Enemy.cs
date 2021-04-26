using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject _BulletPrefabe;
    [SerializeField] private Transform _BulletSpawn;
    private float _TimerAttack = 4;
    private float _Timer = 0;
    private Transform _Target;
    private int _Health = 100;

    public int Health
    {
        set => _Health -= value;
    }
    private void Awake()
    {   
        _Target = GameObject.FindGameObjectWithTag("Player").transform;

    }
    private void Update()
    {


        if (_Health <= 0)
            Destroy(gameObject);

    }

    private void OnTriggerStay(Collider other)
    {   
        if (other.tag == "Player")
        {
            transform.rotation = Quaternion.LookRotation(_Target.position - transform.position);
            Attack();
        }    

    }
    void Attack ()
    {
        if (_Timer >= _TimerAttack)
        {
            FireEnemy();
            _Timer = 0;
        }
        else
            _Timer += Time.deltaTime;
    }

    private void FireEnemy()
    {
        //Bullet.Target = _Target.position;
        GameObject.Instantiate(_BulletPrefabe, _BulletSpawn.transform.position, _BulletSpawn.rotation);
    }
}
