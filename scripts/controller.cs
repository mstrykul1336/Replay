using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class controller : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI eyetext;
    public TextMeshProUGUI eartext;
    public TextMeshProUGUI teethtext;
    void Start(){
        eyetext = GetComponent<TextMeshProUGUI>();
        eartext = GetComponent<TextMeshProUGUI>();
        teethtext = GetComponent<TextMeshProUGUI>();
    }
    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z >= 5){
            eyetext.text = "What big eyes you have!";
            if (player.transform.position.z >= 15){
                eartext.text = "What huge ears you have!";
            }
                if(player.transform.position.z >= 30){
                    teethtext.text = "What scary teeth you have!";
                }
        }

    }
}
