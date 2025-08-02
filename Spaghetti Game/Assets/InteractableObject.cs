using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public GameControl GameController;
    // Start is called before the first frame update
    void Awake()
    {
        GameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ObjectInteraction()
    {
        //Debug.Log("Hello");
        GameController.removeInteractable(this.gameObject);
        Destroy(this.gameObject);
    }
}
