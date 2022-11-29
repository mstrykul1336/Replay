using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class playerinventory : MonoBehaviour
{
    public int NumberOfFood { get; private set; }

    public UnityEvent<playerinventory> OnFoodCollected;
    
    public void FoodCollected(){
        NumberOfFood++;
        OnFoodCollected.Invoke(this);
    }
}
