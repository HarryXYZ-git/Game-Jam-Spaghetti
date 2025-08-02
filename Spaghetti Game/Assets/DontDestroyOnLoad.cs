using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    // Start is called before the first frame update
    public static DontDestroyOnLoad Instance;
    void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

}
