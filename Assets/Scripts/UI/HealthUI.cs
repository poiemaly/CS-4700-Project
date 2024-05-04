using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Text HealthText;

    // Update is called once per frame
    void Update()
    {
        HealthText.text = GameStats.Lives.ToString()+ "/15";
    }
}
