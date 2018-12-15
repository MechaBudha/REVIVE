using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour {

    [SerializeField] TriggerController[] tcScript;
    [SerializeField] ButtonController[] btScript;

    [SerializeField] private Animator an1;
    [SerializeField] private Animator an2;
    [SerializeField] private Animator an3;
    [SerializeField] private Animator an4;
    [SerializeField] private Animator an5;

    private void Awake()
    {
        //tcScript = tcScript.GetComponent<TriggerController>();
    }

    void Start () {
        tcScript[0].TriggerOne.AddListener(AnimationOne);
        tcScript[1].TriggerTwo.AddListener(AnimationTwo);
        btScript[0].ButtonOne.AddListener(AnimationThree);
        btScript[1].ButtonTwo.AddListener(AnimationFour);
        tcScript[2].TriggerNine.AddListener(AnimationFive);
    }
	
	void AnimationOne()
    {
        an1.SetBool("open", true);
    }

    void AnimationTwo()
    {
        an2.SetBool("open", true);
    }

    void AnimationThree()
    {
        an3.SetBool("open", true);
    }

    void AnimationFour()
    {
        an4.SetBool("open", true);
    }

    void AnimationFive()
    {
        an5.SetBool("open", true);
    }
}
