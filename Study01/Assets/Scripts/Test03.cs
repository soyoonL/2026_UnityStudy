using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Test03 : MonoBehaviour
{
    

    private void Start()
    {
        // 3줄 × 3칸짜리 2차원 배열을 만들어서 구구단 7단의 7×1부터 7×9까지의 결과값을 순서대로 저장하고, 이중 for문으로 모든 값을 Debug.Log로 출력하는 프로그램을 작성하세요.

        int[,] a  = new int[3, 3];
        int count = 1;

        for (int i = 0;  i < 3; i++)
        {

            for(int j = 0; j < 3; j++)
            {
                a[i, j] = 7 *count;
                count++;
                Debug.Log(a[i, j]);
            }
           
        }


    }
}
