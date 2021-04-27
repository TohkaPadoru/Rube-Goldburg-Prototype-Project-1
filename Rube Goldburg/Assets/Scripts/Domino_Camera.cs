using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Domino_Camera : MonoBehaviour
{
    public Camera normalCamera;
    public Camera DominoCamera;

    public void OnTriggerEnter(Collider hit)
 
    {
        if (hit.gameObject.name !="Coin?")
        {
            SwitchToDominoCamera();
        }
    }

    private void SwitchToDominoCamera()
    {
        DominoCamera.enabled = true;
        normalCamera.enabled = false;
    }

}