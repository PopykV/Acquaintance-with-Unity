using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject _BulletPrefabe;
    [SerializeField] private Transform _BulletSpawn;
    [SerializeField] private NavMeshAgent navMeshAgent;
    private float _TimerAttack = 2;
    private float _Timer = 1;
    public Transform _Target;
    private int _Health = 100;
    public bool _Trigger;

    public int Health
    {
        set => _Health = value;
        get => _Health;
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
            navMeshAgent.SetDestination(_Target.position + Vector3.one);

            transform.rotation = Quaternion.LookRotation(_Target.position - transform.position);
            Attack();
        }

    }
    void Attack()
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
        RaycastHit hit;
        var hits = Physics.Raycast(_BulletSpawn.position, _BulletSpawn.forward, out hit, 8);

        if (hits && hit.collider.tag == "Player")
            GameObject.Instantiate(_BulletPrefabe, _BulletSpawn.transform.position, _BulletSpawn.rotation);
    }
}
