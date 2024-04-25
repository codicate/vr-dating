using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextAnim : MonoBehaviour
{
  public TextMeshProUGUI _textMeshPro;
  public float timeBtwnChars;

  public void EndCheck()
  {
    StartCoroutine(TextVisible());
  }


  private IEnumerator TextVisible()
  {
    _textMeshPro.ForceMeshUpdate();
    int totalVisibleCharacters = _textMeshPro.textInfo.characterCount;
    int counter = 0;

    while (counter < totalVisibleCharacters)
    {
      int visibleCount = counter % (totalVisibleCharacters + 1);
      Debug.Log(visibleCount + " / " + totalVisibleCharacters);
      _textMeshPro.maxVisibleCharacters = visibleCount;

      counter += 1;
      yield return new WaitForSeconds(timeBtwnChars);
    }
  }
}