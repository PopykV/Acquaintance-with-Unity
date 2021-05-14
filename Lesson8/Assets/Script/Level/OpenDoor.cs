using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private AudioSource _SourceDoor;

    private void Start()
    {
        _SourceDoor = gameObject.GetComponent<AudioSource>();
    }

    private void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        var value = other.GetComponent<Player>();
        if (Input.GetKey(KeyCode.E) && value.Key > 0)
        {
            _SourceDoor.Play();
            Destroy(gameObject, 1f);
            value.Key--;
        }
    }
}
