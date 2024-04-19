using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEditor.Compilation;

[System.Serializable]
class Response
{
  public string Female_Character;
  public Branch[] branches;
}

[System.Serializable]
class Branch
{
  public string option;
  public string ending;
  public Response response;
}

public class SecondPage : MonoBehaviour
{
  public GameObject buttonPrefab;
  public Transform parentTransform;
  private TMP_Text dialogueText;
  private GameObject closeButton;
  private Response dialogueData;

  private void loadJson()
  {
    string path = "Assets/Dialogues/female.json";
    string jsonString = File.ReadAllText(path);
    dialogueData = JsonUtility.FromJson<Response>(jsonString);
  }

  void Start()
  {
    loadJson();
    Transform dialogueTransform = transform.Find("Dialogue");
    dialogueText = dialogueTransform.GetComponentInChildren<TMP_Text>();
    UpdateDialogue(dialogueData);

    closeButton = transform.Find("CloseButton").gameObject;
    closeButton.SetActive(false);
  }

  private void UpdateDialogue(Response d)
  {
    dialogueText.text = d.Female_Character;

    //Delete all buttons that are already there, only delete if its button
    foreach (Transform child in parentTransform)
    {
      if (child.name == "DialogueOption(Clone)")
      {
        Destroy(child.gameObject);
      }
    }

    if (d.branches.Length == 0)
    {
      closeButton.SetActive(true);
      return;
    }

    for (int i = 0; i < d.branches.Length; i++)
    {
      GameObject newButton = Instantiate(buttonPrefab, parentTransform);
      Button buttonComponent = newButton.GetComponent<Button>();
      // move the button to the right position
      newButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 75 + i * 100);
      buttonComponent.GetComponentInChildren<TMP_Text>().text = d.branches[i].option;
      int j = i; // hack to capture the value of i
      buttonComponent.onClick.AddListener(() => DialogueChosen(d.branches[j].response));
    }
  }

  void DialogueChosen(Response d)
  {
    UpdateDialogue(d);
  }
}