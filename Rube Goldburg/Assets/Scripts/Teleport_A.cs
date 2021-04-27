using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_A : MonoBehaviour
{
     void OnTriggerEnter(Collider hit)
    {

        if (hit.gameObject.name != "teleporter A")
        {
            GameObject.Find("Ball")
                .SendMessage("React");
        }
    }
}
