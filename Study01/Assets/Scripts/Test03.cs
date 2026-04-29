using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEditor.Rendering;
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
        int temp;
        // 만약 i가 505 일때, while문 안에 있는 if를 거치지 않아 true인 상태이므로 numbers에 들어갈 수 있음
        // 만약 i가 220 일때, 첫바퀴에는 while문 안에 있는 if문을 통과(뒷자리가 0이기에), / 10을 통해 temp = 22가 됨
        // 하지만 두번째 바퀴에서 temp = 22이기에 while문 안에 있는 if를 거치고 pass = false가 되어 while문을 빠져나감

        // for문 반복 과정에서 pass가 true 였던 숫자만 List numbers에 들어감

        for (int i = 0; i <= 1000; i++)
        {
            bool pass = true;
            temp = i;
           while(temp>0)
            {
                if(temp % 10 !=0 && temp % 10 != 5)
                {
                    pass = false; 
                    break;
                }
                temp = temp / 10;
            }
           

            if(pass == true)
            {
                numbers.Add(i);
            }
            
        }

       foreach(int number in numbers)
        {
            Debug.Log(number);
        }

    }



}
