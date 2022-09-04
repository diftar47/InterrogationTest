using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterrogationController : MonoBehaviour
{
    public string startAnswer = "��� ��� �����, ��������?";

    public string firstQuestion;
    public string[] firstSuspectAnswers = new string[3];

    public string secondQuestion;  
    public string[] secondSuspectAnswers = new string[3];

    public string thirdQuestion;
    public string[] thirdSuspectAnswers = new string[3];

    private void Awake()
    {
        firstSuspectAnswers[0] = "��� ��� ����";
        firstSuspectAnswers[1] = "��� ��� ����";
        firstSuspectAnswers[2] = "��� ��� ����";
        firstQuestion = "��� ������?";

        secondSuspectAnswers[0] = "� ����� �� ������� �����";
        secondSuspectAnswers[1] = "� �������� �� �������";
        secondSuspectAnswers[2] = "� ����� � ����� �����";
        secondQuestion = "��� ���������?";

        thirdSuspectAnswers[0] = "��� �������� �� ������";
        thirdSuspectAnswers[1] = "�� ������� �� �������";
        thirdSuspectAnswers[2] = "�� ������� � ���� ��� ������ ����";
        thirdQuestion = "��� ����� ����?";

    }
}
