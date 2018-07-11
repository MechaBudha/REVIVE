using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightEnable : MonoBehaviour {

    [SerializeField] GameObject _light;

    private void OnTriggerEnter(Collider other)
    {
        _light.SetActive(true);

        StartCoroutine(DeleteThisBox());
    }

    IEnumerator DeleteThisBox()
    {
        yield return new WaitForSeconds(0.1f);
    }
}
