using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class DisableGrabbingHandModel : MonoBehaviour
{
  public GameObject leftHandModel;
  public GameObject rightHandModel;

  void Start()
  {
    XRGrabInteractable getInteractable = GetComponent<XRGrabInteractable>();
    getInteractable.selectEntered.AddListener(DisableHandModel);
    getInteractable.selectExited.AddListener(EnableGrabbingHandModel);
  }

  public void DisableHandModel(SelectEnterEventArgs args)
  {
    if (args.interactorObject.transform.tag == "Left Hand")
    {
      leftHandModel.SetActive(false);
    }
    else if (args.interactorObject.transform.tag == "Right Hand")
    {
      rightHandModel.SetActive(false);
    }
  }

  public void EnableGrabbingHandModel(SelectExitEventArgs args)
  {
    if (args.interactorObject.transform.tag == "Left Hand")
    {
      leftHandModel.SetActive(true);
    }
    else if (args.interactorObject.transform.tag == "Right Hand")
    {
      rightHandModel.SetActive(true);
    }
  }
}
