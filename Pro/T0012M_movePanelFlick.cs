using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T0012M_movePanelFlick : MonoBehaviour
{
    //縦移動のみスワイプ
    //tupしていた時間を得るプログラム
    //tupしていた距離を得るプログラム
    //移動させるメインカメラにアタッチ
    //フリック＞パブリックでMOVEパネルを当てはめる

    void Update()
    {
        //k6_ac:何秒たったかを変数elapseに入れる:update内にいれる。>tupTimeに使う。
        elapse = (float)stopwatch.Elapsed.TotalSeconds;

        //フリックをするメソッド
        flick();
        // tup up downの距離を得るメソッド
        //スクリーンポイントをkyoriに値を入れる
        //縦、横とも移動はメインカメラが動くので
        //world座標でなく、スクリーン座標で距離を得る
        tupDistance();
        //tupした時間をelapseに入れるメソッド
        tupTime();
    }
    //tupTime-------------------------------------------------------------------------------
    //tupした時間をelapseに入れるメソッド
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();

    // 何秒たったかを変数elapseに入れる。ストップウォッチ
    private float elapse;

    void tupTime()
    {
        if (Input.GetMouseButtonDown(0))
        {
            stopwatch.Start();
        }
        if (Input.GetMouseButtonUp(0))
        {
            stopwatch.Reset();
        }
        //Debug.Log(elapse);
    }

    //tupTime---end----------------------------------------------------------------------------

    //tupDistance--------------------------------------------------------------------------
    // tup up downの距離を得るメソッド
    //スクリーンポイントをkyoriに値を入れる
    //縦、横とも移動はメインカメラが動くので
    //world座標でなく、スクリーン座標で距離を得る

    Vector3 kyoriDown = new Vector3(0, 0, 0);
    Vector3 kyori = new Vector3(0, 0, 0);
    void tupDistance()
    {
        if (Input.GetMouseButtonDown(0))
        {
            kyoriDown = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            kyori = Input.mousePosition - kyoriDown;
            //Debug.Log(kyori);
        }
    }
    //tupDistance---end-----------------------------------------------------------------------

    //flick------カメラは動かさずパネルを動かす--------------------------------------------------------------------
    //フリックをするメソッド
    //パブリックでMOVEパネルを当てはめる
    public GameObject toumeiPanel;
    Vector3 tupDown = new Vector3(0,0,0);
    void flick()
    {
        //k3_a:Input.mousePosition.ToString()でマウスのスクリーンポイント表示
        //k3_zz2_a:スクリーン座標＞ワールド座標
        if (Input.GetMouseButtonDown(0))
        {
            tupDown = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            if (tupDown!= Input.mousePosition)
            {
                Vector3 diff = Input.mousePosition - tupDown;

                toumeiPanel.GetComponent<RectTransform>().anchoredPosition 
                    = new Vector2 (0, toumeiPanel.GetComponent<RectTransform>().anchoredPosition.y+diff.y);
            }
            tupDown = Input.mousePosition;

        }
    }
    //flick-----end---------------------------------------------------------------------
}
