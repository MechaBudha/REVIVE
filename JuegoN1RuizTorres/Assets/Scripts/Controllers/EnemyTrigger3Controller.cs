using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger3Controller : MonoBehaviour {

    public GameObject enemy;
    public GameObject thisBox;
    

    public bool triggerOn;

    private void Update()
    {
        if (triggerOn)
        {
            enemy.SetActive(true);
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

        thisBox.GetComponent<EnemyTrigger3Controller>().enabled = false;

    }
}
