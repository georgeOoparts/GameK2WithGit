using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T0018M_clickChangeFN0 : MonoBehaviour
{
    //1;命題パネル1～6を押すと、命題Flag1_1～6を選択　、T0002M_kyotuHensu.meidaiNumberが0～5になる。
    //1;命題パネル1～6を押すとフラッグパネルが1～6に変化する。
    //2:0.15秒より短いボタンタップでメイダイナンバー変更
    //3:tap up とtupdownの位置が同じ時だけメイダイナンバー変更（フリックスワイプ対策）
    //meidaiのパネルをクリックすると対象のフラッグがフラッグパネルが出現、メインカメラ移動
    //canvas>MokujiPanel(アタッチ)>MoveMokujiPanel>MokujiTextPanel1_1～6>TextMokuji1_1～6
    //メインカメラの移動を制御
    //canvas>FlagPanel>MoveflagPanel>Flag1_1～6(制御)>FlagPanel1_1_1～6

    //k6_1:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
    = new System.Diagnostics.Stopwatch();

    //k6_1_1:何秒たったかを変数elapseに入れる：update内に入れる-------
    ////?
    private float elapse;
    //0.15秒以上タップしていると、ボタンを押しているのが無効になる
    public float tupTime=0.15f;
    //タップした場所と違うところでupするとボタンを押しているのが無効になる。
    //そのための座標を入れる変数
    Vector3 down;
    Vector3 up;
    void LateUpdate()
    {
        elapse = (float)stopwatch.Elapsed.TotalSeconds;


        //tupTimeHantei = false;
        if (Input.GetMouseButtonDown(0)) 
        {
            //k6_1_1_2:ストップウォッチの時間をリセット
            stopwatch.Reset();
            //k6_1_1_1:ストップウォッチスタート
            stopwatch.Start();

            down = Input.mousePosition;
        }


        if (Input.GetMouseButtonUp(0))
        {
            stopwatch.Stop();
            up = Input.mousePosition;
        }
        //Debug.Log(elapse);

        
        if (boolClick0)
        {
            //tupUpとtupDownが同じ位置　かつ　タップの時間が一定以下ならば
            if ((up == down)&&(elapse <= tupTime))
            {
                T0002M_kyotuHensu.meidaiNumber = 0;
                T0002M_kyotuHensu.cameraPosiNumber = 1;
            }

            boolClick0 = false;
        }
        else if (boolClick1)
        {
            if ((up == down) && (elapse <= tupTime))
            {
                T0002M_kyotuHensu.meidaiNumber = 1;
                T0002M_kyotuHensu.cameraPosiNumber = 1;

            }
            boolClick1 = false;
        }
        else if (boolClick2)
        {
            if ((up == down) && (elapse <= tupTime))
            {
                T0002M_kyotuHensu.meidaiNumber = 2;
                T0002M_kyotuHensu.cameraPosiNumber = 1;

            }
            boolClick2 = false;
        }
        else if (boolClick3)
        {
            if ((up == down) && (elapse <= tupTime))
            {
                T0002M_kyotuHensu.meidaiNumber = 3;
                T0002M_kyotuHensu.cameraPosiNumber = 1;

            }
            boolClick3 = false;
        }
        else if (boolClick4)
        {
            if ((up == down) && (elapse <= tupTime))
            {
                T0002M_kyotuHensu.meidaiNumber = 4;
                T0002M_kyotuHensu.cameraPosiNumber = 1;

            }
            boolClick4 = false;
        }
        else if (boolClick5)
        {
            if ((up == down) && (elapse <= tupTime))
            {
                T0002M_kyotuHensu.meidaiNumber = 5;
                T0002M_kyotuHensu.cameraPosiNumber = 1;

            }
            boolClick5 = false;
        }
        //Debug.Log(boolClick0);
    }

    //ボタン0　フラッグ1に対応
    //このメソッドがアタッチしたuiを押すと実行される。
    //0021_99_1:uiボタンを使う

    //ボタンを押したらtrueになるブール代数たち
    
    bool boolClick0 = false;
    bool boolClick1 = false;
    bool boolClick2 = false;
    bool boolClick3 = false;
    bool boolClick4 = false;
    bool boolClick5 = false;

    //uiボタンを押したとき起動するメソッド
    //canvas>MokujiPanel>MoveMokujiPanel>MokujiTextPanel1_1～6（このUIたちにインスぺで設定した）>TextMokuji1_1～6
    public void onClick0()
    {
        boolClick0 = true;
    }
    public void onClick1()
    {
        boolClick1 = true;
    }
    public void onClick2()
    {
        boolClick2 = true;
    }
    public void onClick3()
    {
        boolClick3 = true;
    }
    public void onClick4()
    {
        boolClick4 = true;
    }
    public void onClick5()
    {
        boolClick5 = true;
    }
}
