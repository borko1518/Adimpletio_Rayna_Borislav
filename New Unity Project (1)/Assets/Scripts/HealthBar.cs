using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public PlHealth plH;
    public Image fillImage;
    public Slider slider;
    // Start is called before the first frame update
    void Awake()
    {
        slider.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        float fillVal = plH.currentHealth / plH.maxHealth;
        slider.value = fillVal;
    }
}
