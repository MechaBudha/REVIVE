using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    [SerializeField] int score;

    private void OnTriggerEnter(Collider other)
    {
        ScoreManager.Instance.Score += score;
        Destroy(gameObject);
    }
}
