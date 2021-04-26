using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    private float _Time = 0;
    [SerializeField] private GameObject _DoorLeft;
    [SerializeField] private GameObject _DoorRight;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && _Time >= 2)
        {
            _Time = 0;
            _DoorLeft.SetActive(false);
            _DoorRight.SetActive(false);
        }

        else if (other.tag == "Player")
            _Time += Time.deltaTime;
           
    }
}
