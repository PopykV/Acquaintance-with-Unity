using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _BulletPrefabe;
    [SerializeField] private GameObject _MinePrefabe;
    [SerializeField] private Transform _BulletSpawn;
    [SerializeField] private Transform _MineSpawn;
    [SerializeField] private Image _HealthBar;
    [SerializeField] private int _Health;

    private GameObject _Prefabe;
    private Transform _Spawn;
    private int _MineQuantity;
    private int _Key = 0;
    private float _TimerDeath = 0;
    private Animator _Animator;
    private float _MaxHelathBar;
    private float _CurHealth;

    public int Key
    {
        set => _Key = value;
        get => _Key;
    }
    public int Health
    {
        set => _Health = value;
        get => _Health;
    }
    public int MineQuantity
    {
        set => _MineQuantity = value;
        get => _MineQuantity;
    }



    private void Awake()
    {
        _Animator = GetComponent<Animator>();

        _Prefabe = _BulletPrefabe;
        _Spawn = _BulletSpawn;

        _MaxHelathBar = _Health;

        _HealthBar.fillAmount = 1f;

    }
    void Update()
    {
        if (_Health <= 0)
        {
            _Animator.SetTrigger("Death");

            if (_TimerDeath >= 3)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            else
                _TimerDeath += Time.deltaTime;
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
            _Animator.SetTrigger("Fire");
        }

        _CurHealth = _Health;
        _HealthBar.fillAmount = _CurHealth / _MaxHelathBar;
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
