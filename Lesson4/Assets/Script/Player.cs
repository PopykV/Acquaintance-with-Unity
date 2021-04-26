using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _BulletPrefabe;
    [SerializeField] private GameObject _MinePrefabe;
    [SerializeField] private Transform _BulletSpawn;
    [SerializeField] private Transform _MineSpawn;
    private GameObject _Prefabe;
    private Transform _Spawn;
    private int _MineQuantity;
    private int _Health = 100;
    private int _Key = 0;

    public int Key
    {
        set => _Key = value;
        get => _Key;
    }
    public int Health
    {
        set => _Health = value;
    }
    public int MineQuantity
    {
        set => _MineQuantity += value;
    }



    private void Awake()
    {
        _Prefabe = _BulletPrefabe;
        _Spawn = _BulletSpawn;
    }
    void Update()
    {
        if (_Health <= 0)
        {
            Destroy(gameObject);
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            _Prefabe = _BulletPrefabe;
            _Spawn = _BulletSpawn;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            _Prefabe = _MinePrefabe;
            _Spawn = _MineSpawn;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }

    }

    void Fire()
    {
        if (_Spawn == _MineSpawn && _MineQuantity > 0)
        {
            GameObject.Instantiate(_Prefabe, _Spawn.transform.position, _Spawn.rotation);
            _MineQuantity--;
        }
        else if (_Spawn == _BulletSpawn)
        {
            GameObject.Instantiate(_Prefabe, _Spawn.transform.position, _Spawn.rotation);
        }    

    }
}
