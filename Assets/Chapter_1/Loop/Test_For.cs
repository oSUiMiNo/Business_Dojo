using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_For : MonoBehaviour
{
    //5回攻撃するスクリプト
    void Start()
    {
        for(int a = 0; a < 5; a++)
        {
            Debug.Log("攻撃");
        }
    }
}
