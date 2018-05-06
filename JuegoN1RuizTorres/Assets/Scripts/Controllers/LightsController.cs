using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsController : MonoBehaviour {

    public GameObject[] Lights = null;
    //public GameObject triggerN2;
    public bool lightsAreRed;
    public GameObject[] Box = null;
    /*public Material mat;
    public Renderer renderer;*/
    void Update()
    {
        if (lightsAreRed)
        {
            foreach(GameObject go in Lights)
            {
                Light light = go.GetComponent<Light>();
                light.color = Color.red;



                /*
                renderer = GetComponent<Renderer>();
                mat = renderer.material;

                
                float emission = Mathf.PingPong(Time.time, 0f);
                Color baseColor = Color.white; //Replace this with whatever you want for your base color at emission level '1'

                Color finalColor = baseColor * Mathf.LinearToGammaSpace(emission);

                mat.SetColor("_EmissionColor", finalColor);

                //emissionSourceMaterial.EnableKeyword("_EMISSION");
                */
            }

            foreach (GameObject go in Box)
            {
                Renderer renderer = go.GetComponent<Renderer>();
                Material mat = renderer.material;

                float emission = Mathf.PingPong(Time.time, 0f);
                Color baseColor = Color.white; //Replace this with whatever you want for your base color at emission level '1'

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
