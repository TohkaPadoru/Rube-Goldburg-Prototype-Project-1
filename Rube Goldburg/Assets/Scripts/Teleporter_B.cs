using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter_B : MonoBehaviour
{
    void OnTriggerEnter(Collider hit)
    {

        if (hit.gameObject.name != "Teleporter B")
        {
            GameObject.Find("Ball")
                .SendMessage("Pain");

        }

    }

    }
