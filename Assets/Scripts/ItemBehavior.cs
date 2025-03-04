using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{

    public GameBehavior gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Player")
        {

            Destroy(this.transform.parent.gameObject);


            Debug.Log("Item collected!");

            gameManager.Items += 1;
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
