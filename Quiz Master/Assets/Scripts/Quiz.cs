using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class Quiz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionSO question;
    [SerializeField] GameObject[] answerButtons = new GameObject[4];
    void Start()
    {
        questionText.text = question.GetQuestion(); 
        for(int i = 0; i < 4; i ++)
        {
            TextMeshProUGUI answerText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            answerText.text = question.GetAnswer(i);
        }
       


    }
}
