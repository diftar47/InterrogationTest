using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterrogationController : MonoBehaviour
{
    public string startAnswer = "Что вам нужно, детектив?";

    public string firstQuestion;
    public string[] firstSuspectAnswers = new string[3];

    public string secondQuestion;  
    public string[] secondSuspectAnswers = new string[3];

    public string thirdQuestion;
    public string[] thirdSuspectAnswers = new string[3];

    private void Awake()
    {
        firstSuspectAnswers[0] = "Это был Даня";
        firstSuspectAnswers[1] = "Это был Миша";
        firstSuspectAnswers[2] = "Это был Саша";
        firstQuestion = "Кто убийца?";

        secondSuspectAnswers[0] = "В шкафу на третьей полке";
        secondSuspectAnswers[1] = "В чемодане на вокзале";
        secondSuspectAnswers[2] = "В столе у моего босса";
        secondQuestion = "Где детонатор?";

        thirdSuspectAnswers[0] = "Под ковриком на пороге";
        thirdSuspectAnswers[1] = "На крыльце за цветком";
        thirdSuspectAnswers[2] = "Он закопан в саду под кустом розы";
        thirdQuestion = "Где лежит ключ?";

    }
}
