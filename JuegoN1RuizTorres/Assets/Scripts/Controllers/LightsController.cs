using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsController : MonoBehaviour {

    public GameObject[] Lights =  null;
    public GameObject triggerN2;
    public bool lightsAreRed;
    
    void Update()
    {
        if (lightsAreRed)
        {
            foreach(GameObject go in Lights)
            {
                Light light = go.GetComponent<Light>();
                light.color = Color.red;
            }
            //
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        lightsAreRed = true;
        triggerN2.SetActive(true);
    }
}
