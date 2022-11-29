using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collection : MonoBehaviour
{
    private void OnTriggerEnter (Collider other){

        playerinventory playerInventory = other.GetComponent<playerinventory>();

        if (playerInventory != null)
        {
            playerInventory.FoodCollected();
            gameObject.SetActive(false);
        }
    }
}
