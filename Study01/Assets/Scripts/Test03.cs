using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Test03 : MonoBehaviour
{
    // 컬렉션 : 하나의 이름 아래 여러 개의 데이터를 묶어서 관리하는 것
    // 배열과 비슷하지만 다름
    // 컬렉션은 배열과 달리 크기가 정해져있지 않음
    // 배열은 처음에 방을 만들 때 방의 개수를 정해놓고 얘기했지만, 컬렉션은 실시간으로 계속해서 방의 개수를 변화시킬 수 있음.
    // Dictionary, List

    private void Start()
    {
        // List <string> list 까지만 하면 이름만 선언해준것,new List<string>();를 넣어 자리까지 만들어주기
        List<string> movie = new List<string>();

        movie.Add("HarryPorter");
        movie.Add("US");
        movie.Add("About Time");

        movie.Insert(0, "matrix");
        movie.Clear();
        //movie.RemoveAt(1);
        //movie.Remove("HarryPorter");

        // 대부분 명령을 수행할때에는 괄호를 쓰지만 Count 같은 경우 괄호를 따로 쓰지 않음
        for (int i = 0; i < movie.Count; i++)
        {
            Debug.Log(movie[i]);
        }

        // Contains : 이 리스트에 "matrix'가 들어가 있는지
        // Debug.Log(movie.Contains("matrix"));
        // IndexOf : 이 matrix의 문자열이 몇번인지 알려주는 
        // 없는 내용을 넣으면 결과는 -1이 나옴
        // Debug.Log(movie.IndexOf("matrix"));



    }


}
