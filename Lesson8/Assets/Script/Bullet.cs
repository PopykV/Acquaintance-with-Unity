using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int _Damage = 10;
    [SerializeField] private float _SpeedBullet = 5;

    private void Update()
    {
        transform.Translate(_SpeedBullet * Vector3.forward * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.other.tag == "Enemy")
        {
            var value = collision.other.gameObject.GetComponent<Enemy>();
            value.Health -= _Damage;
            Destroy(gameObject);
        }
        else if (collision.other.tag == "Player")
        {
            var value = collision.other.gameObject.GetComponent<Player>();
            value.Health -= _Damage;
            Destroy(gameObject);
        }
        else
            Destroy(gameObject);
    }

}

