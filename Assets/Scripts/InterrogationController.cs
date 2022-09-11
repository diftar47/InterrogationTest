using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterrogationController : MonoBehaviour
{
    public string startAnswer = "��� ��� �����, ��������?";
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

        firstSuspectAnswers[0] = "��� ��� ����";
        firstSuspectAnswers[1] = "��� ��� ����";
        firstSuspectAnswers[2] = "��� ��� ����";
        firstQuestion = "��� ������?";

        firstQA.Question = firstQuestion;
        firstQA.AnswerVariants = firstSuspectAnswers;

        secondSuspectAnswers[0] = "� ����� �� ������� �����";
        secondSuspectAnswers[1] = "� �������� �� �������";
        secondSuspectAnswers[2] = "� ����� � ����� �����";
        secondQuestion = "��� ���������?";

        secondQA.Question = secondQuestion;
        secondQA.AnswerVariants = secondSuspectAnswers;

        thirdSuspectAnswers[0] = "��� �������� �� ������";
        thirdSuspectAnswers[1] = "�� ������� �� �������";
        thirdSuspectAnswers[2] = "�� ������� � ���� ��� ������ ����";
        thirdQuestion = "��� ����� ����?";

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