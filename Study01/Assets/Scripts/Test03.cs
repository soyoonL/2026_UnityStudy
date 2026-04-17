using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Test03 : MonoBehaviour
{
    

    private void Start()
    {
        // 다차원 배열
        // int[세로,가로]
        // 배열 크기와 for문의 범위는 항상 같아야 함
        // 이건 2차원

        int[,] a = new int[3, 3];

        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                a[i, j] = i * 6 + j * 9;
                Debug.Log("i"+i+",j"+j+ "="+a[i, j]);
            }
        }
       

    }
}
