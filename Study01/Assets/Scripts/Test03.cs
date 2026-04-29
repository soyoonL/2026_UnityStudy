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
    // 1부터 1000까지의 수 중에서, 0과 5로만 이루어진 수를 찾아 리스트에 넣고 출력
    // % 10 : 숫자의 마지막 자릿수를 구함
    // / 10 : 마지막 자릿수를 제거함
    
    private void Start()
    {
        
        List<int> numbers = new List<int>();
        for (int i = 0; i <= 1000; i++)
        {
            if(i % 10 == 0 || i%10 == 5)
            {
                if(i/10 == 0 || i/10 == 5 || i/10==50 || i/10 == 55)
                {
                    numbers.Add(i);
                }
            }
            
        }

       foreach(int number in numbers)
        {
            Debug.Log(number);
        }

    }



}
