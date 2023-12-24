using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HapticInteractable : MonoBehaviour
{
    [Range(0.0f, 1.0f)]
    public float intensity;
    public float duration;

    // Start is called before the first frame update
    void Start()
    {
        XRBaseInteractable interactable = GetComponent<XRBaseInteractable>();
        interactable.activated.AddListener(TriggerHaptic);
    }

    public void TriggerHaptic(BaseInteractionEventArgs eventArgs)
    {
        if (eventArgs.interactableObject is XRBaseControllerInteractor controllerInteractor)
        {
            TriggerHaptic(controllerInteractor.xrController);
        }
    }

    public void TriggerHaptic(XRBaseController controller)
    {
        if (intensity > 0.0f)
            controller.SendHapticImpulse(intensity, duration);
    }

    public void Vibrate()
    {
        print("Touched");
        XRBaseControllerInteractor controllerInteractor = GetComponent<XRBaseControllerInteractor>();
        if (controllerInteractor != null)
        {
            TriggerHaptic(controllerInteractor.xrController);
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Bat"))
    //        Vibrate();
    //}
}
