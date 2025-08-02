using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreContainer : MonoBehaviour
{
    // Start is called before the first frame update

    public static ScoreContainer scoreContainer;
    public int score;
    void Awake()
    {
        if (scoreContainer != null)
        {
            Destroy(this.gameObject);
            return;
        }
        scoreContainer = this;
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
