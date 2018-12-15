using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour {

    [SerializeField] TriggerController[] tcScript;
    [SerializeField] ButtonController btScript;
    [SerializeField] BearController bearScript;

    void Start() {
        tcScript[0].TriggerZero.AddListener(EventZero);
        tcScript[1].TriggerOne.AddListener(EventOne);
        tcScript[2].TriggerTwo.AddListener(EventTwo);
        tcScript[3].TriggerThree.AddListener(EventThree);
        tcScript[4].TriggerFour.AddListener(EventFour);
        tcScript[5].TriggerFive.AddListener(EventFive);
        tcScript[6].TriggerSix.AddListener(EventSix);
        tcScript[7].TriggerSeven.AddListener(EventSeven);
        tcScript[8].TriggerEight.AddListener(EventEight);
        tcScript[9].TriggerNine.AddListener(EventNine);

        btScript.ButtonTwo.AddListener(EventFour);
        bearScript.Bear.AddListener(EventSix);
    }

    void EventZero()
    {
        ScoreManager.Instance.Score += 100;
    }

    void EventOne()
    {
        ScoreManager.Instance.Score += 50;
    }

    void EventTwo()
    {
        ScoreManager.Instance.Score += 100;
    }

    void EventThree()
    {
        ScoreManager.Instance.Score += 100;
    }

    void EventFour()
    {
        ScoreManager.Instance.Score += 50;
    }

    void EventFive()
    {
        ScoreManager.Instance.Score += 100;
    }

    void EventSix()
    {
        ScoreManager.Instance.Score += 50;
    }

    void EventSeven()
    {
        //ScoreManager.Instance.Score += 100;
    }

    void EventEight()
    {
        ScoreManager.Instance.Score += 100;
    }

    void EventNine()
    {
        ScoreManager.Instance.Score += 100;
    }
}
