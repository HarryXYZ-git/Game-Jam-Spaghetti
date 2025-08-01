using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillsTheGame : MonoBehaviour
{
    public void BlowsUpTheGameAndAlsoYourHouse()
    {
        Application.Quit();
        Debug.Log("Mate the game is dead");
    }
}
