using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour {

    Light startLight;
    [SerializeField] private float minTime;
    [SerializeField] private float maxTime; 

	void Start () {
        startLight = GetComponent<Light>();
        StartCoroutine(Flashing());
	}
	
	IEnumerator Flashing()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(minTime, maxTime));
            startLight.enabled = !startLight.enabled;
        }

    }
}
