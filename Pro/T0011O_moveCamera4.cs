using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T0011O_moveCamera4 : MonoBehaviour
{
    //縦移動のみスワイプ
    //tupしていた時間を得るプログラム
    //tupしていた距離を得るプログラム
    //移動させるメインカメラにアタッチ

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
    
    //flick--------------------------------------------------------------------------
    //タップ開始からタップ終了までの時間を得るメソッド
    //フリックをするメソッド
    Vector3 tupDown = new Vector3(0, 0, 0);    
    void flick()
    {
        //k3_a:Input.mousePosition.ToString()でマウスのスクリーンポイント表示
        //k3_zz2_a:スクリーン座標＞ワールド座標
        if (Input.GetMouseButtonDown(0))
        {
            tupDown = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetMouseButton(0))
        {
            if (tupDown != Camera.main.ScreenToWorldPoint(Input.mousePosition))
            {
                Vector3 diff = tupDown - Camera.main.ScreenToWorldPoint(Input.mousePosition);
                this.gameObject.transform.position += new Vector3(0, diff.y, 0);
            }
        }
    }
    //flick-----end---------------------------------------------------------------------
}
