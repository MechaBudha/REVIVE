using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    [SerializeField] int score;
    public GameObject triggerObject;
    public GameObject trigger;

    private void OnTriggerEnter(Collider other)
    {
        triggerObject.GetComponent<TurnOffLightsController>().enabled = true;
        trigger.SetActive(true);

        ScoreManager.Instance.Score += score;
        Destroy(gameObject);

    }
}
