using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_002 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int answer;                   // ���� answer ����
        answer = 1 + 2;               //answer�� 1+2 ���� ���� �Է�
        Debug.Log(answer);            // answer�� Debug.Log�� ��½�Ŵ

        int n1 = 8;
        int n2 = 9;
        int answer2;
        answer2 = n1 + n2;
        Debug.Log(answer2);
        int answer3 = 10;
        answer3 += 5;
        Debug.Log(answer3);
        answer3++;
        Debug.Log(answer3);

        string str = "Happy";     //���ڿ� str��   'happy" �Է�
        string str2 = "birthday";

        str += str2;
        Debug.Log(str);

        string message = str + answer3;
        Debug.Log(message);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
