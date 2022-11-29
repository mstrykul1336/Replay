using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reward : MonoBehaviour
{
    public Transform player;
    public ParticleSystem CFX_MagicPoof;
    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z > 20){
            CFX_MagicPoof.Play();
        }
    }
}
