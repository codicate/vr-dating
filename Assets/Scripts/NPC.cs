using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class NPC : MonoBehaviour
{
  private GameObject characterPanel;
  void Start()
  {
    GetComponent<TriggerZone>().onEnterEvent.AddListener(AcceptGift);
    characterPanel = transform.GetChild(0).gameObject;
    characterPanel.SetActive(false);
  }

  public void OnHoverEnter(HoverEnterEventArgs args)
  {
    characterPanel.SetActive(true);
  }

  public void OnClosePanel()
  {
    characterPanel.SetActive(false);
  }

  public void AcceptGift(GameObject gift)
  {
    gift.SetActive(false);
  }
}
