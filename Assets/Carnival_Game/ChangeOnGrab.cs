using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class ChangeOnGrab : MonoBehaviour
{
    public GameObject SphereHand;
    public XRRayInteractor rayIntercator;
    private void OnEnable()
    {
        rayIntercator.selectEntered.AddListener(PickUpObject);
        rayIntercator.selectExited.AddListener(DropObject);
    }

    private void OnDisable()
    {
        rayIntercator.selectEntered.RemoveListener(PickUpObject);
        rayIntercator.selectExited.RemoveListener(DropObject);
    }
    public void PickUpObject(SelectEnterEventArgs args)
    {
        //args.interactorObject.transform.GetComponent<MeshRenderer>().material.color = Color.white;
        SphereHand.SetActive(false);
    }

    public void DropObject(SelectExitEventArgs args)
    {
        //args.interactorObject.transform.GetComponent<MeshRenderer>().material.color = Color.red;
        SphereHand.SetActive(true);
    }
}
