using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerZone : MonoBehaviour
{
  public string targetTag;
  public UnityEvent<GameObject> onEnterEvent;

  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag(targetTag))
    {
      onEnterEvent.Invoke(other.gameObject);
    }
  }
}
