using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Test03 : MonoBehaviour
{
    // 가변 배열을 이용해 1번째 줄에는 {1, 2}, 2번째 줄에는 {3, 4, 5}, 3번째 줄에는 {6, 7, 8, 9}를 저장하고,
    // for문으로 모든 값을 Debug.Log로 출력하는 프로그램을 작성하세요. (힌트: 각 줄의 길이가 다르다는 게 포인트!)

    int[][] a = new int[3][];

    private void Start()
    {
        a[0] = new int[2] { 1, 2 };
        a[1] = new int[3] { 3,4,5 };
        a[2] = new int[4] { 6, 7, 8, 9 };

        for(int i = 1; i < 4; i++)
        {
            //int count = 0;
            for(int j = 0; j <= i; j++)
            {
                Debug.Log(a[i-1][j]); 
            }
        }



    }
}
