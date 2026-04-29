using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Test03 : MonoBehaviour
{
    // 5x5 크기의 bool 2차원 배열을 만든다. a[i,j]라고 했을 때,i가 더 클때는 true, j가 더 클때는 false를 넣어 배열을 채운다.

    
    private void Start()
    {
        bool [,] a = new bool[5,5];

        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                if (i > j)
                {
                    a[i,j] = true;
                }
                else if (j > i)
                {
                    a[i,j] = false;
                }
                else if(i == j)
                {
                    a[i, j] = false;
                }

                Debug.Log(a[i,j]);
            }
        }

    }



}
