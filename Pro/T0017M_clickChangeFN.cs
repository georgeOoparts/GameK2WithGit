using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T0017M_clickChangeFN : MonoBehaviour
{
    //パネルを押すと、命題Flag1_1を選択　、T0002M_kyotuHensu.meidaiNumberが0になる。
    //meidaiのパネルをクリックすると対象のフラッグがフラッグパネルが出現、メインカメラ移動
    //canvas>MokujiPanel>MoveMokujiPanel(アタッチ)>MokujiTextPanel1_1～6>TextMokuji1_1～6
    //メインカメラの移動を制御
    //canvas>FlagPanel>MoveflagPanel>Flag1_1～6(制御)>FlagPanel1_1_1～6

    void Start()
    {
        
    }

    void Update()
    {
    }

    //このメソッドがアタッチしたuiを押すと実行される。
    //0021_99_1:uiボタンを使う
    public void onClick() 
    {
        T0002M_kyotuHensu.meidaiNumber = 0;
        //k5_1_1:atStatic:静的変数を外のクラスから（クラス名）.(変数名)で呼び出す。
        //Debug.Log("changesimasu::"+ T0002M_kyotuHensu.meidaiNumber);
    }

}
