using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsController : MonoBehaviour {

    public GameObject[] Lights =  null;
    public bool lightsAreRed;
    


    void Update()
    {

        if (lightsAreRed == true)
        {
            
            foreach(GameObject go in Lights)
            {
                Light light = go.GetComponent<Light>();
                light.color = Color.red;
            }

            
            /*
            for (int i = 0; i < Lights.Length; i++)
            {
                //_lights.color = Color.red;
                Light light = GetComponent<Light>();
                light.color = Color.red;

            }*/

        }
    }


    public void OnTriggerEnter(Collider other)
    {
        lightsAreRed = true;
    }




    /*public void ChangeColor()
    {
        GameObject.Find("Lights").GetComponent<Light>().color = Color.red;
    }*/
}
