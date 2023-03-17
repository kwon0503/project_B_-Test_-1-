using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_002 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int answer;                   // 정수 answer 선언
        answer = 1 + 2;               //answer에 1+2 연산 값을 입력
        Debug.Log(answer);            // answer를 Debug.Log에 출력시킴

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

        string str = "Happy";     //문자열 str에   'happy" 입력
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
