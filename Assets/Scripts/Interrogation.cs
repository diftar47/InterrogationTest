using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interrogation : MonoBehaviour
{
    [SerializeField] private Button buttonPrefab;
    [SerializeField] private Text suspectAnswerText;
    [SerializeField] private RectTransform content;

    private bool isStartAnswer = true;

    public void Show(string suspectAnswer, List<QuestionAssigment> questionsList)
    {
        //Замена текста приветствия
        if(isStartAnswer == true)
        {
            suspectAnswerText.text = suspectAnswer;
            isStartAnswer = false;
        }

        //Изменение(добавление или удаление элементов) списка с вариантами вопросов
        foreach (var list in questionsList)
        {
            var instance = Instantiate(buttonPrefab);
            instance.transform.SetParent(content.transform, false);
            instance.GetComponentInChildren<Text>().text = list.Question;
            instance.onClick.AddListener(
                () =>
                {
                    suspectAnswerText.text = list.AnswerVariants[Random.Range(0, questionsList.Count)];

                }
            );
        }
    }


}
