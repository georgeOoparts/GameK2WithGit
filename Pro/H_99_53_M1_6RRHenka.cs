using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shapes2D;//0019_99_1：shape2dで色をスクリプトから変更する


public class H_99_53_M1_6RRHenka : MonoBehaviour
{
    //M1_5RRにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------
    //atama
    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    public Material StLineNewm3red;
    public Material Line1NewM1Yellow;
    public Material Line2NewM10DarkBlue;
    public Material Line3NewM7DarkPurple;
    public Material Line4NewM8White;
    public Material Line5NewM9Black;
    public Material PointNewm12MidGreen;

    //public Material MColor0;
    //public Material MColor1;
    //public Material MColor2;
    //public Material MColor3;
    //public Material MColor4;
    //public Material MColor5;
    //public Material MColor6;
    //public Material MColor7;
    //public Material MColor8;
    //public Material MColor9;

    public GameObject M1_6TextA;
    public GameObject M1_6TextB;
    public GameObject M1_6TextC;
    public GameObject M1_6TextD;

    public GameObject M1_6LineAB;
    public GameObject M1_6LineBC;
    public GameObject M1_6LineAC;
    public GameObject M1_6LineCD;
    //public GameObject M1_6LineAD;
    public GameObject M1_6LineBD;

    public GameObject M1_6StLineAB;
    public GameObject M1_6StLineBC;
    public GameObject M1_6StLineAC;
    public GameObject M1_6StLineCD;
    //public GameObject M1_6StLineAD;
    public GameObject M1_6StLineBD;

    public GameObject M1_6PointA;
    public GameObject M1_6PointB;
    public GameObject M1_6PointC;
    public GameObject M1_6PointD;

    public GameObject M1_6StPointA;
    public GameObject M1_6StPointB;
    public GameObject M1_6StPointC;
    public GameObject M1_6StPointD;

    public GameObject M1_6kakuABC;
    public GameObject M1_6kakuACB;
    public GameObject M1_6kakuBCD;

    public GameObject M1_6StkakuABC;
    public GameObject M1_6StkakuACB;
    public GameObject M1_6StkakuBCD;

    private Renderer rrM1_6TextA;
    private Renderer rrM1_6TextB;
    private Renderer rrM1_6TextC;
    private Renderer rrM1_6TextD;

    private Renderer rrM1_6LineAB;
    private Renderer rrM1_6LineBC;
    private Renderer rrM1_6LineAC;
    private Renderer rrM1_6LineCD;
    private Renderer rrM1_6LineAD;
    private Renderer rrM1_6LineBD;

    private Renderer rrM1_6StLineAB;
    private Renderer rrM1_6StLineBC;
    private Renderer rrM1_6StLineAC;
    private Renderer rrM1_6StLineCD;
    private Renderer rrM1_6StLineAD;
    private Renderer rrM1_6StLineBD;

    private Renderer rrM1_6PointA;
    private Renderer rrM1_6PointB;
    private Renderer rrM1_6PointC;
    private Renderer rrM1_6PointD;

    private Renderer rrM1_6StPointA;
    private Renderer rrM1_6StPointB;
    private Renderer rrM1_6StPointC;
    private Renderer rrM1_6StPointD;

    private Renderer rrM1_6kakuABC;
    private Renderer rrM1_6kakuACB;
    private Renderer rrM1_6kakuBCD;

    private Renderer rrM1_6StkakuABC;
    private Renderer rrM1_6StkakuACB;
    private Renderer rrM1_6StkakuBCD;

