using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_01B_kyotuElapse : MonoBehaviour
{
    //ストップウォッチで使う、共通変数であるelapseを作るプログラム
    //強調表現　点滅のブール変数tenmetuOnOffを作るプログラム

    //共通変数であるelapse,tenmetuOnOff使いまわす
    //使っている13mojihonban,

    //アタッチ＞mainncamera


    //このelapseはH_99_12_zukeiPPRRのほうで共通変数として利用される
    //H_99_16_sTriangleHenkaも


    //点滅強調に使う。kyochoHantei()メソッド--------------------------------------------------------
    //void kyochouPanel(int count) の中で使う。
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    //updateでelapse = (float)stopwatch.Elapsed.TotalSeconds;忘れずに 
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();
    
    //それによって、点滅のタイミングを完全に合わせる
    public float elapse = 0;
    public bool tenmetuOnOff = true;
    public float interval = 0.35f;

    bool kyochoHantei() 
    {
        if (tenmetuOnOff == true) 
        {
            if (elapse >= interval) 
            {
                tenmetuOnOff = false;

                //k6_ab:ストップウォッチの時間をリセット
                stopwatch.Reset();
                //k6_aa:ストップウォッチスタート
                stopwatch.Start();
                return (tenmetuOnOff);
            }
            return (true);
        } 
        else if (elapse >= interval) 
        {
            tenmetuOnOff = true;

            //k6_ab:ストップウォッチの時間をリセット
            stopwatch.Reset();
            //k6_aa:ストップウォッチスタート
            stopwatch.Start();
            return (tenmetuOnOff);
        }
        return (false);
    }
    void Start() 
    {
        //k6_aa:ストップウォッチスタート
        stopwatch.Start();
    }

    // Update is called once per frame
    void Update() 
    {
        //k6_ac:何秒たったかを変数elapseに入れる
        elapse = (float)stopwatch.Elapsed.TotalSeconds;

        kyochoHantei();
        //Debug.Log(elapse+"::"+tenmetuOnOff);
    }
}
