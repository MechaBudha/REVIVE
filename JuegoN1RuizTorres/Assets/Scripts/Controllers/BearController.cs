using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BearController : MonoBehaviour {

    [SerializeField] UnityEvent bear;
    [SerializeField] GameObject br;
 
    public void PickUp()
    {
        bear.Invoke();
        StartCoroutine(DisableBear());
    }

    IEnumerator DisableBear()
    {
        yield return new WaitForSeconds(0.1f);

        br.SetActive(false);
    }

    public UnityEvent Bear { get { return bear; } }
}