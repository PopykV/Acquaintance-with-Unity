using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    [SerializeField] private float _SpeedRotation = 150;
    [SerializeField] private float _Speed = 3;
    private Vector3 _Direction;
    private float _Rotation;

    private void Update()
    {
        _Direction.z = Input.GetAxis("Vertical");
        _Rotation = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        Movenment();
        Rotate();
    }

    void Movenment ()
    {
        var speed = _Direction.normalized * Time.fixedDeltaTime * _Speed;
        transform.Translate(speed);
    }

    void Rotate ()
    {
        transform.Rotate(0, _Rotation * _SpeedRotation * Time.fixedDeltaTime, 0);
    }
}

