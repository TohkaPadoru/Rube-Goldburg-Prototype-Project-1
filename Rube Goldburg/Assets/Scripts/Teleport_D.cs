using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_D : MonoBehaviour
{
    void OnTriggerEnter(Collider hit)
    {

        if (hit.gameObject.name != "teleporter D")
        {
            GameObject.Find("Ball")
                .SendMessage("fall");

        }
    }
}
