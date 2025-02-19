using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ChangeOnActivate : MonoBehaviour
{
    XRGrabInteractable interactable;
    Material material;
    Color defaultColor;

    private void OnEnable()
    {
        interactable = GetComponent<XRGrabInteractable>();
        material = GetComponent<MeshRenderer>().material;
        interactable.activated.AddListener(OnActivate);
        interactable.deactivated.AddListener(OnDeactivate);
        defaultColor = material.color;
    }



    private void OnDisable()
    {
        interactable.activated.RemoveListener(OnActivate);
        interactable.deactivated.RemoveListener(OnDeactivate);
    }    
    
    private void OnActivate(ActivateEventArgs arg0)
    {
        material.color = Color.white;
    }    
    
    private void OnDeactivate(DeactivateEventArgs arg0)
    {
        material.color = defaultColor;
    }
}
