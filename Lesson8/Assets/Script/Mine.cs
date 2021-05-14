using UnityEngine;

public class Mine : MonoBehaviour
{
    [SerializeField] private int _Damage = 110;
    private AudioSource _SourceBang;


    private void Start()
    {
        _SourceBang = gameObject.GetComponentInChildren<AudioSource>();
    }
    private void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            var obj = other.GetComponent<Enemy>();
            _SourceBang.Play();
            obj.Health -= _Damage;
        }
    }

}
