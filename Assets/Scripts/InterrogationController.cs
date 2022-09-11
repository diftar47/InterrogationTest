using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterrogationController : MonoBehaviour
{
    public string startAnswer = "Что вам нужно, детектив?";
    public List<QuestionAssigment> quest = new List<QuestionAssigment>();

    public string firstQuestion;
    public string[] firstSuspectAnswers = new string[3];
    QuestionAssigment firstQA;

    public string secondQuestion;
    public string[] secondSuspectAnswers = new string[3];
    QuestionAssigment secondQA;

    public string thirdQuestion;
    public string[] thirdSuspectAnswers = new string[3];
    QuestionAssigment thirdQA;

    private Interrogation interrogation;

    private void Awake()
    {
        interrogation = gameObject.GetComponent<Interrogation>();
        firstQA = new QuestionAssigment();
        secondQA = new QuestionAssigment();
        thirdQA = new QuestionAssigment();

        firstSuspectAnswers[0] = "Это был Даня";
        firstSuspectAnswers[1] = "Это был Миша";
        firstSuspectAnswers[2] = "Это был Саша";
        firstQuestion = "Кто убийца?";

        firstQA.Question = firstQuestion;
        firstQA.AnswerVariants = firstSuspectAnswers;

        secondSuspectAnswers[0] = "В шкафу на третьей полке";
        secondSuspectAnswers[1] = "В чемодане на вокзале";
        secondSuspectAnswers[2] = "В столе у моего босса";
        secondQuestion = "Где детонатор?";

        secondQA.Question = secondQuestion;
        secondQA.AnswerVariants = secondSuspectAnswers;

        thirdSuspectAnswers[0] = "Под ковриком на пороге";
        thirdSuspectAnswers[1] = "На крыльце за цветком";
        thirdSuspectAnswers[2] = "Он закопан в саду под кустом розы";
        thirdQuestion = "Где лежит ключ?";

        thirdQA.Question = thirdQuestion;
        thirdQA.AnswerVariants = thirdSuspectAnswers;

        quest.Add(firstQA);
        quest.Add(secondQA);
        quest.Add(thirdQA);
    }

    private void Start()
    {
        Debug.Log("start");
        interrogation.Show(startAnswer, quest);
    }
}

public class QuestionAssigment
{
    public string Question;
    public string[] AnswerVariants;
}