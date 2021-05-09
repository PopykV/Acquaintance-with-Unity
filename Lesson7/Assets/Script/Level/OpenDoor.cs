using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        var value = other.GetComponent<Player>();
        if (Input.GetKey(KeyCode.E) && value.Key > 0)
        {
            gameObject.SetActive(false);
            value.Key--;
        }
    }
}
