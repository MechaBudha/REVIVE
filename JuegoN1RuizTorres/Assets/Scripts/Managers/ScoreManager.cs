using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    private static ScoreManager instance;
    [SerializeField] int score;

    public static ScoreManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<ScoreManager>();
                if(instance == null)
                {
                    GameObject go = new GameObject("ScoreManager");
                    instance = go.AddComponent<ScoreManager>();
                }
            }
            return instance;
        }

    }
	
    public int Score
    {
        get { return score; }
        set { score = value; }

    }
}
