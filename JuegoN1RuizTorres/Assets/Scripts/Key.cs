using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    [SerializeField] int score;
    public GameObject triggerObject;

    private void OnTriggerEnter(Collider other)
    {
        triggerObject.GetComponent<TurnOffLightsController>().enabled = true;

        ScoreManager.Instance.Score += score;
        Destroy(gameObject);

    }
}
