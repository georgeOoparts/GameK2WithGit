using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_37_KJP_1RRHenka : MonoBehaviour {
    //M1_5RRにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    ////MColor0Blue_point;
    //public Material MColor0;
    ////MColor1Yellow_line;
    //public Material MColor1;
    ////MColor2Green_kaku;
    //public Material MColor2;
    ////MColor3Red_St1;
    //public Material MColor3;
    ////MColor4Orange_St2
    //public Material MColor4;
    ////MColor5Purple_same1;
    //public Material MColor5;
    ////MColor6Pink_same2
    //public Material MColor6;
    ////MColor7DarkPurple_same3
    //public Material MColor7;
    ////MColor8White_same4
    //public Material MColor8;
    ////MColor9Black_same5
    //public Material MColor9;

    public GameObject KJP_Line1;

    public GameObject KJP_StLine1;

    public GameObject KJP_Point1;
    public GameObject KJP_Point2;

    public GameObject KJP_StPoint1;
    public GameObject KJP_StPoint2;

    private Renderer rrKJP_Line1;

    private Renderer rrKJP_StLine1;

    private Renderer rrKJP_Point1;
    private Renderer rrKJP_Point2;

    private Renderer rrKJP_StPoint1;
    private Renderer rrKJP_StPoint2;

    void Start() {
        rrKJP_Line1 = KJP_Line1.GetComponent<Renderer>();

        rrKJP_StLine1 = KJP_StLine1.GetComponent<Renderer>();

        rrKJP_Point1 = KJP_Point1.GetComponent<Renderer>();
        rrKJP_Point2 = KJP_Point2.GetComponent<Renderer>();

        rrKJP_StPoint1 = KJP_StPoint1.GetComponent<Renderer>();
        rrKJP_StPoint2 = KJP_StPoint2.GetComponent<Renderer>();

    }

    //リセット表示を全部消すメソッド　kyotu.rrcount------resetW-----------------------
    private void reset() {
        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;

        //gameobjectを見えなくする
        //＞line：gameobjectを見えなくする

        rrKJP_Line1.enabled = false;

        rrKJP_StLine1.enabled = false;

        rrKJP_Point1.enabled = false;
        rrKJP_Point2.enabled = false;

        rrKJP_StPoint1.enabled = false;
        rrKJP_StPoint2.enabled = false;

    }
    void Update() {
        henka(kyotu.rrCount);
        //Debug.Log("KJP_1RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count) {//henkaW
        //m1_3のときのみ実行
        if (kyotu.mojiSwitch == 1 & kyotu.MCount == 0) {
            if (count == 0) {
                reset();
            } 
            else if (count == 1) //henka1
            {
                reset();
                rrKJP_Point2.enabled = true;
                rrKJP_StPoint2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 2) //henka2
            {
                reset();
                rrKJP_Point1.enabled = true;
                rrKJP_StPoint1.enabled = kyotuEla.tenmetuOnOff;

                rrKJP_Point2.enabled = true;
                //rrKJP_StPoint2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 3) //henka3
            {
                reset();
                rrKJP_Point1.enabled = true;
                //rrKJP_StPoint1.enabled = kyotuEla.tenmetuOnOff;

                rrKJP_Point2.enabled = true;
                //rrKJP_StPoint2.enabled = kyotuEla.tenmetuOnOff;

                rrKJP_Line1.enabled = true;
                rrKJP_StLine1.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 4) //henka4
            {
                reset();
                rrKJP_Point1.enabled = true;
                //rrKJP_StPoint1.enabled = kyotuEla.tenmetuOnOff;

                rrKJP_Point2.enabled = true;
                //rrKJP_StPoint2.enabled = kyotuEla.tenmetuOnOff;

                rrKJP_Line1.enabled = true;
                rrKJP_StLine1.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 5) //henka5
            {
                reset();
                rrKJP_Point1.enabled = true;
                //rrKJP_StPoint1.enabled = kyotuEla.tenmetuOnOff;

                rrKJP_Point2.enabled = true;
                //rrKJP_StPoint2.enabled = kyotuEla.tenmetuOnOff;

                rrKJP_Line1.enabled = true;
                //rrKJP_StLine1.enabled = kyotuEla.tenmetuOnOff;
            }
        }
    }
}