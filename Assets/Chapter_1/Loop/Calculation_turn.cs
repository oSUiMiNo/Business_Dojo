using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculation_turn : MonoBehaviour
{
    void Start()
    {
        int money = 10000;  //現在の所持金
        int salaly = 900;  //時給
        int hour = 5;    //働いた時間

        int sum = money + salaly * hour;
        Debug.Log(sum);
    }
}
