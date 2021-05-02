using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            var value = other.GetComponent<Player>();
            value.Key++;
            Destroy(gameObject);
        }   
    }
}
