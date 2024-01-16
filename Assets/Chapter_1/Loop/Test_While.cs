using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_While : MonoBehaviour
{
    void Start()
    {
		int counter = 3;
		while(counter >= 1)
		{
            Debug.Log(counter);
            counter --;
		}
		Debug.Log("スタート！！");
    }
}
