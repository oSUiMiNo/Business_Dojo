using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculation_turn : MonoBehaviour
{
    void Start()
    {
        int money = 10000;  //���݂̏�����
        int salaly = 900;  //����
        int hour = 5;    //����������

        int sum = money + salaly * hour;
        Debug.Log(sum);
    }
}
