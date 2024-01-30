using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope : MonoBehaviour
{
    void Start()
    {
        int a = 7;
        Debug.Log(a);    //「7」が表示される・・・Ⅰ

        if (a == 7)
        {
            int b = 1;
            Debug.Log(a);    //「7」が表示される・・・Ⅱ
            Debug.Log(b);    //「1」が表示される・・・Ⅲ
        }
        Debug.Log(a);    //「7」が表示される・・・Ⅳ
        Debug.Log(b);    //エラーになる・・・Ⅴ

    }
}

