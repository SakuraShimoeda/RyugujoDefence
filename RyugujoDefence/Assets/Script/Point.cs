using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;  // 追加しましょう

public class Point: MonoBehaviour
{

    public GameObject score_object = null; // Textオブジェクト
    public int score_point = 0;

    // 初期化
    void Start()
    {
    }

    public void AddPoint(int point)
    {
        // オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える

        score_text.text = "Score:" + score_point; ;
       
    }
    // 更新

     
    
}