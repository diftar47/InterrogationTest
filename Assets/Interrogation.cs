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
        suspectAnswer.text = "Что вам от меня надо?";

        firstQuestion.text = "Кто убийца?";
        secondQuestion.text = "Где детонатор?";
        thirdQuestion.text = "Где лежит тот ключ?";
    }

    public void firstAnswer()
    {
        suspectAnswer.text = "Это был Даня!";
        firstQuestionButton.SetActive(false);
    }

    public void secondAnswer()
    {
        suspectAnswer.text = "В шкафу на третьей полке";
        secondQuestionButton.SetActive(false);
    }

    public void thirdAnswer()
    {
        suspectAnswer.text = "Под ковриком на пороге";
        thirdQuestionButton.SetActive(false);
    }

}
