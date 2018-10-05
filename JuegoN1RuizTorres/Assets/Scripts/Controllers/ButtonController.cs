using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonController : MonoBehaviour {

    [SerializeField] UnityEvent buttonOne;
    [SerializeField] UnityEvent buttonTwo;

    public void FirstButton()
    {
        buttonOne.Invoke();
    }

    public void SecondButton()
    {
        buttonTwo.Invoke();
    }

    public UnityEvent ButtonOne { get { return buttonOne; } }
    public UnityEvent ButtonTwo { get { return buttonTwo; } }
}
