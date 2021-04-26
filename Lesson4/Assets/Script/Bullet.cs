using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int _Damage = 10;
    [SerializeField] private float _SpeedBullet = 5;
    private static Vector3 _TargetPosition;
    public static Vector3 Target
    {
        set
        {
            _TargetPosition = value;
        }
    }

    private void Update()
    {
        // transform.position = Vector3.MoveTowards(transform.position, _TargetPosition, _SpeedBullet * Time.deltaTime);

        transform.Translate(_SpeedBullet * Vector3.forward * Time.deltaTime);
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Enemy")
        {
            var value = other.gameObject.GetComponent<Enemy>();
            value.Health = _Damage;
            Destroy(gameObject);
        }    
        else if (other.tag == "Player")
        {
            var value = other.gameObject.GetComponent<Player>();
            value.Health = _Damage;
            Destroy(gameObject);
        }
        else
            Destroy(gameObject, 3f);
    }
}
