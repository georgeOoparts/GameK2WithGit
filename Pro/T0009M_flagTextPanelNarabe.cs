using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T0009M_flagTextPanelNarabe : MonoBehaviour
{
    //フラッグパネル上にある文字の入ったパネルを並べるためのプログラム
    //並べたパネルから数字に応じたものをフラッグパネルに置く
    //オブジェ構成
    //canvas>FlagPanel>MoveflagPanel(アタッチ)>Flag1_1～6(制御)>FlagPanel1_1_1～6
    //flag1-1～6はアンカーを　シフト+真中　上にする。
    
    //めインカメラにアタッチされた共通変数　
    //meidaiNumberをフラグパネルの変更に使う
    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    //このスクリプトをアタッチしたオブジェクトにいちいちこのオブジェクトをアタッチ
    //public T0002M_kyotuHensu kyotu;
    
    //画面上からの距離指定
    public float startPosition = 20;
    //flag1-1～6の間の距離指定
    public float aidaPosition = 20;
    
    void Start()
    {
        //最初にflag1-1～6のパネルを一列に並べる
        ///flag1-1～6をforeach内で指定するための変数

        ///このオブジェの子供全てから順番にTransformを取り出す
        ////k8_4:応用。子、孫になっているＯＢＪを全て得る
        foreach (Transform unko in this.gameObject.transform) 
        {
            ///パネルの開始位置が入る変数をパネルが変更する度に一回リセット
            startPosition = 20;
            
            ////このオブジェの孫全てから順番にRectTransformを取り出す
            foreach (RectTransform kuso in unko) 
            {
                kuso.anchoredPosition = new Vector3(0, -startPosition, -0.1f);

                startPosition += kuso.sizeDelta.y + aidaPosition;
            }
        }
    }

    //update内で対象命題のflagを呼び出す
    
    private int kakkoMeidaiNumber=99;

    void Update() 
    {
        //リアルタイムで対象のオブジェをflagパネルの前に置く
        //共通変数のmeidaiNumberを使う
        //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす
        if (0<= T0002M_kyotuHensu.meidaiNumber&& T0002M_kyotuHensu.meidaiNumber <=5) 
        {
            if (kakkoMeidaiNumber != T0002M_kyotuHensu.meidaiNumber) 
            {
                int i = 0;
                foreach (RectTransform unko in this.gameObject.transform) 
                {
                    if (i == T0002M_kyotuHensu.meidaiNumber) 
                    {
                       unko.anchoredPosition= new Vector3(0, 0, 0);
                    } 
                    else 
                    {
                        unko.anchoredPosition= new Vector3(0, 1200, 0);
                    }
                    i++;
                }
            }
        }
    }
}
