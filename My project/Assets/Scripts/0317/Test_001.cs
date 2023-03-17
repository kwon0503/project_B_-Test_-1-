using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int age;        //변수 age를 선언
        age = 30;       //변수 age에 30의 값을 입력
        Debug.Log(age); //age에 입력된 갑을 유니티 Console 창에 보여줌

        float height1 = 160.5f;     //heigh1에 160.5값 선언
        float height2;             //heigh2 선언

        height2 = height1;
        Debug.Log(height2);

        string name;
        name = "Sera";
        Debug.Log(name);
     

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