    void Start()
    {
        rrM1_6TextA = M1_6TextA.GetComponent<Renderer>();
        rrM1_6TextB = M1_6TextB.GetComponent<Renderer>();
        rrM1_6TextC = M1_6TextC.GetComponent<Renderer>();
        rrM1_6TextD = M1_6TextD.GetComponent<Renderer>();

        rrM1_6LineAB = M1_6LineAB.GetComponent<Renderer>();
        rrM1_6LineBC = M1_6LineBC.GetComponent<Renderer>();
        rrM1_6LineAC = M1_6LineAC.GetComponent<Renderer>();
        rrM1_6LineCD = M1_6LineCD.GetComponent<Renderer>();
        //rrM1_6LineAD = M1_6LineAD.GetComponent<Renderer>();
        rrM1_6LineBD = M1_6LineBD.GetComponent<Renderer>();

        rrM1_6StLineAB = M1_6StLineAB.GetComponent<Renderer>();
        rrM1_6StLineBC = M1_6StLineBC.GetComponent<Renderer>();
        rrM1_6StLineAC = M1_6StLineAC.GetComponent<Renderer>();
        rrM1_6StLineCD = M1_6StLineCD.GetComponent<Renderer>();
        //rrM1_6StLineAD = M1_6StLineAD.GetComponent<Renderer>();
        rrM1_6StLineBD = M1_6StLineBD.GetComponent<Renderer>();

        rrM1_6PointA = M1_6PointA.GetComponent<Renderer>();
        rrM1_6PointB = M1_6PointB.GetComponent<Renderer>();
        rrM1_6PointC = M1_6PointC.GetComponent<Renderer>();
        rrM1_6PointD = M1_6PointD.GetComponent<Renderer>();

        rrM1_6StPointA = M1_6StPointA.GetComponent<Renderer>();
        rrM1_6StPointB = M1_6StPointB.GetComponent<Renderer>();
        rrM1_6StPointC = M1_6StPointC.GetComponent<Renderer>();
        rrM1_6StPointD = M1_6StPointD.GetComponent<Renderer>();

        rrM1_6kakuABC = M1_6kakuABC.GetComponent<Renderer>();
        rrM1_6kakuACB = M1_6kakuACB.GetComponent<Renderer>();
        rrM1_6kakuBCD = M1_6kakuBCD.GetComponent<Renderer>();

        rrM1_6StkakuABC = M1_6StkakuABC.GetComponent<Renderer>();
        rrM1_6StkakuACB = M1_6StkakuACB.GetComponent<Renderer>();
        rrM1_6StkakuBCD = M1_6StkakuBCD.GetComponent<Renderer>();

    }
    //リセット表示を全部消すメソッド　kyotu.rrcount------resetW-----------------------
    private void reset()
    {
        //colorの設定
        //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
        //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
        // 0020_99_1:マテリアルのエミッションの色を得る
        //rrM1_4kakuBAC.GetComponent<Shape>().settings.fillColor = MColor1.GetColor("_EmissionColor");

        rrM1_6kakuABC.GetComponent<Shape>().settings.fillColor = PointNewm12MidGreen.GetColor("_EmissionColor");
        rrM1_6kakuACB.GetComponent<Shape>().settings.fillColor = PointNewm12MidGreen.GetColor("_EmissionColor");
        rrM1_6kakuBCD.GetComponent<Shape>().settings.fillColor = PointNewm12MidGreen.GetColor("_EmissionColor");

        rrM1_6StkakuABC.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_6StkakuACB.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_6StkakuBCD.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");

        rrM1_6LineAB.GetComponent<Renderer>().material = Line1NewM1Yellow;
        rrM1_6LineBC.GetComponent<Renderer>().material = Line1NewM1Yellow;
        rrM1_6LineAC.GetComponent<Renderer>().material = Line1NewM1Yellow;
        rrM1_6LineBD.GetComponent<Renderer>().material = Line1NewM1Yellow;
        rrM1_6LineCD.GetComponent<Renderer>().material = Line1NewM1Yellow;

        rrM1_6StLineAB.GetComponent<Renderer>().material = StLineNewm3red;
        rrM1_6StLineBC.GetComponent<Renderer>().material = StLineNewm3red;
        rrM1_6StLineAC.GetComponent<Renderer>().material = StLineNewm3red;
        rrM1_6StLineBD.GetComponent<Renderer>().material = StLineNewm3red;
        rrM1_6StLineCD.GetComponent<Renderer>().material = StLineNewm3red;

        rrM1_6PointA.GetComponent<Shape>().settings.fillColor = PointNewm12MidGreen.GetColor("_EmissionColor");
        rrM1_6PointB.GetComponent<Shape>().settings.fillColor = PointNewm12MidGreen.GetColor("_EmissionColor");
        rrM1_6PointC.GetComponent<Shape>().settings.fillColor = PointNewm12MidGreen.GetColor("_EmissionColor");
        rrM1_6PointD.GetComponent<Shape>().settings.fillColor = PointNewm12MidGreen.GetColor("_EmissionColor");

        rrM1_6StPointA.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_6StPointB.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_6StPointC.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_6StPointD.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");



        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;

        //gameobjectを見えなくする
        //＞line：gameobjectを見えなくす

        rrM1_6TextA.enabled = false;
        rrM1_6TextB.enabled = false;
        rrM1_6TextC.enabled = false;
        rrM1_6TextD.enabled = false;

        rrM1_6LineAB.enabled = false;
        rrM1_6LineBC.enabled = false;
        rrM1_6LineAC.enabled = false;
        rrM1_6LineCD.enabled = false;
        //rrM1_6LineAD.enabled = false;
        rrM1_6LineBD.enabled = false;

        rrM1_6StLineAB.enabled = false;
        rrM1_6StLineBC.enabled = false;
        rrM1_6StLineAC.enabled = false;
        rrM1_6StLineCD.enabled = false;
        //rrM1_6StLineAD.enabled = false;
        rrM1_6StLineBD.enabled = false;

        rrM1_6PointA.enabled = false;
        rrM1_6PointB.enabled = false;
        rrM1_6PointC.enabled = false;
        rrM1_6PointD.enabled = false;

        rrM1_6StPointA.enabled = false;
        rrM1_6StPointB.enabled = false;
        rrM1_6StPointC.enabled = false;
        rrM1_6StPointD.enabled = false;

        rrM1_6kakuABC.enabled = false;
        rrM1_6kakuACB.enabled = false;
        rrM1_6kakuBCD.enabled = false;

        rrM1_6StkakuABC.enabled = false;
        rrM1_6StkakuACB.enabled = false;
        rrM1_6StkakuBCD.enabled = false;
    }
    void Update()
    {
        henka(kyotu.rrCount);
        //Debug.Log("KA_6RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count)
    {//henkaW
        //m1_3のときのみ実行
        if (kyotu.mojiSwitch == 3 & kyotu.MCount == 5)
        {
            if (count == 0)
            {
                reset();
            }
            else if (count == 1)
            {//henka1
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                ////rrM1_6LineAC.material = MColor1;
                ////rrM1_6LineBC.material = MColor1;
                //rrM1_6StLineAC.material = MColor3;
                //rrM1_6StLineBC.material = MColor3;
                //rrM1_6StLineBD.material = MColor3;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 2)
            {//henka2
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                ////rrM1_6LineAC.material = MColor1;
                ////rrM1_6LineBC.material = MColor1;
                //rrM1_6StLineAC.material = MColor3;
                //rrM1_6StLineBC.material = MColor3;
                //rrM1_6StLineBD.material = MColor3;
                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 3)
            {//henka3
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                ////rrM1_6LineAC.material = MColor1;
                ////rrM1_6LineBC.material = MColor1;
                //rrM1_6StLineAC.material = MColor3;
                //rrM1_6StLineBC.material = MColor3;
                //rrM1_6StLineBD.material = MColor3;
                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 4)
            {//henka4
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                ////rrM1_6LineAC.material = MColor1;
                ////rrM1_6LineBC.material = MColor1;
                //rrM1_6StLineAC.material = MColor3;
                //rrM1_6StLineBC.material = MColor3;
                //rrM1_6StLineBD.material = MColor3;
                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 5)
            {//henka5
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                ////rrM1_6LineAC.material = MColor1;
                ////rrM1_6LineBC.material = MColor1;
                //rrM1_6StLineAC.material = MColor3;
                //rrM1_6StLineBC.material = MColor3;
                //rrM1_6StLineBD.material = MColor3;
                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 6)
            {//henka6
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                ////rrM1_6LineAC.material = MColor1;
                ////rrM1_6LineBC.material = MColor1;
                //rrM1_6StLineAC.material = MColor3;
                //rrM1_6StLineBC.material = MColor3;
                //rrM1_6StLineBD.material = MColor3;
                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 7)
            {//henka7
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                ////rrM1_6LineAC.material = MColor1;
                ////rrM1_6LineBC.material = MColor1;
                //rrM1_6StLineAC.material = MColor3;
                //rrM1_6StLineBC.material = MColor3;
                //rrM1_6StLineBD.material = MColor3;
                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 8)
            {//henka8
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                ////rrM1_6LineAC.material = MColor1;
                ////rrM1_6LineBC.material = MColor1;
                //rrM1_6StLineAC.material = MColor3;
                //rrM1_6StLineBC.material = MColor3;
                //rrM1_6StLineBD.material = MColor3;
                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 9)
            {//henka9
                reset();

            }
            else if (count == 10)
            {//henka10
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor3;
                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_6kakuABC.enabled = true;
                //rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 11)
            {//henka11
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor3;
                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                //rrM1_6kakuACB.enabled = true;

                rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 12)
            {//henka12
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor3;
                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StkakuABC.enabled = true;

                rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 13)
            {//henka13
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor3;
                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 14)
            {//henka14
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor3;
                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 15)
            {//henka15
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor3;
                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 16)
            {//henka16
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor3;
                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 17)
            {//henka17
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor3;
                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 18)
            {//henka18
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor3;
                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 19)
            {//henka19
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor3;
                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 20)
            {//henka20
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor3;
                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 21)
            {//henka21
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor3;
                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 22)
            {//henka22
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor3;
                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 23)
            {//henka23
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor3;
                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 24)
            {//henka24
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor3;
                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 25)
            {//henka25
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor3;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 26)
            {//henka26w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
//                rrM1_6LineAC.material = MColor2;
                //rrM1_6LineBC.material = MColor1;
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                //rrM1_6StLineBC.material = MColor3;
                rrM1_6StLineBD.material = Line4NewM8White;
                rrM1_6StLineAC.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 27)
            {//henka27
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //rrM1_6LineAC.material = MColor2;
                //rrM1_6LineBC.material = MColor1;
                //                rrM1_6StLineAC.material = MColor3;
                //                rrM1_6StLineBC.material = MColor3;
                //                rrM1_6StLineBD.material = MColor3;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 28)
            {//henka28
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //rrM1_6LineBC.material = MColor1;
                //                rrM1_6StLineAC.material = MColor3;
                //                rrM1_6StLineBC.material = MColor3;
                //                rrM1_6StLineBD.material = MColor3;
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 29)
            {//henka29
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //rrM1_6LineBC.material = MColor1;
                //                rrM1_6StLineAC.material = MColor3;
                //                rrM1_6StLineBC.material = MColor3;
                //                rrM1_6StLineBD.material = MColor3;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 30)
            {//henka30
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //rrM1_6LineBC.material = MColor1;
                //                rrM1_6StLineAC.material = MColor3;
                //                rrM1_6StLineBC.material = MColor3;
                //                rrM1_6StLineBD.material = MColor3;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 31)
            {//henka31
                
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //rrM1_6LineBC.material = MColor1;
                //                rrM1_6StLineAC.material = MColor3;
                //                rrM1_6StLineBC.material = MColor3;
                //                rrM1_6StLineBD.material = MColor3;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 32)
            {//henka32
                
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //rrM1_6LineBC.material = MColor1;
                //                rrM1_6StLineAC.material = MColor3;
                //                rrM1_6StLineBC.material = MColor3;
                //                rrM1_6StLineBD.material = MColor3;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 33)
            {//henka33w
                
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //rrM1_6LineBC.material = MColor1;
                //                rrM1_6StLineAC.material = MColor3;
                //                rrM1_6StLineBC.material = MColor3;
                //                rrM1_6StLineBD.material = MColor3;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StPointA.enabled = true;
                //rrM1_6StPointB.enabled = true;
                //rrM1_6StPointC.enabled = true;

                rrM1_6StPointA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StPointB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StPointC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAB.enabled = true;
                rrM1_6StLineBC.enabled = true;
                rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 34)
            {//henka34
                
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //rrM1_6LineBC.material = MColor1;
                //                rrM1_6StLineAC.material = MColor3;
                //                rrM1_6StLineBC.material = MColor3;
                //                rrM1_6StLineBD.material = MColor3;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                rrM1_6StPointB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StPointC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StPointD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                rrM1_6StLineBC.enabled = true;
                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                rrM1_6StLineBD.enabled = true;
                rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 35)
            {//henka35
                
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //rrM1_6LineBC.material = MColor1;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor3;
                //                rrM1_6StLineBD.material = MColor3;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;


                rrM1_6StPointA.enabled = true;
                rrM1_6StPointB.enabled = true;
                rrM1_6StPointC.enabled = true;
                //rrM1_6StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineBC.enabled = true;

                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 36)
            {//henka36
                
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //rrM1_6LineBC.material = MColor1;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor3;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                rrM1_6StPointD.enabled = true;
                rrM1_6StPointB.enabled = true;
                rrM1_6StPointC.enabled = true;
                //rrM1_6StPointD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 37)
            {//henka37
                
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //rrM1_6LineBC.material = MColor1;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor3;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 38)
            {//henka38
                
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                rrM1_6StPointA.enabled = true;
                rrM1_6StPointB.enabled = true;
                rrM1_6StPointC.enabled = true;

                //rrM1_6StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StPointC.enabled = kyotuEla.tenmetuOnOff;                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 39)
            {//henka39
                
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                rrM1_6StPointD.enabled = true;
                rrM1_6StPointB.enabled = true;
                rrM1_6StPointC.enabled = true;

                //rrM1_6StPointD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 40)
            {//henka40
                
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 41)
            {//henka41
                
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                rrM1_6StPointA.enabled = true;
                rrM1_6StPointB.enabled = true;
                rrM1_6StPointC.enabled = true;
                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 42)
            {//henka42w
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                rrM1_6StPointD.enabled = true;
                rrM1_6StPointB.enabled = true;
                rrM1_6StPointC.enabled = true;
                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 43)
            {//henka43
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 44)
            {//henka44
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;


                rrM1_6StPointA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StPointB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StPointC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 45)
            {//henka45
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                rrM1_6StPointD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StPointB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 46)
            {//henka46
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;
                //rrM1_6StLineBC.material = Line1NewM1Yellow;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                rrM1_6StPointA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StPointB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 47)
            {//henka47
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;
                //rrM1_6StLineBC.material = Line1NewM1Yellow;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                rrM1_6StPointD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StPointB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;
                //rrM1_6StPointA.enabled = true;
                //rrM1_6StPointB.enabled = true;
                //rrM1_6StPointC.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 48)
            {//henka48
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;
                
                rrM1_6StPointA.enabled = true;
                rrM1_6StPointB.enabled = true;
                rrM1_6StPointC.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;

                rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 49)
            {//henka49w
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                rrM1_6kakuBCD.enabled = true;
                //rrM1_6kakuBCD.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;

            }
            else if (count == 50)
            {//henka50
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                rrM1_6kakuBCD.enabled = true;

                rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 51)
            {//henka51
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                rrM1_6kakuBCD.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 52)
            {//henka52
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                rrM1_6kakuBCD.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 53)
            {//henka53
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                rrM1_6kakuBCD.enabled = true;

                rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 54)
            {//henka54
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                rrM1_6kakuBCD.enabled = true;

                rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 55)
            {//henka55
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                rrM1_6kakuBCD.enabled = true;

                rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 56)
            {//henka56
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                rrM1_6kakuBCD.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StkakuABC.enabled = true;

                rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 57)
            {//henka57
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                rrM1_6kakuBCD.enabled = true;

                rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 58)
            {//henka58
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                rrM1_6kakuBCD.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 59)
            {//henka59
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                rrM1_6kakuBCD.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 60)
            {//henka60
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                rrM1_6kakuBCD.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 61)
            {//henka61
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                rrM1_6kakuBCD.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 62)
            {//henka62
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                rrM1_6kakuBCD.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 63)
            {//henka63
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                rrM1_6kakuBCD.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 64)
            {//henka64
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                rrM1_6kakuBCD.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 65)
            {//henka65
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                rrM1_6kakuBCD.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 66)
            {//henka66
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                rrM1_6kakuBCD.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 67)
            {//henka67
                reset();
                rrM1_6LineAC.material = Line2NewM10DarkBlue;
                rrM1_6LineBD.material = Line2NewM10DarkBlue;
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //                rrM1_6LineAC.material = MColor2;
                //                rrM1_6LineBC.material = MColor0;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                rrM1_6LineBD.enabled = true;
                rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                rrM1_6kakuBCD.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 68)
            {//henka68
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
                //                rrM1_6StLineAC.material = MColor6;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                rrM1_6StLineAC.material = Line4NewM8White;
                rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                //rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                //rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                //rrM1_6LineBD.enabled = true;
                //rrM1_6LineCD.enabled = true;

                rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                //rrM1_6kakuBCD.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 69)
            {//henka69
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
                //                rrM1_6StLineAC.material = MColor3;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                //rrM1_6StLineAC.material = Line4NewM8White;
                //rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                //rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                //rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                //rrM1_6LineBD.enabled = true;
                //rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                //rrM1_6kakuBCD.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 70)
            {//henka70
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
                //                rrM1_6StLineAC.material = MColor3;
                //                rrM1_6StLineBC.material = MColor4;
                //                rrM1_6StLineBD.material = MColor6;
                //rrM1_6StLineAC.material = Line4NewM8White;
                //rrM1_6StLineBD.material = Line4NewM8White;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                //rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                //rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                //rrM1_6LineBD.enabled = true;
                //rrM1_6LineCD.enabled = true;

                rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                //rrM1_6kakuBCD.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 71)
            {//henka71
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor6;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                //rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                //rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                //rrM1_6LineBD.enabled = true;
                //rrM1_6LineCD.enabled = true;

                rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                //rrM1_6kakuBCD.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 72)
            {//henka72
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor6;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                //rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                //rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                //rrM1_6LineBD.enabled = true;
                //rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                //rrM1_6kakuBCD.enabled = true;

                rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 73)
            {//henka73
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor6;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                //rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                //rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                //rrM1_6LineBD.enabled = true;
                //rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                //rrM1_6kakuBCD.enabled = true;

                rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 74)
            {//henka74
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor6;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                //rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                //rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                //rrM1_6LineBD.enabled = true;
                //rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                //rrM1_6kakuBCD.enabled = true;

                rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 75)
            {//henka75
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor6;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                //rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                //rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                //rrM1_6LineBD.enabled = true;
                //rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                //rrM1_6kakuBCD.enabled = true;

                rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 76)
            {//henka76
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor6;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                //rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                //rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                //rrM1_6LineBD.enabled = true;
                //rrM1_6LineCD.enabled = true;

                rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                //rrM1_6kakuBCD.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 77)
            {//henka77
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor6;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                //rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                //rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                //rrM1_6LineBD.enabled = true;
                //rrM1_6LineCD.enabled = true;

                rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                //rrM1_6kakuBCD.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 78)
            {//henka78
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor6;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                //rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                //rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                //rrM1_6LineBD.enabled = true;
                //rrM1_6LineCD.enabled = true;

                rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                //rrM1_6kakuBCD.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
            else if (count == 79)
            {//henka79
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_6LineAC.material = MColor1;
                //rrM1_6LineBC.material = MColor1;
//                rrM1_6StLineAC.material = MColor3;
//                rrM1_6StLineBC.material = MColor3;
//                rrM1_6StLineBD.material = MColor6;

                rrM1_6TextA.enabled = true;
                rrM1_6TextB.enabled = true;
                rrM1_6TextC.enabled = true;
                //rrM1_6TextD.enabled = true;

                rrM1_6PointA.enabled = true;
                rrM1_6PointB.enabled = true;
                rrM1_6PointC.enabled = true;
                //rrM1_6PointD.enabled = true;

                rrM1_6LineAB.enabled = true;
                rrM1_6LineBC.enabled = true;
                rrM1_6LineAC.enabled = true;
                //rrM1_6LineBD.enabled = true;
                //rrM1_6LineCD.enabled = true;

                //rrM1_6StLineAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAB.enabled = true;

                //rrM1_6StLineBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBC.enabled = true;

                //rrM1_6StLineAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineAC.enabled = true;

                //rrM1_6StLineBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineBD.enabled = true;

                //rrM1_6StLineCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StLineCD.enabled = true;

                rrM1_6kakuABC.enabled = true;
                rrM1_6kakuACB.enabled = true;
                //rrM1_6kakuBCD.enabled = true;

                //rrM1_6StkakuABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuABC.enabled = true;

                //rrM1_6StkakuACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_6StkakuBCD.enabled = true;
            }
        }
    }
}
