using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckFinish : MonoBehaviour
{
    public FinishEffect finishEffect;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Final Platform")
        {
            finishEffect.ActivateEffect();
        }
    }

}
