using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope : MonoBehaviour
{
    void Start()
    {
        int a = 7;
        Debug.Log(a);    //「7」が表示される・・・�T

        if (a == 7)
        {
            int b = 1;
            Debug.Log(a);    //「7」が表示される・・・�U
            Debug.Log(b);    //「1」が表示される・・・�V
        }
        Debug.Log(a);    //「7」が表示される・・・�W
        Debug.Log(b);    //エラーになる・・・�X

    }
}

