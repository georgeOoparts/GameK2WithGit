using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_29_M1_3RRHenka : MonoBehaviour {//atama
    //M1_3preにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    public Material color0;//blue
    public Material color1;//yellow
    public Material color3;//red
    public Material color8;//white

    //lineを当てはめる
    public GameObject M1_3LineAE;
    public GameObject M1_3LineSAE;

    public GameObject M1_3LineAB;
    public GameObject M1_3LineSAB;

    public GameObject M1_3LineAD;
    public GameObject M1_3LineSAD;

    //public GameObject M1_3LineEB;
    //public GameObject M1_3LineSEB;

    public GameObject M1_3LineC;
    public GameObject M1_3LineSC;

    //pointを当てはめる
    public GameObject M1_3PointA;
    public GameObject M1_3PointB;
    public GameObject M1_3PointD;
    public GameObject M1_3PointE;
    public GameObject M1_3PointF;

    //>強調pointを当てはめる
    public GameObject M1_3StPointA;
    public GameObject M1_3StPointB;
    public GameObject M1_3StPointD;
    public GameObject M1_3StPointE;
    public GameObject M1_3StPointF;

    //circleを当てはめる
    public GameObject M1_3Circle;
    public GameObject M1_3StCircle;

    //TEXTを当てはめる
    public GameObject M1_3TextA;
    public GameObject M1_3TextB;
    public GameObject M1_3TextC;
    public GameObject M1_3TextD;
    public GameObject M1_3TextE;
    public GameObject M1_3TextF;

    //renderer当てはめ
    //＞linerederer当てはめ
    private Renderer rrM1_3LineAE;
    private Renderer rrM1_3LineSAE;

    private Renderer rrM1_3LineAB;
    private Renderer rrM1_3LineSAB;

    private Renderer rrM1_3LineAD;
    private Renderer rrM1_3LineSAD;

    //private Renderer rrM1_3LineEB;
    //private Renderer rrM1_3LineSEB;

    private Renderer rrM1_3LineC;
    private Renderer rrM1_3LineSC;

    //＞＞point rederer当てはめ
    private Renderer rrM1_3PointA;
    private Renderer rrM1_3PointB;
    private Renderer rrM1_3PointD;
    private Renderer rrM1_3PointE;
    private Renderer rrM1_3PointF;
    //＞＞強調point rederer当てはめ
    private Renderer rrM1_3StPointA;
    private Renderer rrM1_3StPointB;
    private Renderer rrM1_3StPointD;
    private Renderer rrM1_3StPointE;
    private Renderer rrM1_3StPointF;

    //＞circle rederer当てはめ
    private Renderer rrM1_3Circle;
    private Renderer rrM1_3StCircle;

    //＞text rederer当てはめ
    private Renderer rrM1_3TextA;
    private Renderer rrM1_3TextB;
    private Renderer rrM1_3TextC;
    private Renderer rrM1_3TextD;
    private Renderer rrM1_3TextE;
    private Renderer rrM1_3TextF;

    void Start() {
        //gameobjectをredererに当てはめていく
        //＞line：gameobjectをredererに当てはめていく
        rrM1_3LineAE = M1_3LineAE.GetComponent<Renderer>();
        rrM1_3LineSAE = M1_3LineSAE.GetComponent<Renderer>();

        rrM1_3LineAB = M1_3LineAB.GetComponent<Renderer>();
        rrM1_3LineSAB = M1_3LineSAB.GetComponent<Renderer>();

        rrM1_3LineAD = M1_3LineAD.GetComponent<Renderer>();
        rrM1_3LineSAD = M1_3LineSAD.GetComponent<Renderer>();

        //rrM1_3LineEB = M1_3LineEB.GetComponent<Renderer>();
        //rrM1_3LineSEB = M1_3LineSEB.GetComponent<Renderer>();

        rrM1_3LineC = M1_3LineC.GetComponent<Renderer>();
        rrM1_3LineSC = M1_3LineSC.GetComponent<Renderer>();

        //＞point：gameobjectをredererに当てはめていく
        rrM1_3PointA = M1_3PointA.GetComponent<Renderer>();
        rrM1_3PointB = M1_3PointB.GetComponent<Renderer>();
        rrM1_3PointD = M1_3PointD.GetComponent<Renderer>();
        rrM1_3PointE = M1_3PointE.GetComponent<Renderer>();
        rrM1_3PointF = M1_3PointF.GetComponent<Renderer>();
        //＞＞強調point rederer当てはめ
        rrM1_3StPointA = M1_3StPointA.GetComponent<Renderer>();
        rrM1_3StPointB = M1_3StPointB.GetComponent<Renderer>();
        rrM1_3StPointD = M1_3StPointD.GetComponent<Renderer>();
        rrM1_3StPointE = M1_3StPointE.GetComponent<Renderer>();
        rrM1_3StPointF = M1_3StPointF.GetComponent<Renderer>();

        //＞circle：gameobjectをredererに当てはめていく
        rrM1_3Circle = M1_3Circle.GetComponent<Renderer>();
        rrM1_3StCircle = M1_3StCircle.GetComponent<Renderer>();

        //＞text：gameobjectをredererに当てはめていく
        rrM1_3TextA = M1_3TextA.GetComponent<Renderer>();
        rrM1_3TextB = M1_3TextB.GetComponent<Renderer>();
        rrM1_3TextC = M1_3TextC.GetComponent<Renderer>();
        rrM1_3TextD = M1_3TextD.GetComponent<Renderer>();
        rrM1_3TextE = M1_3TextE.GetComponent<Renderer>();
        rrM1_3TextF = M1_3TextF.GetComponent<Renderer>();
    }
    // Update is called once per frame
    void Update() {
        henka(kyotu.rrCount);
        //Debug.Log("M1_3RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
    //リセット表示を全部消すメソッド　kyotu.rrcount-----------------------------
    private void reset() {//resetw
        rrM1_3LineAD.material = color1;

        rrM1_3LineSAE.material = color3;

        rrM1_3LineC.material = color1;

        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;

        //gameobjectを見えなくする
        //＞line：gameobjectを見えなくする

        rrM1_3LineAE.enabled = false;
        rrM1_3LineSAE.enabled = false;

        rrM1_3LineAB.enabled = false;
        rrM1_3LineSAB.enabled = false;

        rrM1_3LineAD.enabled = false;
        rrM1_3LineSAD.enabled = false;

        //rrM1_3LineEB.enabled = false;
        //rrM1_3LineSEB.enabled = false;

        rrM1_3LineC.enabled = false;
        rrM1_3LineSC.enabled = false;

        //＞point：gameobjectを見えなくする
        rrM1_3PointA.enabled = false;
        rrM1_3PointB.enabled = false;
        rrM1_3PointD.enabled = false;
        rrM1_3PointE.enabled = false;
        rrM1_3PointF.enabled = false;
        //＞pointSt：gameobjectを見えなくする
        rrM1_3StPointA.enabled = false;
        rrM1_3StPointB.enabled = false;
        rrM1_3StPointD.enabled = false;
        rrM1_3StPointE.enabled = false;
        rrM1_3StPointF.enabled = false;

        ////＞circle：gameobjectを見えなくする
        rrM1_3Circle.enabled = false;
        rrM1_3StCircle.enabled = false;

        ////＞text：gameobjectを見えなくする
        rrM1_3TextA.enabled = false;
        rrM1_3TextB.enabled = false;
        rrM1_3TextC.enabled = false;
        rrM1_3TextD.enabled = false;
        rrM1_3TextE.enabled = false;
        rrM1_3TextF.enabled = false;
    }
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count) {
        //m1_3のときのみ実行
        if (kyotu.mojiSwitch == 3 & kyotu.MCount == 2 & count >=7) {
            if (count==7) //henka7w
            {
                reset();
                rrM1_3LineSAE.material = color1;
            }
            else if (count == 8) {
                reset();
                rrM1_3LineSAE.material = color1;
                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;

                rrM1_3LineAB.enabled = true;

                rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 9) {
                reset();
                rrM1_3LineSAE.material = color1;
                rrM1_3LineC.material = color1;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 10) {//henka10w
                reset();
                //rrM1_3LineC.material = color1;

                rrM1_3LineSAE.material = color1;
                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;

                rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 11) {
                reset();
                //rrM1_3LineC.material = color1;

                rrM1_3LineSAE.material = color1;
                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;

                rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 12) {
                reset();
                rrM1_3LineSAE.material = color1;
                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;

                rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 13) {//henka13w
                reset();
                rrM1_3LineSAE.material = color1;
                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;

                rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 14) {//henka14w
                reset();
                rrM1_3LineSAE.material = color1;
                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;

                rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 15) {//henka15w
                reset();
                rrM1_3LineSAE.material = color1;
                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3LineSAB.enabled = true;

                rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 16) {//henka16w
                reset();
                rrM1_3LineSAE.material = color1;
                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3LineSAB.enabled = true;

                rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;

                rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 17) {//henka17w
                reset();
                rrM1_3LineSAE.material = color1;
                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;
                
                rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 18) {//henka18w
                reset();
                rrM1_3LineSAE.material = color1;
                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;

                rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 19) {//henka19w
                reset();
                rrM1_3LineSAE.material = color1;
                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;

                rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 20) {//henka20w
                reset();
                rrM1_3LineSAE.material = color1;
                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;

                rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 21) {//henka21w
                reset();
                rrM1_3LineSAE.material = color1;
                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3StPointA.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 22) {//henka22w
                reset();
                rrM1_3LineSAE.material = color1;
                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                
                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 23) {//henka23w
                reset();
                rrM1_3LineSAE.material = color1;
                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;

                rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 24) {//henka24w
                reset();
                rrM1_3LineSAE.material = color1;
                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 25) {//henka25w
                reset();
                rrM1_3LineSAE.material = color1;
                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 26) {//henka26w
                reset();
                rrM1_3LineSAE.material = color1;
                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 27) {//henka27w
                reset();
                rrM1_3LineSAE.material = color1;
                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 28) {//henka28w
                reset();
                rrM1_3LineSAE.material = color1;
                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;

                rrM1_3Circle.enabled = true;

                rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 29) {//henka29w
                reset();
                rrM1_3LineSAE.material = color1;
                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                
                rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 30) {//henka30w
                reset();
                rrM1_3LineSAE.material = color1;
                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;

                rrM1_3Circle.enabled = true;

                rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 31) {//henka31w
                reset();
                rrM1_3LineSAE.material = color3;//red

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 32) {//henka32w
                reset();
                rrM1_3LineSAE.material = color1;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3LineSAE.enabled = true;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 33) {//henka33w
                reset();

                rrM1_3LineAE.material =color8;
                rrM1_3LineAD.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAE.enabled = true;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 34) {//henka34w
                reset();
                rrM1_3LineAE.material = color8;
                rrM1_3LineAD.material = color8;
                //rrM1_3LineSAE.material = color0;
                //rrM1_3LineSAE.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAE.enabled = true;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 35) {//henka35w
                reset();

                rrM1_3LineAE.material = color8;
                rrM1_3LineAD.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAE.enabled = true;

                rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 36) {//henka36w
                reset();

                rrM1_3LineAE.material = color8;
                rrM1_3LineAD.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAE.enabled = true;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3LineSC.enabled = true;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 37) {//henka37w
                reset();

                rrM1_3LineAE.material = color8;
                rrM1_3LineAD.material = color8;
                rrM1_3LineC.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAE.enabled = true;

                rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSC.enabled = true;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 38) {//henka38w
                reset();

                rrM1_3LineAE.material = color8;
                rrM1_3LineAD.material = color8;
                rrM1_3LineC.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAE.enabled = true;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSC.enabled = true;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 39) {//henka39w
                reset();

                rrM1_3LineAE.material = color8;
                rrM1_3LineAD.material = color8;
                rrM1_3LineC.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAE.enabled = true;

                rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSC.enabled = true;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 40) {//henka40w
                reset();

                rrM1_3LineAE.material = color8;
                rrM1_3LineAD.material = color8;
                rrM1_3LineC.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAE.enabled = true;

                rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSC.enabled = true;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 41) {//henka41w
                reset();

                rrM1_3LineAE.material = color8;
                rrM1_3LineAD.material = color8;
                rrM1_3LineC.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3LineSAE.enabled = true;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3LineSC.enabled = true;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 42) {//henka42w
                reset();

                rrM1_3LineAE.material = color8;
                rrM1_3LineAD.material = color8;
                rrM1_3LineC.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAE.enabled = true;

                rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSC.enabled = true;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 43) {//henka43w
                reset();

                rrM1_3LineAE.material = color8;
                rrM1_3LineAD.material = color8;
                rrM1_3LineC.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAE.enabled = true;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSC.enabled = true;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 44) {//henka44w
                reset();

                rrM1_3LineAE.material = color8;
                rrM1_3LineAD.material = color8;
                rrM1_3LineC.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3LineSAE.enabled = true;

                rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSC.enabled = true;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 45) {//henka45w
                reset();

                rrM1_3LineAE.material = color8;
                rrM1_3LineAD.material = color8;
                rrM1_3LineC.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAE.enabled = true;

                rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSC.enabled = true;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 46) {//henka46w
                reset();

                rrM1_3LineAE.material = color8;
                rrM1_3LineAD.material = color8;
                rrM1_3LineC.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAE.enabled = true;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSC.enabled = true;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 47) {//henka47w
                reset();

                rrM1_3LineAE.material = color8;
                rrM1_3LineAD.material = color8;
                rrM1_3LineC.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                //rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAE.enabled = true;

                rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSC.enabled = true;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 48) {//henka48w
                reset();

                rrM1_3LineAE.material = color8;
                rrM1_3LineAD.material = color8;
                rrM1_3LineC.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                //rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAE.enabled = true;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSC.enabled = true;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 49) {//henka49w
                reset();

                rrM1_3LineAE.material = color8;
                rrM1_3LineAD.material = color8;
                rrM1_3LineC.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                //rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAE.enabled = true;

                rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSC.enabled = true;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 50) {//henka50w
                reset();

                rrM1_3LineAE.material = color8;
                rrM1_3LineAD.material = color8;
                rrM1_3LineC.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAE.enabled = true;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSC.enabled = true;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 51) {//henka51w
                reset();

                rrM1_3LineAE.material = color8;
                rrM1_3LineAD.material = color8;
                rrM1_3LineC.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_3LineSAE.enabled = true;

                rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSC.enabled = true;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 52) {//henka52w
                reset();

                rrM1_3LineAE.material = color8;
                rrM1_3LineAD.material = color8;
                rrM1_3LineC.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAE.enabled = true;

                rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSC.enabled = true;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 53) {//henka53w
                reset();

                rrM1_3LineAE.material = color8;
                rrM1_3LineAD.material = color8;
                rrM1_3LineC.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                //rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAE.enabled = true;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSC.enabled = true;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 54) {//henka54w
                reset();

                rrM1_3LineAE.material = color8;
                rrM1_3LineAD.material = color8;
                rrM1_3LineC.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAE.enabled = true;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSC.enabled = true;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 55) {//henka55w
                reset();

                rrM1_3LineAE.material = color8;
                rrM1_3LineAD.material = color8;
                rrM1_3LineC.material = color8;

                rrM1_3TextA.enabled = true;
                rrM1_3TextB.enabled = true;
                rrM1_3TextC.enabled = true;
                rrM1_3TextD.enabled = true;
                rrM1_3TextE.enabled = true;
                rrM1_3TextF.enabled = true;

                rrM1_3PointA.enabled = true;
                rrM1_3PointB.enabled = true;
                rrM1_3PointD.enabled = true;
                rrM1_3PointE.enabled = true;
                rrM1_3PointF.enabled = true;

                rrM1_3LineAB.enabled = true;
                rrM1_3LineC.enabled = true;
                rrM1_3LineAD.enabled = true;
                rrM1_3LineAE.enabled = true;

                rrM1_3Circle.enabled = true;

                //rrM1_3StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3StPointA.enabled = true;

                //rrM1_3LineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAB.enabled = true;

                //rrM1_3LineSAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAD.enabled = true;

                //rrM1_3LineSAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSAE.enabled = true;

                //rrM1_3LineSC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3LineSC.enabled = true;

                //rrM1_3StCircle.enabled = kyotuEla.tenmetuOnOff;
            }
        }
    }
}