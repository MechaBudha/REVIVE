using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WallEvent : MonoBehaviour
{
    [SerializeField] GameObject wall;

    private void Update()
    {    
            if (ScoreManager.Instance.Score >= 300)
            {
                wall.GetComponent<WallController>().enabled = true;
            }
    }
}
