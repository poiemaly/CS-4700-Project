using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStats : MonoBehaviour
{
    public static int Money;
    public int startMoney = 40;

    public static int Lives;
    public int startLives = 15;

    void Start(){
        Money = startMoney;
        Lives = startLives;
    }
    void Update(){
        Debug.Log(Money);
    }
}
