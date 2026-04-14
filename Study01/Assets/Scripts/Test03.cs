using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    // 제어문 : 상황에 따라 명령어의 실행을 선택하고 순서를 바꾸거나 반복시키는 명령

    int age = 28;
    string Movie = "LastHoliday";
    void Start()
    {
        if (age < 20) // 조건식이 true면 실행
        {
            Debug.Log("애기");
        }
        else if (age < 30) 
        {
            Debug.Log("애기겠냐");
        }

        switch (Movie)
        {
            case "HarryPorter":
               
            case "KpopDemonHunters":
                Debug.Log("위 고잉 업업");
                break;
            default:
                Debug.Log("누구쎄용");
                break;
        }

        // case는 연달아 사용 가능, 즉 첫번째 케이스나 두 번쩨 케이스가 해당할 경우 아래로 넘어가게 하는 방향으로 작성 가능
    }

 
}
