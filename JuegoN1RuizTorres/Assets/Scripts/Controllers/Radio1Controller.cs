using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio1Controller : MonoBehaviour {

    [SerializeField] private AudioSource radio;
    [SerializeField] private GameObject thisBox;

    public bool triggerOn;

    private void Update()
    {
        if (triggerOn)
        {
            
            StartCoroutine(DeleteThisBox());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerOn = true;
        radio.Play();
    }

    IEnumerator DeleteThisBox()
    {
        yield return new WaitForSeconds(0.5f);
        thisBox.SetActive(false);
        thisBox.GetComponent<Radio1Controller>().enabled = false;
    }
}
