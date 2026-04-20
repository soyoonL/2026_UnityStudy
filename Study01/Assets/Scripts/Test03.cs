using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Test03 : MonoBehaviour
{
    // foreach : 배열이나 컬렉션 안의 모든 원소를 한 번씩 꺼내어 쭉 써보겠다는 의미
    // foreach( 데이터타입 변수명 in 배열명 ){}
    // foreach( 데이터타입 변수명 in 컬렉션명 ){}
    private void Start()
    {
        // List

        List<string> games = new List<string>();

        games.Add("젤다의 전설");
        games.Add("데빌메이크라이");
        games.Add("발더스게이트3");
        games.Add("레지던트 이블");

        foreach (string game in games)
        {
            Debug.Log(game);
        }

        // Dictionary

        Dictionary<string,int> points = new Dictionary<string,int>();

        points.Add("Slime", 5);
        points.Add("Zombie", 10);
        points.Add("Gobline", 15);
        points.Add("Dragone", 20);

        // 방법 1. Key-Value 쌍을 가지고 오는 것 (KeyValuePair)
        // KeyValuePair : 두 가지 자료형을 묶어가지고 하나의 변수에 넣는 것
        foreach (KeyValuePair<string,int> pair in points)
        {
            Debug.Log(pair.Key + ":" + pair.Value);
        }

        // 방법 2. Dictionary가 가지고 있는 Key들만 모아놓은 컬렉션을 꺼내서 쓸 수 있는 것 (points.Keys)
        foreach (string enemy in points.Keys)
        {
            Debug.Log(enemy + ":" + points[enemy]);
        }
    }



}
