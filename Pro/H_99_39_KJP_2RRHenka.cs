using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_39_KJP_2RRHenka : MonoBehaviour {
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

    public GameObject KJP_2Line1;
    public GameObject KJP_2Line2;

    public GameObject KJP_2StLine1;
    public GameObject KJP_2StLine2;

    //public GameObject KJP_2Point1;
    //public GameObject KJP_2Point2;
    //public GameObject KJP_2Point3;

    //public GameObject KJP_2StPoint1;
    //public GameObject KJP_2StPoint2;
    //public GameObject KJP_2StPoint3;

    private Renderer rrKJP_2Line1;
    private Renderer rrKJP_2Line2;

    private Renderer rrKJP_2StLine1;
    private Renderer rrKJP_2StLine2;

    //private Renderer rrKJP_2Point1;
    //private Renderer rrKJP_2Point2;
    //private Renderer rrKJP_2Point3;

    //private Renderer rrKJP_2StPoint1;
    //private Renderer rrKJP_2StPoint2;
    //private Renderer rrKJP_2StPoint3;

    void Start() {
        rrKJP_2Line1 = KJP_2Line1.GetComponent<Renderer>();
        rrKJP_2Line2 = KJP_2Line2.GetComponent<Renderer>();

        rrKJP_2StLine1 = KJP_2StLine1.GetComponent<Renderer>();
        rrKJP_2StLine2 = KJP_2StLine2.GetComponent<Renderer>();

        //rrKJP_2Point1 = KJP_2Point1.GetComponent<Renderer>();
        //rrKJP_2Point2 = KJP_2Point2.GetComponent<Renderer>();
        //rrKJP_2Point3 = KJP_2Point3.GetComponent<Renderer>();

        //rrKJP_2StPoint1 = KJP_2StPoint1.GetComponent<Renderer>();
        //rrKJP_2StPoint2 = KJP_2StPoint2.GetComponent<Renderer>();
        //rrKJP_2StPoint3 = KJP_2StPoint3.GetComponent<Renderer>();
    }
    //リセット表示を全部消すメソッド　kyotu.rrcount------resetW-----------------------
    private void reset() {
        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;

        //gameobjectを見えなくする
        //＞line：gameobjectを見えなくする
        rrKJP_2Line1.enabled = false;
        rrKJP_2Line2.enabled = false;

        rrKJP_2StLine1.enabled = false;
        rrKJP_2StLine2.enabled = false;

        //rrKJP_2Point1.enabled = false;
        //rrKJP_2Point2.enabled = false;
        //rrKJP_2Point3.enabled = false;

        //rrKJP_2StPoint1.enabled = false;
        //rrKJP_2StPoint2.enabled = false;
        //rrKJP_2StPoint3.enabled = false;
    }
    // Update is called once per frame
    void Update() {
        henka(kyotu.rrCount);
        //Debug.Log("KJP_2RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);
    }
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count) {//henkaW
        //m1_3のときのみ実行
        if (kyotu.mojiSwitch == 1 & kyotu.MCount == 1) {
            if (count == 0) {
                reset();
            }else if (count == 1) {
                reset();
                rrKJP_2Line1.enabled = true;
                rrKJP_2StLine1.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 2) {
                reset();
                rrKJP_2Line1.enabled = true;
                rrKJP_2Line2.enabled = true;

                //rrKJP_2StLine1.enabled = kyotuEla.tenmetuOnOff;
                rrKJP_2StLine2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 3) {
                reset();
                rrKJP_2Line1.enabled = true;
                rrKJP_2Line2.enabled = true;

                //rrKJP_2StLine1.enabled = kyotuEla.tenmetuOnOff;
                //rrKJP_2StLine2.enabled = kyotuEla.tenmetuOnOff;
            }
        }
    }
}
