using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Method : MonoBehaviour
{
    //Start���\�b�h
    void Start()
    {
        BoilPasta();
        MakeSauce();
        MixPastaAndSauce();
        Debug.Log("�ł�������I�I");
    }

    void BoilPasta()
    {
        //��ł鏈��
        //�E�E�E
        Debug.Log("��ł�������!");
    }

    void MakeSauce()
    {
        //�\�[�X����鏈��
        //�E�E�E
        Debug.Log("�\�[�X���ł���!");
    }

    void MixPastaAndSauce()
    {
        //�����鏈��
        //�E�E�E
        Debug.Log("�\�[�X�ƃp�X�^�����������I");
    }

}
