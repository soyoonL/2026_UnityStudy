using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Test03 : MonoBehaviour
{
    // 반복문 :  특정 조건을 만족할 경우 원하는 명령을 계속해서 반복하도록 하는 명령
    // while : 특정 조건을 만족하는 동안 반복
    // do while : 조건에 맞든 안 맞든 일단 한번은 실행하고 조건 비교
    // break : 반복문애서 나가기
    // while(true) : 무한반복, 추천하지 않음
    // continue : continue를 만나는 순간 반복문 안에 있는 다음 문장들은 무시하고 다시 올라감
    // for(초기화 ;반복 조건; 반복명령어

    public int a;
    public int b;
    private int count = 0;
    private void Start()
    {
        if(a>1 && b > 1)
        {
            int result = a;
            while (result <= 1000)
            {
               result = result * b;
               count++;
                
            }

            Debug.Log(a + "에" + b + "를" + count + " 번 곱하면 1000을 넘습니다.");
        }
        else
        {
            Debug.Log("1보다 큰 수를 입력해주세요.");
        }

    }

    // int result = b : result 변수에 b의 값을 넣음.
    // result = result * b : 예를 들어 a가 2, b가 3이라고 할 때, 2*3=6,6*3(2*3*3) =18 이런 식으로 
    // result <= 1000 : 결과가 1000보다 작거나 같을 때(a*b를 변수로 간단하게 표현하는 방식이 좋은 거 같음)
}
