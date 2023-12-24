using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    [SerializeField]
    private InputActionProperty pinchAnimationAction;

    [SerializeField]
    private InputActionProperty gripAnimationAction;

    private Animator handAnim;

    // Start is called before the first frame update
    void Start()
    {
        handAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();
        handAnim.SetFloat("Trigger", triggerValue);

        float gripValue = gripAnimationAction.action.ReadValue<float>();
        handAnim.SetFloat("Grip", gripValue);
    }
}
