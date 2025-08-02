using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HappinessSlider : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image happinessFace;
    public Sprite[] happinessFaces;
    public Image happinessFill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public void SetMaxHappiness(float happiness)
    {
        slider.maxValue = happiness;
        slider.value = happiness;

        happinessFill.color = gradient.Evaluate(1f);
    }

    public void SetHappiness(float happiness)
    {
        slider.value = happiness;

        happinessFill.color = gradient.Evaluate(slider.normalizedValue);
    }

    public void SetHappinessFace(int happinessNumb)
    {
        if (happinessFace.overrideSprite != happinessFaces[happinessNumb])
        {
            Debug.Log("Switch Test");
            happinessFace.overrideSprite = happinessFaces[happinessNumb];
        }
    }
}
