using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int age;        //���� age�� ����
        age = 30;       //���� age�� 30�� ���� �Է�
        Debug.Log(age); //age�� �Էµ� ���� ����Ƽ Console â�� ������

        float height1 = 160.5f;     //heigh1�� 160.5�� ����
        float height2;             //heigh2 ����

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
