using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changingtext : MonoBehaviour
{
    public Transform player;
    GameObject MDL_Characters_Lady;
    void FixedUpdate()
    {
        if (MDL_Characters_Lady.transform.position.z > 1)
        {
            Debug.Log("hi");
        }
    }
}
