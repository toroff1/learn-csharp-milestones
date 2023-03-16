using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Player")
        {

            Destroy(this.transform.parent.gameObject);


            Debug.Log("Item collected!");
        }
    }


    private void OnTriggerEnter(Collider other)
    {
       if(other.name == "Player")
        {
            Debug.Log("Player detected!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.name == "Player")
        {
            Debug.Log("Player left :(");
        }
    }
}
