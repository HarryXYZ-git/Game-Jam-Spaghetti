using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillsTheGame : MonoBehaviour
{
    public GameObject credits; //placeholder, delete once actual credits scene is in place
    public void BlowsUpTheGameAndAlsoYourHouse()
    {
        credits.SetActive(false);//placeholder, delete once actual credits scene is in place
        Application.Quit();
        Debug.Log("Mate the game is dead");
    }
}
