using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normal_Camera : MonoBehaviour
{
    public Camera normalCamera;
    public Camera DominoCamera;

    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.name != "Teleporter B")
        {
            SwitchToNormalCamera();
        }

        void SwitchToNormalCamera()
        {
            DominoCamera.enabled = false;
            normalCamera.enabled = true;
        }

    }
}