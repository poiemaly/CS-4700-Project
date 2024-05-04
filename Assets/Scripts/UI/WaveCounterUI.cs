using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveCounterUI : MonoBehaviour
{
    public Text waveText;
    void Update()
    {
        waveText.text = Spawner.waveIndex.ToString() + "/" + Spawner.waveLength.ToString();
    }
}
