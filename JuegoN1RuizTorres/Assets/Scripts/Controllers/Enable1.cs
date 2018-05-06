using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enable1 : MonoBehaviour {

    public GameObject openDoor3Trigger;
    public GameObject thisBox;
    public bool triggerOn;

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
