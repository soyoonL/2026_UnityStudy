using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    int a = 5;
    int b = 10;
    int c = 20;
    int d = 30;

    private void Start()
    {
        Debug.Log(a < b || c < d);  // 둘 중 하나만 True이면 True
        Debug.Log(a < b && c < d);  // 둘 다 True여야 True
        Debug.Log(!true); // !는 not이라는 뜻,bool형에만 가능

        a += 2; // a = a+2
        a++; // a = a+1, a += 1

        a = b > c ? 1 : 2; // a가 true이면 1을, false면 2를 넣자

        // null : 아무것도 없는 텅 비어있는

        string str = null;
        string str2 = "abc";

        string str3 = str ?? str2;
        str ??= str2;

        Debug.Log(str3);

        //?? : 왼쪽 값이 없으면(null)이면 오른쪽의 값으로 대신 감,있으면 그대로 씀
        //??= : str 변수 값이 null이면 str2의 값을 넣고, 아니면 그대로 씀 / str = str ?? str2 
    }

}
