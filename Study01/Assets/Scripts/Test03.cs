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
            string stars = "";

            for(int j = 0; j< i; j++)
            {
                stars += "*";
            }

            Debug.Log(stars);
        }

        // i=0이면 j<i가 성립이 안됨(0<0). 그러므로 처음에는 빈 칸으로 나옴
        // i=1이면 0<1로 성립이 되므로 * 출력, 1<1은 성립이 안되므로 출력 더 이상 안됨
        // string stars = "" 변수를 만드는 이유는 별을 중첩시키지 않기 위해서이다. 매 줄마다 빈 상자로 초기화시켜 차례대로 피라미드가 나오게 한다
    }
}
