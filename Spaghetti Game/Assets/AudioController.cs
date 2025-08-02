using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController audioController;
    // Start is called before the first frame update
    void Awake()
    {
        if(audioController != null)
        {
            Destroy(this.gameObject);
            return;
        }
        audioController = this;
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
