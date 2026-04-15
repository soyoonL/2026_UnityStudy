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
    

    private void Start()
    {
      for(int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }

      // i 라는 변수를 만들어서 0을 집어넣는다. i가 10보다 작은 동안 이 안을 반복한다. 매번 i를 1씩 올릴 것이다
    }
}
