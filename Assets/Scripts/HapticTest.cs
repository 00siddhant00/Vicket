using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticTest : MonoBehaviour
{

    public HapticInteractable interactable;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
            interactable.Vibrate();
    }
}
