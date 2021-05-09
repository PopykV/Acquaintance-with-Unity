using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    private float _Time = 0;

    [SerializeField] private GameObject _DoorLeft;
    [SerializeField] private GameObject _DoorRight;
    private Animator _Animator;

    private void Awake()
    {
        _Animator = GetComponent<Animator>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && _Time >= 2)
        {
            _Animator.SetBool("New Bool", true);
            _Time = 0;
        }

        else if (other.tag == "Player")
            _Time += Time.deltaTime;
           
    }
}
