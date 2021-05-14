using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator _Animator;

    void Start()
    {
        _Animator = gameObject.GetComponent<Animator>();
    }


    public void DoorOpen ()
    {
        _Animator.SetBool("OpenDoor", true);
    }    
}
