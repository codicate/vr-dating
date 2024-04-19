using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
  private GameObject FirstPage;
  private GameObject SecondPage;

  void Start()
  {
    FirstPage = transform.GetChild(1).gameObject;
    SecondPage = transform.GetChild(2).gameObject;
    FirstPage.SetActive(true);
    SecondPage.SetActive(false);
  }

  public void StartConversation()
  {
    FirstPage.SetActive(false);
    SecondPage.SetActive(true);
  }
}
