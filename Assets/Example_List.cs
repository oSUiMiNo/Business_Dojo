using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_List : MonoBehaviour
{
    void Start()
    {
        Example1();
        Example2();
    }


    void Example1()
    {
        // List の宣言と初期化
        List<string> なまえ = new List<string>() { "けんじ", "かんな", "たくや" };
        // なまえリストに「りん」さんを追加
        なまえ.Add("りん");
        // リストの全部の要素を表示
        foreach (var a in なまえ) Debug.Log(a);
    }


    void Example2()
    {
        // List の宣言と初期化
        List<string> あいさつ = new List<string>()
        {
            "こんにちは",
            "さようなら",
            "こんばんは",
            "おやすみ"
        };
        // あいさつリストから「おやすみ」を削除
        あいさつ.Remove("おやすみ");
        // リストの全部の要素を表示
        foreach (var a in あいさつ) Debug.Log(a);
    }
}
