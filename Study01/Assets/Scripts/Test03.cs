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
    // 크기 10의 정수 배열을 만들고, 원하는 수를 넣어 초기화한다. 그 배열의 저장된 수의 순서를 뒤집는다.

    
    private void Start()
    {
        int[] a = { 3, 7, 1, 9, 2, 8, 4, 6, 5, 10 };
        int b = 9;
        

        for (int i = 0; i < 5; i++)
        {
            int temp = a[i];
            a[i] = a[b];
            a[b] = temp;
            b = b - 1;
           
        }

       

        foreach (int  x in a)
        {
            Debug.Log(x);
        }

    }



}
