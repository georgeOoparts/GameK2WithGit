using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_35_TD1_15RRHenka : MonoBehaviour {
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

    //public GameObject TD1_15TextA;
    //public GameObject TD1_15TextB;
    //public GameObject TD1_15TextC;
    //public GameObject TD1_15TextD;

    public GameObject TD1_15Line1;
    public GameObject TD1_15Line2;
    public GameObject TD1_15Line3;

    public GameObject TD1_15StLine1;
    public GameObject TD1_15StLine2;
    public GameObject TD1_15StLine3;

    public GameObject TD1_15Point1;
    public GameObject TD1_15Point2;
    public GameObject TD1_15Point3;
    public GameObject TD1_15Point4;

    public GameObject TD1_15StPoint1;
    public GameObject TD1_15StPoint2;
    public GameObject TD1_15StPoint3;
    public GameObject TD1_15StPoint4;

    public GameObject TD1_15Circle;
    public GameObject TD1_15StCircle;

    //private Renderer rrTD1_15TextA;
    //private Renderer rrTD1_15TextB;
    //private Renderer rrTD1_15TextC;
    //private Renderer rrTD1_15TextD;

    private Renderer rrTD1_15Line1;
    private Renderer rrTD1_15Line2;
    private Renderer rrTD1_15Line3;

    private Renderer rrTD1_15StLine1;
    private Renderer rrTD1_15StLine2;
    private Renderer rrTD1_15StLine3;

    private Renderer rrTD1_15Point1;
    private Renderer rrTD1_15Point2;
    private Renderer rrTD1_15Point3;
    private Renderer rrTD1_15Point4;

    private Renderer rrTD1_15StPoint1;
    private Renderer rrTD1_15StPoint2;
    private Renderer rrTD1_15StPoint3;
    private Renderer rrTD1_15StPoint4;

    private Renderer rrTD1_15Circle;
    private Renderer rrTD1_15StCircle;


    void Start() {
        //rrTD1_15TextA = TD1_15TextA.GetComponent<Renderer>();
        //rrTD1_15TextB = TD1_15TextB.GetComponent<Renderer>();
        //rrTD1_15TextC = TD1_15TextC.GetComponent<Renderer>();
        //rrTD1_15TextD = TD1_15TextD.GetComponent<Renderer>();

        rrTD1_15Line1 = TD1_15Line1.GetComponent<Renderer>();
        rrTD1_15Line2 = TD1_15Line2.GetComponent<Renderer>();
        rrTD1_15Line3 = TD1_15Line3.GetComponent<Renderer>();

        rrTD1_15StLine1 = TD1_15StLine1.GetComponent<Renderer>();
        rrTD1_15StLine2 = TD1_15StLine2.GetComponent<Renderer>();
        rrTD1_15StLine3 = TD1_15StLine3.GetComponent<Renderer>();

        rrTD1_15Point1 = TD1_15Point1.GetComponent<Renderer>();
        rrTD1_15Point2 = TD1_15Point2.GetComponent<Renderer>();
        rrTD1_15Point3 = TD1_15Point3.GetComponent<Renderer>();
        rrTD1_15Point4 = TD1_15Point4.GetComponent<Renderer>();

        rrTD1_15StPoint1 = TD1_15StPoint1.GetComponent<Renderer>();
        rrTD1_15StPoint2 = TD1_15StPoint2.GetComponent<Renderer>();
        rrTD1_15StPoint3 = TD1_15StPoint3.GetComponent<Renderer>();
        rrTD1_15StPoint4 = TD1_15StPoint4.GetComponent<Renderer>();

        rrTD1_15Circle = TD1_15Circle.GetComponent<Renderer>();
        rrTD1_15StCircle = TD1_15StCircle.GetComponent<Renderer>();
    }
    //リセット表示を全部消すメソッド　kyotu.rrcount------resetW-----------------------
    private void reset() {
        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;

        //gameobjectを見えなくする
        //＞line：gameobjectを見えなくする
        //rrTD1_15TextA.enabled = false;
        //rrTD1_15TextB.enabled = false;
        //rrTD1_15TextC.enabled = false;
        //rrTD1_15TextD.enabled = false;

        rrTD1_15Line1.enabled = false;
        rrTD1_15Line2.enabled = false;
        rrTD1_15Line3.enabled = false;

        rrTD1_15StLine1.enabled = false;
        rrTD1_15StLine2.enabled = false;
        rrTD1_15StLine3.enabled = false;

        rrTD1_15Point1.enabled = false;
        rrTD1_15Point2.enabled = false;
        rrTD1_15Point3.enabled = false;
        rrTD1_15Point4.enabled = false;

        rrTD1_15StPoint1.enabled = false;
        rrTD1_15StPoint2.enabled = false;
        rrTD1_15StPoint3.enabled = false;
        rrTD1_15StPoint4.enabled = false;

        rrTD1_15Circle.enabled = false;
        rrTD1_15StCircle.enabled = false;

    }
    // Update is called once per frame
    void Update() {
        henka(kyotu.rrCount);
        //Debug.Log("TD1_15RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);
    }
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count) {//henkaW
        //m1_3のときのみ実行
        if (kyotu.mojiSwitch == 2 & kyotu.MCount == 1) {
            if (count == 0) {
                reset();
            } else if (count == 1) //henka1
              {
                reset();
                rrTD1_15Circle.enabled = true;
            } else if (count == 2) //henka2
               {
                reset();
                rrTD1_15Circle.enabled = true;
                rrTD1_15StCircle.enabled =kyotuEla.tenmetuOnOff;
            } else if (count == 3) //henka3
               {
                reset();
                rrTD1_15Circle.enabled = true;
                rrTD1_15StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 4) //henka4
               {
                reset();
                rrTD1_15Circle.enabled = true;
                //rrTD1_15StCircle.enabled = kyotuEla.tenmetuOnOff;

                rrTD1_15Point1.enabled = true;
                //rrTD1_15Point2.enabled = true;

                rrTD1_15StPoint1.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 5) //henka5
                {
                reset();
                rrTD1_15Circle.enabled = true;
                //rrTD1_15StCircle.enabled = kyotuEla.tenmetuOnOff;

                rrTD1_15Point1.enabled = true;
                rrTD1_15Point2.enabled = true;

                //rrTD1_15StPoint1.enabled = kyotuEla.tenmetuOnOff;
                rrTD1_15StPoint2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 6) //henka6
                 {
                reset();
                rrTD1_15Circle.enabled = true;
                //rrTD1_15StCircle.enabled = kyotuEla.tenmetuOnOff;

                rrTD1_15Point1.enabled = true;
                rrTD1_15Point2.enabled = true;

                //rrTD1_15StPoint1.enabled = kyotuEla.tenmetuOnOff;
                //rrTD1_15StPoint2.enabled = kyotuEla.tenmetuOnOff;

                rrTD1_15Line1.enabled = true;

                rrTD1_15StLine1.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 7) //henka7
                 {
                reset();
                rrTD1_15Circle.enabled = true;
                //rrTD1_15StCircle.enabled = kyotuEla.tenmetuOnOff;

                rrTD1_15Point1.enabled = true;
                rrTD1_15Point2.enabled = true;

                //rrTD1_15StPoint1.enabled = kyotuEla.tenmetuOnOff;
                //rrTD1_15StPoint2.enabled = kyotuEla.tenmetuOnOff;

                rrTD1_15Line1.enabled = true;

                rrTD1_15StLine1.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 8) //henka8
                  {
                reset();
                rrTD1_15Circle.enabled = true;
                //rrTD1_15StCircle.enabled = kyotuEla.tenmetuOnOff;

                rrTD1_15Point1.enabled = true;
                rrTD1_15Point2.enabled = true;
                rrTD1_15Point3.enabled = true;
                rrTD1_15Point4.enabled = true;
                //rrTD1_15StPoint1.enabled = kyotuEla.tenmetuOnOff;
                //rrTD1_15StPoint2.enabled = kyotuEla.tenmetuOnOff;

                rrTD1_15Line1.enabled = true;
                rrTD1_15Line2.enabled = true;
                rrTD1_15Line3.enabled = true;

                rrTD1_15StLine1.enabled = kyotuEla.tenmetuOnOff;
                rrTD1_15StLine2.enabled = kyotuEla.tenmetuOnOff;
                rrTD1_15StLine3.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 9) //henka9
                   {
                reset();
                rrTD1_15Circle.enabled = true;
                //rrTD1_15StCircle.enabled = kyotuEla.tenmetuOnOff;

                rrTD1_15Point1.enabled = true;
                rrTD1_15Point2.enabled = true;
                rrTD1_15Point3.enabled = true;
                rrTD1_15Point4.enabled = true;
                //rrTD1_15StPoint1.enabled = kyotuEla.tenmetuOnOff;
                //rrTD1_15StPoint2.enabled = kyotuEla.tenmetuOnOff;

                rrTD1_15Line1.enabled = true;
                rrTD1_15Line2.enabled = true;
                rrTD1_15Line3.enabled = true;

                //rrTD1_15StLine1.enabled = kyotuEla.tenmetuOnOff;
                //rrTD1_15StLine2.enabled = kyotuEla.tenmetuOnOff;
                //rrTD1_15StLine3.enabled = kyotuEla.tenmetuOnOff;
            }
        }
    }
}
