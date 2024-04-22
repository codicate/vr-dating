using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FirstPage : MonoBehaviour
{
  private string[] texts = {
@"Name: Alison
A girl with a deep interest in medieval art and a wealth of knowledge in this field. She not only has a keen interest in medieval painting, sculpture and architecture, but also actively participates in related exhibitions and research. This shows that she is a curious person who is willing to explore and enjoys learning. Her scenes in the library show her serious, focused side and her openness to sharing her knowledge and interests with others.
",
@"Character traits:
•	Curious: Have a strong interest in medieval art and always seek opportunities to learn and explore new knowledge.
•	Focused and serious: A focused attitude in the library shows how serious and committed she is to her area of interest.
•	Sharing: Willing to share her knowledge and interests with others, showing her sociability and openness.
",
@"•	Exploratory spirit: Have a strong desire to explore unknown areas and be willing to accept new challenges.
•	Open-mindedness: Be open to different opinions and perspectives and be receptive to new information and knowledge.
",
@"Background:
Alison has an academic background in art history or a similar field and has a high level of education. She may study art history in college or graduate school, with a special focus on medieval art. Alison may have been involved in several research projects related to medieval art and even published relevant papers in academic journals. Her deep understanding of history and love for art drove her to become an art history researcher or work in museums and art galleries.
",
@"Alison's family background may also have played a role in her interests. Her family may also have a deep interest in art or history, and this family atmosphere prompted her to develop a strong interest in art from an early age. In addition, she may have traveled many times to major European monuments and museums, experiences that deepened her love and understanding of medieval art.
"
  };

  private int index = 0;
  private TMP_Text descriptionText;

  void Start()
  {
    Transform descriptionTransform = transform.Find("Description");
    descriptionText = descriptionTransform.GetComponentInChildren<TMP_Text>();
    descriptionText.text = texts[index];
  }

  public void OnLeftClick()
  {
    index = (index - 1 + texts.Length) % texts.Length;
    descriptionText.text = texts[index];
  }

  public void OnRightClick()
  {
    index = (index + 1) % texts.Length;
    descriptionText.text = texts[index];
  }
}
