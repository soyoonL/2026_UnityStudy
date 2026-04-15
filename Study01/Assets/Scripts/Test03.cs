using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    // 제어문 : 상황에 따라 명령어의 실행을 선택하고 순서를 바꾸거나 반복시키는 명령
    // case는 연달아 사용 가능, 즉 첫번째 케이스나 두 번쩨 케이스가 해당할 경우 아래로 넘어가게 하는 방향으로 작성 가능

    //중첩 if문, 안으로 파고들며 검사하는 방식 
    // ex) 1900 > 4로 나누어떨어짐? ㅇㅇ > 100으로? ㅇㅇ > 400으로? ㄴㄴ > 평년
    public int year;
   
    void Start()
    {
        if (year % 4 == 0)
        {
            if(year%100 == 0)
            {
                if(year%400==0)
                {
                    Debug.Log("윤년입니다");
                }
                else
                {
                    Debug.Log("평년입니다");
                }
            }
            else
            {
                Debug.Log("윤년입니다");
            }
        }
        else
        {
            Debug.Log("평년입니다");
        }
    }

 
}
