using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    [SerializeField] int score;
    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject triggerObject;
    [SerializeField] private GameObject thisObject;
    [SerializeField] private GameObject trigger;
    [SerializeField] private GameObject backgroundMusic;
    [SerializeField] private AudioSource teddy;
    [SerializeField] private bool pickUp;

    void Update()
    {
        if (pickUp == true)
        {
            _animator.SetBool("open", true);
            StartCoroutine(DeleteThisBox());
        }
    }

    public void OpenWinDoor()
    {
        pickUp = true;
        triggerObject.GetComponent<TurnOffLightsController>().enabled = true;
        trigger.SetActive(true);
        backgroundMusic.SetActive(false);
        teddy.Play();

        ScoreManager.Instance.Score += score;
    }

    IEnumerator DeleteThisBox()
    {
        yield return new WaitForSeconds(0.1f);

        thisObject.SetActive(false);

        thisObject.GetComponent<Key>().enabled = false;

    }
}
