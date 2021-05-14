using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    private float _Time = 0;
    private Animator _Animator;
    public GameObject _Door;
    private Door _OpenDoor;

    private void Awake()
    {
        _OpenDoor = _Door.GetComponent<Door>();
        _Animator = GetComponent<Animator>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && _Time >= 2)
        {
            _Animator.SetBool("New Bool", true);
            _OpenDoor.DoorOpen();
            _Time = 0;
        }

        else if (other.tag == "Player")
            _Time += Time.deltaTime;
           
    }
}
