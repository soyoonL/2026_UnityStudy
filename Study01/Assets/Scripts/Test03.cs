using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    // 반복문 :  특정 조건을 만족할 경우 원하는 명령을 계속해서 반복하도록 하는 명령
    // while : 특정 조건을 만족하는 동안 반복
    // do while : 조건에 맞든 안 맞든 일단 한번은 실행하고 조건 비교

    int dice;
    void Start()
    {
        do
        {
            dice = Random.Range(1, 7);
            Debug.Log(dice);
        } while (dice == 6);

    }

 
}
