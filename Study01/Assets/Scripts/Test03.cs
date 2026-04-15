using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    // 제어문 : 상황에 따라 명령어의 실행을 선택하고 순서를 바꾸거나 반복시키는 명령
    // case는 연달아 사용 가능, 즉 첫번째 케이스나 두 번쩨 케이스가 해당할 경우 아래로 넘어가게 하는 방향으로 작성 가능
    public int number;
   
    void Start()
    {
        if (number > 0)
        {
            Debug.Log("이 수는 양수입니다");
        }
        else if(number < 0)
        {
            Debug.Log("이 수는 음수입니다");
        }
        else
        {
            Debug.Log("이 수는 0입니다");
        }
        
    }

 
}
