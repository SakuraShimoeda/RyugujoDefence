using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    public int hp = 5;//hpを5にする。SliderのMaxValueとValueはここの値に合わせます
    private Slider _slider;//Sliderの値を代入する_sliderを宣言
    public GameObject slider;//体力ゲージに指定するSlider

    // Use this for initialization
    void Start()
    {
        _slider = slider.GetComponent<Slider>();//sliderを取得する
    }

    // Update is called once per frame
    void Update()
    {
        _slider.value = hp;//スライダーとHPの紐づけ
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hp -= 1;//hpを-1ずつ変える
        }

        if (hp <= 0)//もしhpが0以下なら
        {
            FindObjectOfType<Point>().AddPoint(0);
            Destroy(this.gameObject);
            SceneManager.LoadScene("Clear");
        }
    }
}