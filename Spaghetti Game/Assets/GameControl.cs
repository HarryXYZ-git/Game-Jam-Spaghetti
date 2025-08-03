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
    public GameObject[] foodObjects;
    public AudioSource source;
    public AudioClip gameOverClip;

    public int Score;
    // Start is called before the first frame update
    private void Start()
    {
        happinessDrainMultiplier = happinessMultiplierContainer.happinessContainer.happinessMultiplier;
    }

    void Awake()
    {
        happiness.SetMaxHappiness(timer);
        maxTimer = timer;
        foodObjects = GameObject.FindGameObjectsWithTag("Food");
        SpawnInteractables();
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
            ScoreContainer.scoreContainer.score += 100;
            //happinessMultiplierStorage.GetComponent<happinessMultiplierContainer>().happinessMultiplier += 2.0f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        timer -= Time.deltaTime * happinessDrainMultiplier;
        happiness.SetHappiness(timer);
    }

    public void EndGame()
    {
        Debug.Log("Game Over Test");
        source.PlayOneShot(gameOverClip);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    public void removeInteractable(GameObject removedObject)
    {
        if (interactableObjects.Contains(removedObject))
        {
            interactableObjects.Remove(removedObject);
            timer += 10.0f;
        }
    }

    private void SpawnInteractables()
    {
        for(int i = 0; i < interactableObjects.Count; i++)
        {
            int objectLocation = Random.Range(0, foodObjects.Length);

            float objectWidth = foodObjects[objectLocation].GetComponent<Renderer>().bounds.size.x;
            float objectDepth = foodObjects[objectLocation].GetComponent<Renderer>().bounds.size.z;
            float x_offset = (Random.value - 0.5f) * 2 * objectWidth + foodObjects[objectLocation].transform.position.x;
            float z_offset = (Random.value - 0.5f) *2 * objectDepth + foodObjects[objectLocation].transform.position.z;
            interactableObjects[i].transform.position = new Vector3(
                x_offset,
                foodObjects[objectLocation].transform.position.y,
                z_offset);
            
        };
    }
}
