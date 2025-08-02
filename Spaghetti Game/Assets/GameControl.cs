using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public float timer;
    private float maxTimer;
    public float deathTimerLoss;
    public float happinessDrainMultiplier;
    public GameObject happinessMultiplierStorage;
    public HappinessSlider happiness;
    public float customerAngryTimer;
    public List<GameObject> interactableObjects;
    // Start is called before the first frame update
    private void Start()
    {
        happinessDrainMultiplier = happinessMultiplierContainer.happinessContainer.happinessMultiplier;
    }

    void Awake()
    {
        happiness.SetMaxHappiness(timer);
        maxTimer = timer;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timer <= 0.0f)
        {
            EndGame();
        }
        else if (timer < 100.0f)
        {
            happiness.SetHappinessFace(0);
            customerAngryTimer += Time.deltaTime;
        }
        else if (timer < 200.0f)
        {
            happiness.SetHappinessFace(1);
        }
        else if (timer > maxTimer)
        {
            happiness.SetHappinessFace(3);
        }
        else
        {
            happiness.SetHappinessFace(2);
        }

        if(interactableObjects.Count == 0)
        {
            Debug.Log("Victory Lad");
            happinessMultiplierContainer.happinessContainer.happinessMultiplier += 2.0f;
            //happinessMultiplierStorage.GetComponent<happinessMultiplierContainer>().happinessMultiplier += 2.0f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        timer -= Time.deltaTime * happinessDrainMultiplier;
        happiness.SetHappiness(timer);
    }

    public void EndGame()
    {
        Debug.Log("Game Over Test");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void removeInteractable(GameObject removedObject)
    {
        if (interactableObjects.Contains(removedObject))
        {
            interactableObjects.Remove(removedObject);
        }
    }
}
