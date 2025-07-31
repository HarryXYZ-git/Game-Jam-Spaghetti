using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Vector3 offset;
    public GameObject player;
    // Start is called before the first frame update
    void Awake()
    {
        offset = this.transform.position - player.transform.position;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        this.transform.position = player.transform.position - offset;
    }
    
}
