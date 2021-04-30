using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSubjects : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            var component = other.gameObject.GetComponent<Player>();
            component.MineQuantity += 3;

            Destroy(gameObject);
        }    
    }
}
