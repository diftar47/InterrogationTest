using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interrogation : MonoBehaviour
{
    [SerializeField] private GameObject firstQuestionButton;
    [SerializeField] private GameObject secondQuestionButton;
    [SerializeField] private GameObject thirdQuestionButton;

    [SerializeField] private Text firstQuestionText;
    [SerializeField] private Text secondQuestionText;
    [SerializeField] private Text thirdQuestionText;

    [SerializeField] private Text suspectAnswerText;

    InterrogationController interrController;

    private void Start()
    {
        interrController = gameObject.AddComponent<InterrogationController>();

        suspectAnswerText.text = interrController.startAnswer;

        firstQuestionText.text = interrController.firstQuestion;
        secondQuestionText.text = interrController.secondQuestion;
        thirdQuestionText.text = interrController.thirdQuestion;

    }

    public void firstAnswer()
    {   
        suspectAnswerText.text = interrController.firstSuspectAnswers[Random.Range(0,3)];
        firstQuestionButton.SetActive(false);
    }

    public void secondAnswer()
    {  
        suspectAnswerText.text = interrController.secondSuspectAnswers[Random.Range(0, 3)];
        secondQuestionButton.SetActive(false);
    }

    public void thirdAnswer()
    {       
        suspectAnswerText.text = interrController.thirdSuspectAnswers[Random.Range(0, 3)];
        thirdQuestionButton.SetActive(false);
    }

}
