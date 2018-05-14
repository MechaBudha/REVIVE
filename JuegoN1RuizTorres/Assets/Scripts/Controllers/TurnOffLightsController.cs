using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffLightsController : MonoBehaviour {

    [SerializeField] private GameObject[] Lights = null;
    [SerializeField] private GameObject[] Box = null;
    //[SerializeField] private GameObject triggerN4;
    [SerializeField] private bool onOff;

    void Update()
    {
        if (onOff)
        {
            foreach (GameObject go in Lights)
            {
                Light light = go.GetComponent<Light>();
                light.intensity = 0f;
            }

            foreach (GameObject go in Box)
            {
                Renderer renderer = go.GetComponent<Renderer>();
                Material mat = renderer.material;

                float emission = Mathf.PingPong(Time.time, 1f);
                Color baseColor = Color.black; //Replace this with whatever you want for your base color at emission level '1'

                Color finalColor = baseColor * Mathf.LinearToGammaSpace(emission);

                mat.SetColor("_EmissionColor", finalColor);
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        onOff = true;
        //triggerN4.SetActive(true);
    }
}
