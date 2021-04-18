using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefabe;
    [SerializeField] private GameObject _minePrefabe;
    [SerializeField] private GameObject _bulletSpawn;
    [SerializeField] private GameObject _mineSpawn;
    private GameObject _prefabe;
    private GameObject _spawn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Alpha1))
        {
            _prefabe = _bulletPrefabe;
            _spawn = _bulletSpawn;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            _prefabe = _minePrefabe;
            _spawn = _mineSpawn;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }    
    }

    void Fire()
    {
        GameObject.Instantiate(_prefabe, _spawn.transform.position, Quaternion.identity);
    }
}
