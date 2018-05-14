using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsController : MonoBehaviour {

    [SerializeField] private GameObject[] Lights = null;
    //[SerializeField] private GameObject triggerN2;
    [SerializeField] private bool lightsAreRed;
    [SerializeField] private GameObject[] Box = null;
    /*[SerializeField] private Material mat;
    [SerializeField] private Renderer renderer;*/

    void Update()
    {
        if (lightsAreRed)
        {
            foreach(GameObject go in Lights)
            {
                Light light = go.GetComponent<Light>();
                light.color = Color.red;
            }

            foreach (GameObject go in Box)
            {
                Renderer renderer = go.GetComponent<Renderer>();
                Material mat = renderer.material;

                float emission = Mathf.PingPong(Time.time, 1f);
                Color baseColor = Color.red; //Replace this with whatever you want for your base color at emission level '1'

                Color finalColor = baseColor * Mathf.LinearToGammaSpace(emission);

                mat.SetColor("_EmissionColor", finalColor);
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        lightsAreRed = true;
        //triggerN2.SetActive(true);
    }
}
