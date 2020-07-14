using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//シーン変更用

public class Timer2 : MonoBehaviour
{

    public Text resultTime;//リザルトタイム
    public GameObject resultUI;//リザルトUI 

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
     
        
            int result = Mathf.FloorToInt(Timer1.countTime);//整数に直す
            resultTime.text = result + "秒";//結果の表記
        }
    }


