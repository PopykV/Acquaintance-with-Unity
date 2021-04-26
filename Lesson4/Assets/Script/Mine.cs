using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    [SerializeField] private int _Damage = 100;
    Enemy _Enemy;

    private void Start()
    {
        _Enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy>();
    }
        void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            _Enemy.Health = _Damage;
            Destroy(gameObject);
        }
    }

}
