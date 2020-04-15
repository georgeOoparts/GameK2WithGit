using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_41_KJP_3RRHenka : MonoBehaviour {
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

    //public GameObject KJP_3TextA;
    //public GameObject KJP_3TextB;
    //public GameObject KJP_3TextC;
    //public GameObject KJP_3TextD;

    //public GameObject KJP_3Line1;
    //public GameObject KJP_3Line2;
    public GameObject KJP_3Line3;

    //public GameObject KJP_3StLine1;
    //public GameObject KJP_3StLine2;
    public GameObject KJP_3StLine3;

    public GameObject KJP_3Point1;
    //public GameObject KJP_3Point2;
    //public GameObject KJP_3Point3;
    //public GameObject KJP_3Point4;

    public GameObject KJP_3StPoint1;
    //public GameObject KJP_3StPoint2;
    //public GameObject KJP_3StPoint3;
    //public GameObject KJP_3StPoint4;

    public GameObject KJP_3Circle;
    public GameObject KJP_3StCircle;

    //private Renderer rrKJP_3TextA;
    //private Renderer rrKJP_3TextB;
    //private Renderer rrKJP_3TextC;
    //private Renderer rrKJP_3TextD;

    //private Renderer rrKJP_3Line1;
    //private Renderer rrKJP_3Line2;
    private Renderer rrKJP_3Line3;

    //private Renderer rrKJP_3StLine1;
    //private Renderer rrKJP_3StLine2;
    private Renderer rrKJP_3StLine3;

    private Renderer rrKJP_3Point1;
    //private Renderer rrKJP_3Point2;
    //private Renderer rrKJP_3Point3;
    //private Renderer rrKJP_3Point4;

    private Renderer rrKJP_3StPoint1;
    //private Renderer rrKJP_3StPoint2;
    //private Renderer rrKJP_3StPoint3;
    //private Renderer rrKJP_3StPoint4;

    private Renderer rrKJP_3Circle;
    private Renderer rrKJP_3StCircle;


    void Start() {
        //rrKJP_3TextA = KJP_3TextA.GetComponent<Renderer>();
        //rrKJP_3TextB = KJP_3TextB.GetComponent<Renderer>();
        //rrKJP_3TextC = KJP_3TextC.GetComponent<Renderer>();
        //rrKJP_3TextD = KJP_3TextD.GetComponent<Renderer>();

        //rrKJP_3Line1 = KJP_3Line1.GetComponent<Renderer>();
        //rrKJP_3Line2 = KJP_3Line2.GetComponent<Renderer>();
        rrKJP_3Line3 = KJP_3Line3.GetComponent<Renderer>();

        //rrKJP_3StLine1 = KJP_3StLine1.GetComponent<Renderer>();
        //rrKJP_3StLine2 = KJP_3StLine2.GetComponent<Renderer>();
        rrKJP_3StLine3 = KJP_3StLine3.GetComponent<Renderer>();

        rrKJP_3Point1 = KJP_3Point1.GetComponent<Renderer>();
        //rrKJP_3Point2 = KJP_3Point2.GetComponent<Renderer>();
        //rrKJP_3Point3 = KJP_3Point3.GetComponent<Renderer>();
        //rrKJP_3Point4 = KJP_3Point4.GetComponent<Renderer>();

        rrKJP_3StPoint1 = KJP_3StPoint1.GetComponent<Renderer>();
        //rrKJP_3StPoint2 = KJP_3StPoint2.GetComponent<Renderer>();
        //rrKJP_3StPoint3 = KJP_3StPoint3.GetComponent<Renderer>();
        //rrKJP_3StPoint4 = KJP_3StPoint4.GetComponent<Renderer>();

        rrKJP_3Circle = KJP_3Circle.GetComponent<Renderer>();
        rrKJP_3StCircle = KJP_3StCircle.GetComponent<Renderer>();
    }
    //リセット表示を全部消すメソッド　kyotu.rrcount------resetW-----------------------
    private void reset() {
        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;

        //gameobjectを見えなくする
        //＞line：gameobjectを見えなくする
        //rrKJP_3TextA.enabled = false;
        //rrKJP_3TextB.enabled = false;
        //rrKJP_3TextC.enabled = false;
        //rrKJP_3TextD.enabled = false;

        //rrKJP_3Line1.enabled = false;
        //rrKJP_3Line2.enabled = false;
        rrKJP_3Line3.enabled = false;

        //rrKJP_3StLine1.enabled = false;
        //rrKJP_3StLine2.enabled = false;
        rrKJP_3StLine3.enabled = false;

        rrKJP_3Point1.enabled = false;
        //rrKJP_3Point2.enabled = false;
        //rrKJP_3Point3.enabled = false;
        //rrKJP_3Point4.enabled = false;

        rrKJP_3StPoint1.enabled = false;
        //rrKJP_3StPoint2.enabled = false;
        //rrKJP_3StPoint3.enabled = false;
        //rrKJP_3StPoint4.enabled = false;

        rrKJP_3Circle.enabled = false;
        rrKJP_3StCircle.enabled = false;

    }
    void Update() {
        henka(kyotu.rrCount);
        //Debug.Log("KJP_3RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
    
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count) {//henkaW
        //m1_3のときのみ実行
        if (kyotu.mojiSwitch == 1 & kyotu.MCount == 2) {
            if (count == 0) {
                reset();
            } else if (count == 1) {//henka1
                reset();
                rrKJP_3Point1.enabled = true;

                rrKJP_3StPoint1.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 2) {//henka2
                reset();
                rrKJP_3Point1.enabled = true;

                //rrKJP_3StPoint1.enabled = kyotuEla.tenmetuOnOff;

                rrKJP_3Line3.enabled = true;

                rrKJP_3StLine3.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 3) {//henka3
                reset();
                rrKJP_3Point1.enabled = true;

                //rrKJP_3StPoint1.enabled = kyotuEla.tenmetuOnOff;

                rrKJP_3Line3.enabled = true;

                //rrKJP_3StLine3.enabled = kyotuEla.tenmetuOnOff;

                rrKJP_3Circle.enabled = true;

                rrKJP_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 4) {//henka4
                reset();
                rrKJP_3Point1.enabled = true;

                //rrKJP_3StPoint1.enabled = kyotuEla.tenmetuOnOff;

                rrKJP_3Line3.enabled = true;

                //rrKJP_3StLine3.enabled = kyotuEla.tenmetuOnOff;

                rrKJP_3Circle.enabled = true;

                //rrKJP_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            }
        }
    }
}
