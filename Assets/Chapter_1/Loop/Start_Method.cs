using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Method : MonoBehaviour
{
    //Startメソッド
    void Start()
    {
        BoilPasta();
        MakeSauce();
        MixPastaAndSauce();
        Debug.Log("できあがり！！");
    }

    void BoilPasta()
    {
        //ゆでる処理
        //・・・
        Debug.Log("ゆであがった!");
    }

    void MakeSauce()
    {
        //ソースを作る処理
        //・・・
        Debug.Log("ソースができた!");
    }

    void MixPastaAndSauce()
    {
        //混ぜる処理
        //・・・
        Debug.Log("ソースとパスタが混ざった！");
    }

}
