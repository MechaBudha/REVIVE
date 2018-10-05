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
        Debug.Log("Event 0 TM");
        ScoreManager.Instance.Score += 100;
    }

    void EventOne()
    {
        Debug.Log("Event 1 TM");
        ScoreManager.Instance.Score += 50;
    }

    void EventTwo()
    {
        Debug.Log("Event 2 TM");
        ScoreManager.Instance.Score += 100;
    }

    void EventThree()
    {
        Debug.Log("Event 3 TM");
        ScoreManager.Instance.Score += 100;
    }

    void EventFour()
    {
        Debug.Log("Event 4 TM");
        ScoreManager.Instance.Score += 50;
    }

    void EventFive()
    {
        Debug.Log("Event 5 TM");
        ScoreManager.Instance.Score += 100;
    }

    void EventSix()
    {
        Debug.Log("Event 6 TM");
        ScoreManager.Instance.Score += 50;
    }

    void EventSeven()
    {
        Debug.Log("Event 7 TM ");
        //ScoreManager.Instance.Score += 100;
    }

    void EventEight()
    {
        Debug.Log("Event 8 TM");
        ScoreManager.Instance.Score += 100;
    }

    void EventNine()
    {
        Debug.Log("Event 9 TM");
        ScoreManager.Instance.Score += 100;
    }
}
