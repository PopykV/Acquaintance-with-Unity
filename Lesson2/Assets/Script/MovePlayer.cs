using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    [SerializeField] private float _speedRotation = 150;
    [SerializeField] private float _speed = 3;
    private Vector3 _direction;
    private float _Rotation;

    private void Update()
    {
        _direction.z = Input.GetAxis("Vertical");
        _Rotation = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        Movenment();
        Rotate();
    }

    void Movenment ()
    {
        var speed = _direction.normalized * Time.fixedDeltaTime * _speed;
        transform.Translate(speed);
    }

    void Rotate ()
    {
        transform.Rotate(0, _Rotation * _speedRotation * Time.fixedDeltaTime, 0);
    }
}

