using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffLightsController : MonoBehaviour {

    public GameObject[] Lights = null;
    //public GameObject triggerN4;
    public bool onOff;

    void Update()
    {
        if (onOff)
        {

            /*for (int i = 0; i < Lights.Length; i++)
            {
                Light light = gameObject.GetComponent<Light>();
                light.intensity = 0f;
            }*/

            foreach (GameObject go in Lights)
            {
                Light light = go.GetComponent<Light>();
                light.intensity = 0f;
            }
            
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        onOff = true;
        //triggerN4.SetActive(true);
    }
}
