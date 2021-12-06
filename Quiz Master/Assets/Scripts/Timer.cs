using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;

    public bool loadNextQuestion;
    public float fillFraction;

    public bool isAnsweringQuestion;
    float timerValue;
    //private void Start()
    //{
    //    Debug.Log("from Timer timerValue = " + timerValue);
    //}
    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }


    // for canceling the timer early when the player answer a question
    public void CancelTimer()
    {
        timerValue = 0;
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        //Answering question state
        if (isAnsweringQuestion)
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToCompleteQuestion;
            }
            else
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
        }

        //Showing correct answer state
        else
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
            else
            {
                loadNextQuestion = true;
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
            }
        }
    }
}
