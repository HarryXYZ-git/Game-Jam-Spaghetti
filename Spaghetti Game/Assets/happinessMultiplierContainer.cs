using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class happinessMultiplierContainer : MonoBehaviour
{
    // Start is called before the first frame update
    public static happinessMultiplierContainer happinessContainer;
    public float happinessMultiplier;
    void Awake()
    {
        if(happinessContainer != null)
        {
            Destroy(this.gameObject);
            return;
        }
        happinessContainer = this;
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame

}
