using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    // 제어문 : 상황에 따라 명령어의 실행을 선택하고 순서를 바꾸거나 반복시키는 명령
    // case는 연달아 사용 가능, 즉 첫번째 케이스나 두 번쩨 케이스가 해당할 경우 아래로 넘어가게 하는 방향으로 작성 가능

    // 핵심은 좁은 조건(400)부터 먼저 검사하고, 넓은 조건(4)을 나중에 검사하는 것!
    public int a;
    public int b;
    public string cal;
   
    void Start()
    {
        switch (cal)
        {
            case "+":
               Debug.Log(a+b);
               break;
            case "-":
                Debug.Log(a - b);
                break;
            case "*":
                Debug.Log(a * b);
                break;
            case "/":
                Debug.Log(a / b);
                break;
            default:
                Debug.Log("연산기호를 넣어주세요");
                break;
        }
    }

 
}
