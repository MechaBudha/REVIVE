using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger1Controller : MonoBehaviour {

    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject thisBox;
    [SerializeField] private GameObject trigger;

    [SerializeField] private bool triggerOn;

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

        trigger.SetActive(true);

        StartCoroutine(DeleteThisBox());
    }

    IEnumerator DeleteThisBox()
    {
        yield return new WaitForSeconds(0.5f);

        thisBox.SetActive(false);
        
        thisBox.GetComponent<EnemyTrigger1Controller>().enabled = false;
        
    }
}
