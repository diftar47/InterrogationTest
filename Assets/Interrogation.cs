using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interrogation : MonoBehaviour
{
    [SerializeField] private Text suspectAnswer;

    [SerializeField] private Text firstQuestion;
    [SerializeField] private Text secondQuestion;
    [SerializeField] private Text thirdQuestion;

    [SerializeField] private GameObject firstQuestionButton;
    [SerializeField] private GameObject secondQuestionButton;
    [SerializeField] private GameObject thirdQuestionButton;

    private void Start()
    {
        suspectAnswer.text = "��� ��� �� ���� ����?";

        firstQuestion.text = "��� ������?";
        secondQuestion.text = "��� ���������?";
        thirdQuestion.text = "��� ����� ��� ����?";
    }

    public void firstAnswer()
    {
        suspectAnswer.text = "��� ��� ����!";
        firstQuestionButton.SetActive(false);
    }

    public void secondAnswer()
    {
        suspectAnswer.text = "� ����� �� ������� �����";
        secondQuestionButton.SetActive(false);
    }

    public void thirdAnswer()
    {
        suspectAnswer.text = "��� �������� �� ������";
        thirdQuestionButton.SetActive(false);
    }

}
