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
        // List �̐錾�Ə�����
        List<string> �Ȃ܂� = new List<string>() { "����", "�����", "������" };
        // �Ȃ܂����X�g�Ɂu���v�����ǉ�
        �Ȃ܂�.Add("���");
        // ���X�g�̑S���̗v�f��\��
        foreach (var a in �Ȃ܂�) Debug.Log(a);
    }


    void Example2()
    {
        // List �̐錾�Ə�����
        List<string> �������� = new List<string>()
        {
            "����ɂ���",
            "���悤�Ȃ�",
            "����΂��",
            "���₷��"
        };
        // ���������X�g����u���₷�݁v���폜
        ��������.Remove("���₷��");
        // ���X�g�̑S���̗v�f��\��
        foreach (var a in ��������) Debug.Log(a);
    }
}
