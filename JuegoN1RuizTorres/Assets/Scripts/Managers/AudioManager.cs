using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    [SerializeField] TriggerController[] tcScript;
    [SerializeField] ButtonController[] btScript;
    [SerializeField] BearController brScript;

    [SerializeField] private AudioSource as1;
    [SerializeField] private AudioSource as2;
    [SerializeField] private AudioSource as3;
    [SerializeField] private AudioSource as4;
    [SerializeField] private AudioSource as5;
    [SerializeField] private AudioSource as6;
    [SerializeField] private AudioSource bt1;
    [SerializeField] private AudioSource bg1;
    [SerializeField] private AudioSource bg2;
    [SerializeField] private AudioSource bear;

    private void Awake()
    {
        //tcScript = tcScript.GetComponent<TriggerController>();
    }

    void Start () {
        tcScript[0].TriggerOne.AddListener(AudioOne);
        tcScript[1].TriggerTwo.AddListener(AudioTwo);
        tcScript[2].TriggerThree.AddListener(AudioThree);
        tcScript[3].TriggerSix.AddListener(AudioFour);
        tcScript[4].TriggerSeven.AddListener(AudioFive);
        btScript[0].ButtonOne.AddListener(ButtonAudio);
        btScript[1].ButtonTwo.AddListener(ButtonAudio);
        btScript[2].ButtonTwo.AddListener(Background);
        brScript.Bear.AddListener(Bear);
    }
	
    void AudioOne()
    {
        as1.Play();
        as2.Play();
    }

    void AudioTwo()
    {
        as3.Play();
    }

    void AudioThree()
    {
        as4.Play();
    }

    void AudioFour()
    {
        as5.Play();
    }

    void AudioFive()
    {
        as6.Play();
    }

    void ButtonAudio()
    {
        bt1.Play();
    }

    void Background()
    {
        bg1.Stop();
        bg2.Play();
    }

    void Bear()
    {
        bear.Play();
        bg2.Stop();
    }
}
