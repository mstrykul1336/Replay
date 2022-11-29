using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class score : MonoBehaviour
{
    public Transform player;
    private TextMeshProUGUI foodtext;

   void Start(){
    foodtext = GetComponent<TextMeshProUGUI>();
   }

    public void UpdateFoodText(playerinventory playerInventory){
        foodtext.text = playerInventory.NumberOfFood.ToString();
    }

}
