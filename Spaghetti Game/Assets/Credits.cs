using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public GameObject credits;
    // Start is called before the first frame update
    public void SpawnCredits()
    {
        credits.SetActive(true);
    }
}
