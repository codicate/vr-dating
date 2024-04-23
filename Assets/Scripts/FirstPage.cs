using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FirstPage : MonoBehaviour
{
  private readonly string[] girlTexts = {
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
"};

  private readonly string[] boyText = {
@"Name: Chris
A student who is very interested in psychology and is currently busy preparing his graduation thesis, which reflects his seriousness and concentration. His research theme explores the connection between human emotion and cognition, demonstrating his deep interest in human behavior and psychological processes. He enjoys sharing his knowledge and discoveries with others, while also displaying a degree of openness and willingness to socialize.
",
@"Character traits:
•	Focused and hard-working: Chris is very dedicated to his research projects and is able to concentrate on complex psychological concepts for long periods of time.
•	Curiosity: He shows a keen interest in all aspects of psychology and is willing to explore new areas of knowledge.
",
@"•	Sociability: Although he is busy with his own research, he is still willing to take time to exchange psychological knowledge with others and is willing to share and discuss.
•	Compassionate: Chris seems open to the needs of others and willing to help, whether by sharing knowledge or simply giving directions.
•	Self-driven: His interest in learning and research seems to come mainly from internal motivation and curiosity rather than external pressure.
",
@"Background:
Chris is studying psychology at a university, and his graduation thesis reflects his strong desire to gain a deeper understanding of human psychology. He may have participated in relevant research projects or experiments, which accumulated valuable experience for his academic career. Chris' passion for psychology likely began with his early observations and curiosity about human behavior, an interest that grew over time.
",
@"Since Chris has a deep interest in the connection between emotion and cognition, he may have attended multiple related lectures and seminars to constantly expand his knowledge boundaries. Additionally, his tendency to choose to attend lectures and share his knowledge with others demonstrates his desire not only to pursue personal development but also to facilitate the learning and growth of others.
",
@"Chris' family background may have provided an environment that supported and encouraged academic exploration, which allowed him the freedom to pursue his interests. Family members may also have backgrounds in science or education, and their values have been an important influence on Chris.
"};

  private int index = 0;
  private TMP_Text descriptionText;
  public string gender;
  private string[] textsToUse;

  void Start()
  {
    textsToUse = (gender == "female") ? girlTexts : boyText;
    Transform descriptionTransform = transform.Find("Description");
    descriptionText = descriptionTransform.GetComponentInChildren<TMP_Text>();
    descriptionText.text = textsToUse[index];
  }

  public void OnLeftClick()
  {
    index = (index - 1 + textsToUse.Length) % textsToUse.Length;
    descriptionText.text = textsToUse[index];
  }

  public void OnRightClick()
  {
    index = (index + 1) % textsToUse.Length;
    descriptionText.text = textsToUse[index];
  }
}
