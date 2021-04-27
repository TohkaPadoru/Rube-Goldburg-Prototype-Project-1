using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter_C : MonoBehaviour
{
    void OnTriggerEnter(Collider hit)
    {

        if (hit.gameObject.name != "Teleporter C")
        {
            GameObject.Find("Ball")
                .SendMessage("Cat");

        }

    }

}
