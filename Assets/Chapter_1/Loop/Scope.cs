using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope : MonoBehaviour
{
    void Start()
    {
        int a = 7;
        Debug.Log(a);    //�u7�v���\�������E�E�E�T

        if (a == 7)
        {
            int b = 1;
            Debug.Log(a);    //�u7�v���\�������E�E�E�U
            Debug.Log(b);    //�u1�v���\�������E�E�E�V
        }
        Debug.Log(a);    //�u7�v���\�������E�E�E�W
        Debug.Log(b);    //�G���[�ɂȂ�E�E�E�X

    }
}

