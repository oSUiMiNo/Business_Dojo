using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable : MonoBehaviour
{
    void Start()
    {
        string name;　　//変数の宣言
        int hp;     //変数の宣言

        name = "シンジ";　　//値の代入
        hp = 100;　　　　　　//値の代入

        Debug.Log(name);
        Debug.Log(hp);
    }
}
