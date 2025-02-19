using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class ChangeOnPlace : MonoBehaviour
{
    XRSocketInteractor interactor;
    Material material;
    Color defaultColor;

    private void OnEnable()
    {
        interactor = GetComponent<XRSocketInteractor>();

        interactor.selectEntered.AddListener(OnActivate);
        interactor.selectExited.AddListener(OnDeactivate);
        defaultColor = material.color;
    }



    private void OnDisable()
    {
        interactor.selectEntered.RemoveListener(OnActivate);
        interactor.selectExited.RemoveListener(OnDeactivate);
    }

    private void OnActivate(SelectEnterEventArgs arg0)
    {
        defaultColor = arg0.interactableObject.transform.GetComponent<MeshRenderer>().material.color;
        arg0.interactableObject.transform.GetComponent<MeshRenderer>().material.color = Color.white;
    }

    private void OnDeactivate(SelectExitEventArgs arg0)
    {
        arg0.interactableObject.transform.GetComponent<MeshRenderer>().material.color = defaultColor;
    }
}
