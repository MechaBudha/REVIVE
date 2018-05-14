using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enable1 : MonoBehaviour {

    [SerializeField] private GameObject openDoor3Trigger;
    [SerializeField] private GameObject thisBox;
    [SerializeField] private bool triggerOn;

    private void Update()
    {
        if (triggerOn)
        {
            openDoor3Trigger.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerOn = true;
        
        
        StartCoroutine(DeleteThisBox());
    }

    IEnumerator DeleteThisBox()
    {
        yield return new WaitForSeconds(0.5f);

        thisBox.SetActive(false);
        
        thisBox.GetComponent<Enable1>().enabled = false;
    }
}
