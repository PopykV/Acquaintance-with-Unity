using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    [SerializeField] private float _SpeedRotation = 150;
    [SerializeField] private float _Speed = 3;
    private Vector3 _Direction;
    private float _MouseRotation;
    private float _Rotation;
    private float _Jump;
    private float _SpeedMouseRotation = 400;
    private Rigidbody _RigidBody;

    private void Awake()
    {
        _RigidBody = GetComponent<Rigidbody>();
        
    }
    private void Update()
    {
        _Direction.z = Input.GetAxis("Vertical");
        _Rotation = Input.GetAxis("Horizontal");
        _MouseRotation = Input.GetAxis("Mouse X");
        _Jump = Input.GetAxis("Jump");


    }
    private void FixedUpdate()
    {
        Movenment();
        Rotate();
        Jump();            
    }

    void Movenment ()
    {
        var speed = _Direction.normalized * Time.fixedDeltaTime * _Speed;
        transform.Translate(speed);
    }

    void Rotate ()
    {
        transform.Rotate(0, _Rotation * _SpeedRotation * Time.fixedDeltaTime, 0);
        transform.Rotate(0, _MouseRotation * _SpeedMouseRotation * Time.fixedDeltaTime, 0);
    }

    void Jump ()
    {
        if (_Jump == 1 && gameObject.transform.position.y <= 2)
            _RigidBody.AddForce(0, 0.5f, 0, ForceMode.Impulse);

    }
}

