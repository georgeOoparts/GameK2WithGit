using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_01_kyoutuHensu : MonoBehaviour
{
    //共通で使い呼び出されるオブジェ、変数はここでかんりするぜ。
    //k5_3_1: gameobject(メソッド、変数)を外部から呼び出す。
    //ヒエでアタッチ

    //elapseのためだけにstart関数を使い、
    //からのオブジェSWにこのプログラムをアタッチ


    //文字の内容と強調するプログラムH_99_13_mojiHonbanで使う
    //公理、公準、定義、meidaiのどの文字を表示させるかを決める
    //どのプログラムで数が増える？>canvasworld>textpanel>H_99_13_mojiHonban(右クリックで増える)
    //公理:0,公準:1,定義:2,meidai:3
    public int mojiSwitch = 3;


    //今、対象としているmeidaiを0から対応させる-----------
    //use　H_99_13_mojiHonban
    //どのプログラムで数が増える？>canvasworld>textpanel>H_99_13_mojiHonban(右クリックで増える)

    public int MCount = 0;

    //rrの何ターン目かをカウントする共通変数 -----------

    //use　H_99_16_sTriangleHenka、H_99_13_mojiHonban    
    //どのプログラムで数が増える？＞canvasworld>textpanel>H_99_13_mojiHonban（左クリック）
    //どのプログラムで減る＞canvasworld>textpanel>H_99_13_mojiHonban（右クリック0にリセット）

    public int rrCount=0;


    ////maincameraがある位置を1～３で表す。----------------------
    //public int mainCameraPosi = 0;


    ////meidaiの何がライン2（フラッグ図）にくるか決める変数
    //public int meidaiHensu = 1;

    ////cameraTakasaY：カメラの真ん中から上半分のyジクの距離
    //public float cameraTakasaY = 5;
    ////upSpace：カメラの上から一番上のオブジェまでの距離
    //public float upSpace = 0.5f;

    ////ボタンタッチ移動と、横スワイプ移動がバグを起こさないため
    ////ボタン移動しているかどうかを表すへんすう。
    //public bool bottomMove = false;



    ////マズ　ライン１の目次のオブジェを定める
    //public GameObject mokuji;

    //public GameObject p1_1;
    //public GameObject p1_2;
    //public GameObject p1_3;
    //public GameObject p1_4;
    //public GameObject p1_5;
    //public GameObject p1_6;

    ////マズ　ライン2のmeidaiのオブジェを定める
    //public GameObject meidai;

    ////マズ　ライン2のmeidai1_1～meidai1_6のオブジェを定める
    //public GameObject meidai1_1;
    //public GameObject meidai1_2;
    //public GameObject meidai1_3;
    //public GameObject meidai1_4;
    //public GameObject meidai1_5;
    //public GameObject meidai1_6;

    ////マズ　ライン2のフラグ１のオブジェを定める
    //public GameObject p1_1_1;
    //public GameObject p1_1_2;
    //public GameObject p1_1_3;
    //public GameObject p1_1_4;
    //public GameObject p1_1_5;
    //public GameObject p1_1_6;

    ////マズ　ライン2のフラグ2のオブジェを定める
    //public GameObject p1_2_1;
    //public GameObject p1_2_2;
    //public GameObject p1_2_3;
    //public GameObject p1_2_4;
    //public GameObject p1_2_5;
    //public GameObject p1_2_6;
    //public GameObject p1_2_7;
    //public GameObject p1_2_8;
    //public GameObject p1_2_9;

    ////マズ　ライン2のフラグ3のオブジェを定める
    //public GameObject p1_3_1;
    //public GameObject p1_3_2;
    //public GameObject p1_3_3;
    //public GameObject p1_3_4;
    //public GameObject p1_3_5;
    //public GameObject p1_3_6;

    ////マズ　ライン2のフラグ4のオブジェを定める
    //public GameObject p1_4_1;
    //public GameObject p1_4_2;
    //public GameObject p1_4_3;
    //public GameObject p1_4_4;

    ////マズ　ライン2のフラグ5のオブジェを定める
    //public GameObject p1_5_1;
    //public GameObject p1_5_2;
    //public GameObject p1_5_3;
    //public GameObject p1_5_4;
    //public GameObject p1_5_5;
    //public GameObject p1_5_6;
    //public GameObject p1_5_7;

    ////マズ　ライン2のフラグ6のオブジェを定める
    //public GameObject p1_6_1;
    //public GameObject p1_6_2;
    //public GameObject p1_6_3;
    //public GameObject p1_6_4;
    //public GameObject p1_6_5;
    //public GameObject p1_6_6;

    private void Update()
    {
        Debug.Log("kyoutuhensu::"+rrCount);
    }


}
