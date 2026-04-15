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

    float kg = 48.5f;
    int count = 0;

    private void Start()
    {
        while (kg <= 70)
        {
            kg += 2f;
            count++;

            if (kg > 60)
                continue;

            Debug.Log("햄버거를 " + count + "번 먹었더니" + kg + "kg이야!!");
            //1~5 count는 실행, 6~10 count는 건너뜀
        }

        Debug.Log("햄버거를 " + count + "번 먹었더니" + kg + "kg이야!!");
        // 11 count는 70.5인데 이는 while 조건인 70 이하보다 크므로 반복문이 끝나면서 while 바깥에 있는 Debug.Log 실행
    }
}
