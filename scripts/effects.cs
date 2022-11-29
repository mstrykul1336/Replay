using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class effects : MonoBehaviour
{
    GameObject effect;
    int number;
    void Start(){

        effect.SetActive(false);
    }
    // Update is called once per frame
    public void UpdateEffect(playerinventory playerInventory){
        number = playerInventory.NumberOfFood;
        if (number == 1){
            effect.SetActive(true);
        }
    }
}
