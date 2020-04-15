using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shapes2D;//0019_99_1：shape2dで色をスクリプトから変更する


public class H_99_51_M1_5RRHenka : MonoBehaviour
{
    //atamaW saisho
    //M1_3preにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

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


    //MColor0Blue_point;-----oldcolor 使わないーーーーーーーーーーーーーーーー
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
    //MColor0Blue_point;-----oldcolor 使わないーーーーーーーーーーーーーーーー

    public GameObject M1_5TextA;
    public GameObject M1_5TextB;
    public GameObject M1_5TextC;
    public GameObject M1_5TextD;
    public GameObject M1_5TextE;
    public GameObject M1_5TextF;
    public GameObject M1_5TextG;

    public GameObject M1_5LineAB;


    public GameObject M1_5LineBC;
    public GameObject M1_5LineCA;
    //public GameObject M1_5LineAD;
    public GameObject M1_5LineAE;
    public GameObject M1_5LineAF;
    public GameObject M1_5LineAG;


    public GameObject M1_5LineBG;


    public GameObject M1_5LineCF;
    public GameObject M1_5LineBD;
    public GameObject M1_5LineCE;
    public GameObject M1_5LineBF;
    public GameObject M1_5LineCG;

    public GameObject M1_5LineStAB;
    public GameObject M1_5LineStBC;
    public GameObject M1_5LineStCA;
    //public GameObject M1_5LineStAD;
    public GameObject M1_5LineStAE;
    public GameObject M1_5LineStAF;
    public GameObject M1_5LineStAG;
    public GameObject M1_5LineStBG;
    public GameObject M1_5LineStCF;
    public GameObject M1_5LineStBD;
    public GameObject M1_5LineStCE;
    public GameObject M1_5LineStBF;
    public GameObject M1_5LineStCG;

    public GameObject M1_5LineStAB2;
    public GameObject M1_5LineStAG2;
    public GameObject M1_5LineStBG2;

    public GameObject M1_5PointA;
    public GameObject M1_5PointB;
    public GameObject M1_5PointC;
    public GameObject M1_5PointF;
    public GameObject M1_5PointG;

    public GameObject M1_5PointStA;
    public GameObject M1_5PointStB;
    public GameObject M1_5PointStC;
    public GameObject M1_5PointStF;
    public GameObject M1_5PointStG;

    public GameObject M1_5KakuBAC;
    public GameObject M1_5KakuABC;
    public GameObject M1_5KakuACB;
    public GameObject M1_5KakuAFC;
    public GameObject M1_5KakuAGB;
    public GameObject M1_5KakuCBF;
    public GameObject M1_5KakuBCG;
    public GameObject M1_5KakuABG;
    public GameObject M1_5KakuACF;
    public GameObject M1_5KakuCBG;
    public GameObject M1_5KakuBCF;

    public GameObject M1_5KakuStBAC;
    public GameObject M1_5KakuStABC;
    public GameObject M1_5KakuStACB;
    public GameObject M1_5KakuStAFC;
    public GameObject M1_5KakuStAGB;
    public GameObject M1_5KakuStCBF;
    public GameObject M1_5KakuStBCG;
    public GameObject M1_5KakuStABG;
    public GameObject M1_5KakuStACF;
    public GameObject M1_5KakuStCBG;
    public GameObject M1_5KakuStBCF;

    private Renderer rrM1_5TextA;
    private Renderer rrM1_5TextB;
    private Renderer rrM1_5TextC;
    private Renderer rrM1_5TextD;
    private Renderer rrM1_5TextE;
    private Renderer rrM1_5TextF;
    private Renderer rrM1_5TextG;

    private Renderer rrM1_5LineAB;
    private Renderer rrM1_5LineBC;
    private Renderer rrM1_5LineCA;
    //private Renderer rrM1_5LineAD;
    private Renderer rrM1_5LineAE;
    private Renderer rrM1_5LineAF;
    private Renderer rrM1_5LineAG;
    private Renderer rrM1_5LineBG;
    private Renderer rrM1_5LineCF;
    private Renderer rrM1_5LineBD;
    private Renderer rrM1_5LineCE;
    private Renderer rrM1_5LineBF;
    private Renderer rrM1_5LineCG;

    private Renderer rrM1_5LineStAB;
    private Renderer rrM1_5LineStBC;
    private Renderer rrM1_5LineStCA;
    //private Renderer rrM1_5LineStAD;
    private Renderer rrM1_5LineStAE;
    private Renderer rrM1_5LineStAF;
    private Renderer rrM1_5LineStAG;
    private Renderer rrM1_5LineStBG;
    private Renderer rrM1_5LineStCF;
    private Renderer rrM1_5LineStBD;
    private Renderer rrM1_5LineStCE;
    private Renderer rrM1_5LineStBF;
    private Renderer rrM1_5LineStCG;

    private Renderer rrM1_5LineStAB2;
    private Renderer rrM1_5LineStAG2;
    private Renderer rrM1_5LineStBG2;


    private Renderer rrM1_5PointA;
    private Renderer rrM1_5PointB;
    private Renderer rrM1_5PointC;
    private Renderer rrM1_5PointF;
    private Renderer rrM1_5PointG;

    private Renderer rrM1_5PointStA;
    private Renderer rrM1_5PointStB;
    private Renderer rrM1_5PointStC;
    private Renderer rrM1_5PointStF;
    private Renderer rrM1_5PointStG;

    private Renderer rrM1_5KakuBAC;
    private Renderer rrM1_5KakuABC;
    private Renderer rrM1_5KakuACB;
    private Renderer rrM1_5KakuAFC;
    private Renderer rrM1_5KakuAGB;
    private Renderer rrM1_5KakuCBF;
    private Renderer rrM1_5KakuBCG;
    private Renderer rrM1_5KakuABG;
    private Renderer rrM1_5KakuACF;
    private Renderer rrM1_5KakuCBG;
    private Renderer rrM1_5KakuBCF;

    private Renderer rrM1_5KakuStBAC;
    private Renderer rrM1_5KakuStABC;
    private Renderer rrM1_5KakuStACB;
    private Renderer rrM1_5KakuStAFC;
    private Renderer rrM1_5KakuStAGB;
    private Renderer rrM1_5KakuStCBF;
    private Renderer rrM1_5KakuStBCG;
    private Renderer rrM1_5KakuStABG;
    private Renderer rrM1_5KakuStACF;
    private Renderer rrM1_5KakuStCBG;
    private Renderer rrM1_5KakuStBCF;


    void Start()
    {

        rrM1_5TextA = M1_5TextA.GetComponent<Renderer>();
        rrM1_5TextB = M1_5TextB.GetComponent<Renderer>();
        rrM1_5TextC = M1_5TextC.GetComponent<Renderer>();
        rrM1_5TextD = M1_5TextD.GetComponent<Renderer>();
        rrM1_5TextE = M1_5TextE.GetComponent<Renderer>();
        rrM1_5TextF = M1_5TextF.GetComponent<Renderer>();
        rrM1_5TextG = M1_5TextG.GetComponent<Renderer>();

        rrM1_5LineAB = M1_5LineAB.GetComponent<Renderer>();
        rrM1_5LineBC = M1_5LineBC.GetComponent<Renderer>();
        rrM1_5LineCA = M1_5LineCA.GetComponent<Renderer>();
        //rrM1_5LineAD = M1_5LineAD.GetComponent<Renderer>();
        rrM1_5LineAE = M1_5LineAE.GetComponent<Renderer>();
        rrM1_5LineAF = M1_5LineAF.GetComponent<Renderer>();
        rrM1_5LineAG = M1_5LineAG.GetComponent<Renderer>();
        rrM1_5LineBG = M1_5LineBG.GetComponent<Renderer>();
        rrM1_5LineCF = M1_5LineCF.GetComponent<Renderer>();
        rrM1_5LineBD = M1_5LineBD.GetComponent<Renderer>();
        rrM1_5LineCE = M1_5LineCE.GetComponent<Renderer>();
        rrM1_5LineBF = M1_5LineBF.GetComponent<Renderer>();
        rrM1_5LineCG = M1_5LineCG.GetComponent<Renderer>();


        rrM1_5LineStAB = M1_5LineStAB.GetComponent<Renderer>();
        rrM1_5LineStBC = M1_5LineStBC.GetComponent<Renderer>();
        rrM1_5LineStCA = M1_5LineStCA.GetComponent<Renderer>();
        //rrM1_5LineStAD = M1_5LineStAD.GetComponent<Renderer>();
        rrM1_5LineStAE = M1_5LineStAE.GetComponent<Renderer>();
        rrM1_5LineStAF = M1_5LineStAF.GetComponent<Renderer>();
        rrM1_5LineStAG = M1_5LineStAG.GetComponent<Renderer>();
        rrM1_5LineStBG = M1_5LineStBG.GetComponent<Renderer>();
        rrM1_5LineStCF = M1_5LineStCF.GetComponent<Renderer>();
        rrM1_5LineStBD = M1_5LineStBD.GetComponent<Renderer>();
        rrM1_5LineStCE = M1_5LineStCE.GetComponent<Renderer>();
        rrM1_5LineStBF = M1_5LineStBF.GetComponent<Renderer>();
        rrM1_5LineStCG = M1_5LineStCG.GetComponent<Renderer>();

        rrM1_5LineStAB2 = M1_5LineStAB2.GetComponent<Renderer>();
        rrM1_5LineStAG2 = M1_5LineStAG2.GetComponent<Renderer>();
        rrM1_5LineStBG2 = M1_5LineStBG2.GetComponent<Renderer>();

        rrM1_5PointA = M1_5PointA.GetComponent<Renderer>();
        rrM1_5PointB = M1_5PointB.GetComponent<Renderer>();
        rrM1_5PointC = M1_5PointC.GetComponent<Renderer>();
        rrM1_5PointF = M1_5PointF.GetComponent<Renderer>();
        rrM1_5PointG = M1_5PointG.GetComponent<Renderer>();

        rrM1_5PointStA = M1_5PointStA.GetComponent<Renderer>();
        rrM1_5PointStB = M1_5PointStB.GetComponent<Renderer>();
        rrM1_5PointStC = M1_5PointStC.GetComponent<Renderer>();
        rrM1_5PointStF = M1_5PointStF.GetComponent<Renderer>();
        rrM1_5PointStG = M1_5PointStG.GetComponent<Renderer>();

        rrM1_5KakuBAC = M1_5KakuBAC.GetComponent<Renderer>();
        rrM1_5KakuABC = M1_5KakuABC.GetComponent<Renderer>();
        rrM1_5KakuACB = M1_5KakuACB.GetComponent<Renderer>();
        rrM1_5KakuAFC = M1_5KakuAFC.GetComponent<Renderer>();
        rrM1_5KakuAGB = M1_5KakuAGB.GetComponent<Renderer>();
        rrM1_5KakuCBF = M1_5KakuCBF.GetComponent<Renderer>();
        rrM1_5KakuBCG = M1_5KakuBCG.GetComponent<Renderer>();
        rrM1_5KakuABG = M1_5KakuABG.GetComponent<Renderer>();
        rrM1_5KakuACF = M1_5KakuACF.GetComponent<Renderer>();
        rrM1_5KakuCBG = M1_5KakuCBG.GetComponent<Renderer>();
        rrM1_5KakuBCF = M1_5KakuBCF.GetComponent<Renderer>();

        rrM1_5KakuStBAC = M1_5KakuStBAC.GetComponent<Renderer>();
        rrM1_5KakuStABC = M1_5KakuStABC.GetComponent<Renderer>();
        rrM1_5KakuStACB = M1_5KakuStACB.GetComponent<Renderer>();
        rrM1_5KakuStAFC = M1_5KakuStAFC.GetComponent<Renderer>();
        rrM1_5KakuStAGB = M1_5KakuStAGB.GetComponent<Renderer>();
        rrM1_5KakuStCBF = M1_5KakuStCBF.GetComponent<Renderer>();
        rrM1_5KakuStBCG = M1_5KakuStBCG.GetComponent<Renderer>();
        rrM1_5KakuStABG = M1_5KakuStABG.GetComponent<Renderer>();
        rrM1_5KakuStACF = M1_5KakuStACF.GetComponent<Renderer>();
        rrM1_5KakuStCBG = M1_5KakuStCBG.GetComponent<Renderer>();
        rrM1_5KakuStBCF = M1_5KakuStBCF.GetComponent<Renderer>();
    }
    //リセット表示を全部消すメソッド　kyotu.rrcount------resetW-----------------------
    private void reset()//resetw
    {
        //colorの設定
        //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
        //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
        // 0020_99_1:マテリアルのエミッションの色を得る
        //rrM1_4kakuBAC.GetComponent<Shape>().settings.fillColor = MColor1.GetColor("_EmissionColor");

        rrM1_5PointA.GetComponent<Shape>().settings.fillColor = PointNewm12MidGreen.GetColor("_EmissionColor");
        rrM1_5PointB.GetComponent<Shape>().settings.fillColor = PointNewm12MidGreen.GetColor("_EmissionColor");
        rrM1_5PointC.GetComponent<Shape>().settings.fillColor = PointNewm12MidGreen.GetColor("_EmissionColor");
        rrM1_5PointF.GetComponent<Shape>().settings.fillColor = PointNewm12MidGreen.GetColor("_EmissionColor");
        rrM1_5PointG.GetComponent<Shape>().settings.fillColor = PointNewm12MidGreen.GetColor("_EmissionColor");

        rrM1_5PointStA.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_5PointStB.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_5PointStC.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_5PointStF.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_5PointStG.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");


        rrM1_5LineAB.material = Line1NewM1Yellow;
        rrM1_5LineBC.material = Line1NewM1Yellow;
        rrM1_5LineCA.material = Line1NewM1Yellow;
        rrM1_5LineBD.material = Line1NewM1Yellow;
        rrM1_5LineCE.material = Line1NewM1Yellow;
        rrM1_5LineAE.material = Line1NewM1Yellow;
        rrM1_5LineAF.material = Line1NewM1Yellow;
        rrM1_5LineAG.material = Line1NewM1Yellow;
        rrM1_5LineCF.material = Line1NewM1Yellow;
        rrM1_5LineBG.material = Line1NewM1Yellow;
        rrM1_5LineBF.material = Line1NewM1Yellow;
        rrM1_5LineCG.material = Line1NewM1Yellow;

        rrM1_5LineStAB.material = StLineNewm3red;
        rrM1_5LineStBC.material = StLineNewm3red;
        rrM1_5LineStCA.material = StLineNewm3red;
        rrM1_5LineStBD.material = StLineNewm3red;
        rrM1_5LineStCE.material = StLineNewm3red;
        rrM1_5LineStAE.material = StLineNewm3red;
        rrM1_5LineStAF.material = StLineNewm3red;
        rrM1_5LineStAG.material = StLineNewm3red;
        rrM1_5LineStCF.material = StLineNewm3red;
        rrM1_5LineStBG.material = StLineNewm3red;
        rrM1_5LineStBF.material = StLineNewm3red;
        rrM1_5LineStCG.material = StLineNewm3red;

        rrM1_5KakuStBAC.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_5KakuStABC.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_5KakuStACB.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_5KakuStAFC.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_5KakuStAGB.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_5KakuStCBF.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_5KakuStBCG.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_5KakuStABG.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_5KakuStACF.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_5KakuStCBG.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_5KakuStBCF.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");


        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;

        //gameobjectを見えなくする
        //＞line：gameobjectを見えなくする

        rrM1_5TextA.enabled = false;
        rrM1_5TextB.enabled = false;
        rrM1_5TextC.enabled = false;
        rrM1_5TextD.enabled = false;
        rrM1_5TextE.enabled = false;
        rrM1_5TextF.enabled = false;
        rrM1_5TextG.enabled = false;

        rrM1_5LineAB.enabled = false;
        rrM1_5LineBC.enabled = false;
        rrM1_5LineCA.enabled = false;
        //rrM1_5LineAD.enabled = false;
        rrM1_5LineAE.enabled = false;
        rrM1_5LineAF.enabled = false;
        rrM1_5LineAG.enabled = false;
        rrM1_5LineBG.enabled = false;
        rrM1_5LineCF.enabled = false;
        rrM1_5LineBD.enabled = false;
        rrM1_5LineCE.enabled = false;
        rrM1_5LineBF.enabled = false;
        rrM1_5LineCG.enabled = false;

        rrM1_5LineStAB.enabled = false;
        rrM1_5LineStBC.enabled = false;
        rrM1_5LineStCA.enabled = false;
        //rrM1_5LineStAD.enabled = false;
        rrM1_5LineStAE.enabled = false;
        rrM1_5LineStAF.enabled = false;
        rrM1_5LineStAG.enabled = false;
        rrM1_5LineStBG.enabled = false;
        rrM1_5LineStCF.enabled = false;
        rrM1_5LineStBD.enabled = false;
        rrM1_5LineStCE.enabled = false;
        rrM1_5LineStBF.enabled = false;
        rrM1_5LineStCG.enabled = false;

        rrM1_5LineStAB2.enabled = false;
        rrM1_5LineStAG2.enabled = false;
        rrM1_5LineStBG2.enabled = false;

        rrM1_5PointA.enabled = false;
        rrM1_5PointB.enabled = false;
        rrM1_5PointC.enabled = false;
        rrM1_5PointF.enabled = false;
        rrM1_5PointG.enabled = false;

        rrM1_5PointStA.enabled = false;
        rrM1_5PointStB.enabled = false;
        rrM1_5PointStC.enabled = false;
        rrM1_5PointStF.enabled = false;
        rrM1_5PointStG.enabled = false;

        rrM1_5KakuBAC.enabled = false;
        rrM1_5KakuABC.enabled = false;
        rrM1_5KakuACB.enabled = false;
        rrM1_5KakuAFC.enabled = false;
        rrM1_5KakuAGB.enabled = false;
        rrM1_5KakuCBF.enabled = false;
        rrM1_5KakuBCG.enabled = false;
        rrM1_5KakuABG.enabled = false;
        rrM1_5KakuACF.enabled = false;
        rrM1_5KakuCBG.enabled = false;
        rrM1_5KakuBCF.enabled = false;

        rrM1_5KakuStBAC.enabled = false;
        rrM1_5KakuStABC.enabled = false;
        rrM1_5KakuStACB.enabled = false;
        rrM1_5KakuStAFC.enabled = false;
        rrM1_5KakuStAGB.enabled = false;
        rrM1_5KakuStCBF.enabled = false;
        rrM1_5KakuStBCG.enabled = false;
        rrM1_5KakuStABG.enabled = false;
        rrM1_5KakuStACF.enabled = false;
        rrM1_5KakuStCBG.enabled = false;
        rrM1_5KakuStBCF.enabled = false;
    }
    void Update()//updateW
    {
        henka(kyotu.rrCount);
        //Debug.Log("M1_5RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);
    }
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count)
    {//henkaW
        //m1_3のときのみ実行
        if (kyotu.mojiSwitch == 3 & kyotu.MCount == 4)
        {
            if (count == 0)//0w
            {
                reset();
            }
            else if (count == 1) //henka1w
            {
                reset();
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;

                rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;

            }
            else if (count == 2)
            {//henka2
                reset();
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;

                rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 3)
            {//henka3
                reset();
                //0019_99_1：shape2dで色をスクリプトから変更する
                // 0020_99_1:マテリアルのエミッションの色を得る
                //M1_5KakuABC.GetComponent<Shape>().settings.fillColor = MColor6.GetColor("_EmissionColor");

                //M1_5KakuACB.GetComponent<Shape>().settings.fillColor = MColor6.GetColor("_EmissionColor");


                //rrM1_5KakuABC.shap = 

                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;

                rrM1_5LineStBC.enabled = true;

                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;

                rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 4)
            {//henka4
                reset();
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;



                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;

                rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 5)
            {//henka5w
                reset();
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;

                rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = true;
                rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;

                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;

                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 6)
            {//henka6
                reset();
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                //rrM1_5LineAD.enabled = true;
                //rrM1_5LineAE.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;

                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;

                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 7)
            {//henka7
                reset();
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                //rrM1_5LineAD.enabled = true;
                //rrM1_5LineAE.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = true;
                rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;

                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;

                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 8)
            {//henka8
                reset();
                //0019_99_1：shape2dで色をスクリプトから変更する
                // 0020_99_1:マテリアルのエミッションの色を得る
                //M1_5KakuCBF.GetComponent<Shape>().settings.fillColor = MColor7.GetColor("_EmissionColor");
                //M1_5KakuBCG.GetComponent<Shape>().settings.fillColor = MColor7.GetColor("_EmissionColor");


                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                //rrM1_5LineAD.enabled = true;
                //rrM1_5LineAE.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;

                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBCF.enabled = true;
                //rrM1_5KakuCBG.enabled = true;

                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 9)
            {//henka9
                reset();
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                //rrM1_5LineAD.enabled = true;
                //rrM1_5LineAE.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;

                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBCF.enabled = true;
                //rrM1_5KakuCBG.enabled = true;

                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 10)
            {//henka10w
                reset();
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                //rrM1_5LineAD.enabled = true;
                //rrM1_5LineAE.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;

                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBCF.enabled = true;
                //rrM1_5KakuCBG.enabled = true;

                rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;

            }
            else if (count == 11)
            {//henka11
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;

                //LineSt
                rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;

                rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
            }
            else if (count == 12)
            {//henka12
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //LineSt tenmetu
                rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
            }
            else if (count == 13)
            {//henka13
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;

                //LineSt true
                rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
            }
            else if (count == 14)
            {//henka14
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;

                //LineSt tenmetu
                rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
            }
            else if (count == 15)
            {//henka15w
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;

                //LineSt tenmetu
                rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
            }
            else if (count == 16)
            {//henka16
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
            }
            else if (count == 17)
            {//henka17
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;


                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
            }
            else if (count == 18)
            {//henka18
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;


                //LineSt tenmetu
                rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
            }
            else if (count == 19)
            {//henka19
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;


                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
            }
            else if (count == 20)
            {//henka20w
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;


                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
            }
            else if (count == 21)
            {//henka21
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //LineSt true
                rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
            }
            else if (count == 22)
            {//henka22
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //Kaku
                rrM1_5KakuABC.enabled = true;
                //KakuSt
                rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 23)
            {//henka23
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //KakuSt true
                rrM1_5KakuStABC.enabled = true;
                rrM1_5KakuStACB.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 24)
            {//henka24
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //KakuSt true
                rrM1_5KakuStABC.enabled = true;
                rrM1_5KakuStACB.enabled = true;
                //KakuSt tenmetu
                rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 25)
            {//henka25w
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                rrM1_5KakuCBF.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 26)
            {//henka26
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;

            }
            else if (count == 27)
            {//henka27
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;


                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 28)
            {//henka28
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 29)
            {//henka29
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 30)
            {//henka30w
                reset();
                //k0018_99_1:マテリアルの変更
                //rrM1_5LineStAE.material = MColor4;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;


                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;


                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 31)
            {//henka31
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                rrM1_5LineStAE.enabled = true;


                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;


                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;

                //PointSt true
                rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 32)
            {//henka32
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                rrM1_5LineStAE.enabled = true;


                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;


                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;

                //PointSt true
                rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 33)
            {//henka33w
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 34)
            {//henka34w
                reset();
                rrM1_5LineStAG.material = Line4NewM8White;
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                rrM1_5LineStAE.enabled = true;
                rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 35)
            {//henka35w
                reset();
                rrM1_5LineStAG.material = Line4NewM8White;
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                rrM1_5LineStAE.enabled = true;
                rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 36)
            {//henka36
                reset();
                rrM1_5LineStAG.material = Line4NewM8White;
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 37)
            {//henka37
                reset();
                rrM1_5LineStAG.material = Line4NewM8White;
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                rrM1_5LineStAG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 38)
            {//henka38
                reset();
                rrM1_5LineStAG.material = Line4NewM8White;
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                rrM1_5LineStAG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 39)
            {//henka39
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 40)
            {//henka40w
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;


                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 41)
            {//henka41
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;


                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 42)
            {//henka42
                reset();

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;


                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 43)
            {//henka43
                reset();
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;


                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 44)
            {//henka44
                reset();
                //k0018_99_1_1_1:
                //rrM1_5LineStAF.material = MColor6;
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;


                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 45)
            {//henka45w
                reset();
                //k0018_99_1_1_1:
                //rrM1_5LineStAG.material = MColor6;
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;


                //LineSt true
                rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 46)
            {//henka46
                reset();

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;


                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 47)
            {//henka47
                reset();
                //k0018_99_1_1_1:
                //rrM1_5LineStCA.material = MColor7;
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;


                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 48)
            {//henka48
                reset();
                //k0018_99_1_1_1:
                //rrM1_5LineStAB.material = MColor7;
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;


                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 49)
            {//henka49
                reset();

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;


                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 50)
            {//henka50w
                reset();

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;


                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;

            }
            else if (count == 51)
            {//henka51
                reset();

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;


                //LineSt true
                rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;

            }
            else if (count == 52)
            {//henka52
                reset();

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 53)
            {//henka53
                reset();

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBAC.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 54)
            {//henka54
                reset();

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBAC.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 55)
            {//henka55
                reset();
                //k0018_99_1_1_1:
                //rrM1_5LineCF.material = MColor3;
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBAC.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 56)
            {//henka56
                reset();
                //k0018_99_1_1_1:
                //rrM1_5LineBG.material = MColor3;
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBAC.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 57)
            {//henka57
                reset();

                //0019_99_1：shape2dで色をスクリプトから変更する
                //0020_99_1:マテリアルのエミッションの色を得る
                //M1_5KakuAFC.GetComponent<Shape>().settings.fillColor = MColor8.GetColor("_EmissionColor");
                //M1_5KakuACF.GetComponent<Shape>().settings.fillColor = MColor9.GetColor("_EmissionColor");

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;


            }
            else if (count == 58)
            {//henka58
                reset();

                //0019_99_1：shape2dで色をスクリプトから変更する
                //0020_99_1:マテリアルのエミッションの色を得る
                //M1_5KakuAGB.GetComponent<Shape>().settings.fillColor = MColor8.GetColor("_EmissionColor");
                //M1_5KakuABG.GetComponent<Shape>().settings.fillColor = MColor9.GetColor("_EmissionColor");
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;

                //LineSt true
                rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 59)
            {//henka59
                reset();

                //0019_99_1：shape2dで色をスクリプトから変更する
                //0020_99_1:マテリアルのエミッションの色を得る
                //M1_5KakuAGB.GetComponent<Shape>().settings.fillColor = MColor8.GetColor("_EmissionColor");
                //M1_5KakuABG.GetComponent<Shape>().settings.fillColor = MColor9.GetColor("_EmissionColor");
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;

            }
            else if (count == 60)
            {//henka60
                reset();

                //0019_99_1：shape2dで色をスクリプトから変更する
                //0020_99_1:マテリアルのエミッションの色を得る
                //M1_5KakuAGB.GetComponent<Shape>().settings.fillColor = MColor8.GetColor("_EmissionColor");
                //M1_5KakuABG.GetComponent<Shape>().settings.fillColor = MColor9.GetColor("_EmissionColor");
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 61)
            {//henka61
                reset();

                //0019_99_1：shape2dで色をスクリプトから変更する
                //0020_99_1:マテリアルのエミッションの色を得る
                //M1_5KakuAGB.GetComponent<Shape>().settings.fillColor = MColor8.GetColor("_EmissionColor");
                //M1_5KakuABG.GetComponent<Shape>().settings.fillColor = MColor9.GetColor("_EmissionColor");
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 62)
            {//henka62
                reset();

                //0019_99_1：shape2dで色をスクリプトから変更する
                //0020_99_1:マテリアルのエミッションの色を得る
                //M1_5KakuAGB.GetComponent<Shape>().settings.fillColor = MColor8.GetColor("_EmissionColor");
                //M1_5KakuABG.GetComponent<Shape>().settings.fillColor = MColor9.GetColor("_EmissionColor");
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;

            }
            else if (count == 63)
            {//henka63
                reset();

                //0019_99_1：shape2dで色をスクリプトから変更する
                //0020_99_1:マテリアルのエミッションの色を得る
                //M1_5KakuAGB.GetComponent<Shape>().settings.fillColor = MColor8.GetColor("_EmissionColor");
                //M1_5KakuABG.GetComponent<Shape>().settings.fillColor = MColor9.GetColor("_EmissionColor");
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 64)
            {//henka64
                reset();

                //0019_99_1：shape2dで色をスクリプトから変更する
                //0020_99_1:マテリアルのエミッションの色を得る
                //M1_5KakuAGB.GetComponent<Shape>().settings.fillColor = MColor8.GetColor("_EmissionColor");
                //M1_5KakuABG.GetComponent<Shape>().settings.fillColor = MColor9.GetColor("_EmissionColor");
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 65)
            {//henka65   
                reset();

                //0019_99_1：shape2dで色をスクリプトから変更する
                //0020_99_1:マテリアルのエミッションの色を得る
                //M1_5KakuAGB.GetComponent<Shape>().settings.fillColor = MColor8.GetColor("_EmissionColor");
                //M1_5KakuABG.GetComponent<Shape>().settings.fillColor = MColor9.GetColor("_EmissionColor");
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 66)
            {//henka66 
                reset();

                //0019_99_1：shape2dで色をスクリプトから変更する
                //0020_99_1:マテリアルのエミッションの色を得る
                //M1_5KakuAGB.GetComponent<Shape>().settings.fillColor = MColor8.GetColor("_EmissionColor");
                //M1_5KakuABG.GetComponent<Shape>().settings.fillColor = MColor9.GetColor("_EmissionColor");
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 67)
            {//henka67
                reset();

                //0019_99_1：shape2dで色をスクリプトから変更する
                //0020_99_1:マテリアルのエミッションの色を得る
                //M1_5KakuAGB.GetComponent<Shape>().settings.fillColor = MColor8.GetColor("_EmissionColor");
                //M1_5KakuABG.GetComponent<Shape>().settings.fillColor = MColor9.GetColor("_EmissionColor");
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 68)
            {//henka68
                reset();

                //0019_99_1：shape2dで色をスクリプトから変更する
                //0020_99_1:マテリアルのエミッションの色を得る
                //M1_5KakuAGB.GetComponent<Shape>().settings.fillColor = MColor8.GetColor("_EmissionColor");
                //M1_5KakuABG.GetComponent<Shape>().settings.fillColor = MColor9.GetColor("_EmissionColor");
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 69)
            {//henka69
                reset();
                rrM1_5LineStAB.material = Line4NewM8White;
                //0019_99_1：shape2dで色をスクリプトから変更する
                //0020_99_1:マテリアルのエミッションの色を得る
                //M1_5KakuAGB.GetComponent<Shape>().settings.fillColor = MColor8.GetColor("_EmissionColor");
                //M1_5KakuABG.GetComponent<Shape>().settings.fillColor = MColor9.GetColor("_EmissionColor");
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                rrM1_5LineStAF.enabled = true;
                rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;

                //LineSt tenmetu
                rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 70)
            {//henka70
                reset();
                rrM1_5LineStAB.material = Line4NewM8White;
                rrM1_5LineStCA.material = Line4NewM8White;
                //0019_99_1：shape2dで色をスクリプトから変更する
                //0020_99_1:マテリアルのエミッションの色を得る
                //M1_5KakuAGB.GetComponent<Shape>().settings.fillColor = MColor8.GetColor("_EmissionColor");
                //M1_5KakuABG.GetComponent<Shape>().settings.fillColor = MColor9.GetColor("_EmissionColor");
                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;

                //LineSt true
                rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                rrM1_5LineStAF.enabled = true;
                rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 71)
            {//henka71  
                reset();
                rrM1_5LineStAB.material = Line4NewM8White;
                rrM1_5LineStCA.material = Line4NewM8White;
                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineBF.material =MColor6;



                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                //LineSt true
                rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                rrM1_5LineStAF.enabled = true;
                rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 72)
            {//henka72  
                reset();
                rrM1_5LineStAB.material = Line4NewM8White;
                rrM1_5LineStCA.material = Line4NewM8White;
                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineBF.material = MColor6;



                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                //LineSt true
                rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 73)
            {//henka73  
                reset();
                rrM1_5LineStAB.material = Line4NewM8White;
                rrM1_5LineStCA.material = Line4NewM8White;
                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;



                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;
                //LineSt true
                rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                rrM1_5LineStBF.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 74)
            {//henka74  
                reset();
                rrM1_5LineStAB.material = Line4NewM8White;
                rrM1_5LineStCA.material = Line4NewM8White;
                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;



                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 75)
            {//henka75  
                reset();
                rrM1_5LineStAB.material = Line4NewM8White;
                rrM1_5LineStCA.material = Line4NewM8White;
                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 76)
            {//henka76  
                reset();
                rrM1_5LineStAB.material = Line4NewM8White;
                rrM1_5LineStCA.material = Line4NewM8White;

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                rrM1_5LineStAF.enabled = true;
                rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;

                //LineSt tenmetu
                rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 77)
            {//henka77  
                reset();
                rrM1_5LineStAB.material = Line4NewM8White;
                rrM1_5LineStCA.material = Line4NewM8White;
                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 78)
            {//henka78  
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineStBF.material = MColor6;
                //rrM1_5LineStBC.material = MColor1;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 79)
            {//henka79  
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineStCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 80)
            {//henka80  
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 81)
            {//henka81  
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                rrM1_5LineStBG.enabled = true;
                rrM1_5LineStBF.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 82)
            {//henka82  
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 83)
            {//henka83  
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                rrM1_5LineStBF.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 84)
            {//henka84  
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 85)
            {//henka85  
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 86)
            {//henka86  
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                rrM1_5LineStBF.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 87)
            {//henka87  
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 88)
            {//henka88  
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 89)
            {//henka89  
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 90)
            {//henka90  
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 91)
            {//henka91www  
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 92)
            {//henka92
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;

                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;


                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 93)
            {//henka93
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;

                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 94)
            {//henka94
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                rrM1_5KakuStCBF.enabled = true;
                rrM1_5KakuStBCF.enabled = true;
                rrM1_5KakuStCBG.enabled = false;
                rrM1_5KakuStBCG.enabled = false;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 95)
            {//henka95
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 96)
            {//henka96
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 97)
            {//henka97
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 98)
            {//henka98
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 99)
            {//henka99
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 100)
            {//henka100
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 101)
            {//henka101
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 102)
            {//henka102
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 103)
            {//henka103
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 104)
            {//henka104
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 105)
            {//henka105
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 106)
            {//henka106
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 107)
            {//henka107
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 108)
            {//henka108
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 109)
            {//henka109
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 110)
            {//henka110
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 111)
            {//henka111
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 112)
            {//henka112
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                rrM1_5KakuStACF.enabled = true;
                rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 113)
            {//henka113
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                //rrM1_5KakuABC.enabled = true;
                //rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                rrM1_5KakuStACF.enabled = true;
                rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 114)
            {//henka114
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 115)
            {//henka115
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 116)
            {//henka116
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 117)
            {//henka117
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 118)
            {//henka118
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 119)
            {//henka119
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                rrM1_5KakuStACF.enabled = true;
                rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 120)
            {//henka120
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                rrM1_5LineCF.enabled = true;
                rrM1_5LineBG.enabled = true;
                rrM1_5LineBF.enabled = true;
                rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                rrM1_5TextD.enabled = true;
                rrM1_5TextE.enabled = true;
                rrM1_5TextF.enabled = true;
                rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                rrM1_5PointF.enabled = true;
                rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                rrM1_5KakuBAC.enabled = true;
                rrM1_5KakuAFC.enabled = true;
                rrM1_5KakuACF.enabled = true;
                rrM1_5KakuABG.enabled = true;
                rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                rrM1_5KakuBCF.enabled = true;
                rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                rrM1_5KakuStACF.enabled = true;
                rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                rrM1_5KakuStBCF.enabled = true;
                rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 121)
            {//henka121
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                //rrM1_5LineCF.enabled = true;
                //rrM1_5LineBG.enabled = true;
                //rrM1_5LineBF.enabled = true;
                //rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //rrM1_5TextD.enabled = true;
                //rrM1_5TextE.enabled = true;
                //rrM1_5TextF.enabled = true;
                //rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //rrM1_5PointF.enabled = true;
                //rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBAC.enabled = true;
                //rrM1_5KakuAFC.enabled = true;
                //rrM1_5KakuACF.enabled = true;
                //rrM1_5KakuABG.enabled = true;
                //rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCF.enabled = true;
                //rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 122)
            {//henka122
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                //rrM1_5LineCF.enabled = true;
                //rrM1_5LineBG.enabled = true;
                //rrM1_5LineBF.enabled = true;
                //rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //rrM1_5TextD.enabled = true;
                //rrM1_5TextE.enabled = true;
                //rrM1_5TextF.enabled = true;
                //rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //rrM1_5PointF.enabled = true;
                //rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBAC.enabled = true;
                //rrM1_5KakuAFC.enabled = true;
                //rrM1_5KakuACF.enabled = true;
                //rrM1_5KakuABG.enabled = true;
                //rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCF.enabled = true;
                //rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                rrM1_5KakuStABC.enabled = true;
                rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 123)
            {//henka123
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                //rrM1_5LineCF.enabled = true;
                //rrM1_5LineBG.enabled = true;
                //rrM1_5LineBF.enabled = true;
                //rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //rrM1_5TextD.enabled = true;
                //rrM1_5TextE.enabled = true;
                //rrM1_5TextF.enabled = true;
                //rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //rrM1_5PointF.enabled = true;
                //rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBAC.enabled = true;
                //rrM1_5KakuAFC.enabled = true;
                //rrM1_5KakuACF.enabled = true;
                //rrM1_5KakuABG.enabled = true;
                //rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCF.enabled = true;
                //rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                rrM1_5KakuStABC.enabled = true;
                rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 124)
            {//henka124
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                //rrM1_5LineCF.enabled = true;
                //rrM1_5LineBG.enabled = true;
                //rrM1_5LineBF.enabled = true;
                //rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //rrM1_5TextD.enabled = true;
                //rrM1_5TextE.enabled = true;
                //rrM1_5TextF.enabled = true;
                //rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //rrM1_5PointF.enabled = true;
                //rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBAC.enabled = true;
                //rrM1_5KakuAFC.enabled = true;
                //rrM1_5KakuACF.enabled = true;
                //rrM1_5KakuABG.enabled = true;
                //rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCF.enabled = true;
                //rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 125)
            {//henka125
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                //rrM1_5LineCF.enabled = true;
                //rrM1_5LineBG.enabled = true;
                //rrM1_5LineBF.enabled = true;
                //rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //rrM1_5TextD.enabled = true;
                //rrM1_5TextE.enabled = true;
                //rrM1_5TextF.enabled = true;
                //rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //rrM1_5PointF.enabled = true;
                //rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBAC.enabled = true;
                //rrM1_5KakuAFC.enabled = true;
                //rrM1_5KakuACF.enabled = true;
                //rrM1_5KakuABG.enabled = true;
                //rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCF.enabled = true;
                //rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 126)
            {//henka126
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                //rrM1_5LineCF.enabled = true;
                //rrM1_5LineBG.enabled = true;
                //rrM1_5LineBF.enabled = true;
                //rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //rrM1_5TextD.enabled = true;
                //rrM1_5TextE.enabled = true;
                //rrM1_5TextF.enabled = true;
                //rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //rrM1_5PointF.enabled = true;
                //rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBAC.enabled = true;
                //rrM1_5KakuAFC.enabled = true;
                //rrM1_5KakuACF.enabled = true;
                //rrM1_5KakuABG.enabled = true;
                //rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCF.enabled = true;
                //rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 127)
            {//henka127
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                //rrM1_5LineCF.enabled = true;
                //rrM1_5LineBG.enabled = true;
                //rrM1_5LineBF.enabled = true;
                //rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //rrM1_5TextD.enabled = true;
                //rrM1_5TextE.enabled = true;
                //rrM1_5TextF.enabled = true;
                //rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //rrM1_5PointF.enabled = true;
                //rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBAC.enabled = true;
                //rrM1_5KakuAFC.enabled = true;
                //rrM1_5KakuACF.enabled = true;
                //rrM1_5KakuABG.enabled = true;
                //rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCF.enabled = true;
                //rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 128)
            {//henka128
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                //rrM1_5LineCF.enabled = true;
                //rrM1_5LineBG.enabled = true;
                //rrM1_5LineBF.enabled = true;
                //rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //rrM1_5TextD.enabled = true;
                //rrM1_5TextE.enabled = true;
                //rrM1_5TextF.enabled = true;
                //rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //rrM1_5PointF.enabled = true;
                //rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBAC.enabled = true;
                //rrM1_5KakuAFC.enabled = true;
                //rrM1_5KakuACF.enabled = true;
                //rrM1_5KakuABG.enabled = true;
                //rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCF.enabled = true;
                //rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 129)
            {//henka129
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                //rrM1_5LineCF.enabled = true;
                //rrM1_5LineBG.enabled = true;
                //rrM1_5LineBF.enabled = true;
                //rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //rrM1_5TextD.enabled = true;
                //rrM1_5TextE.enabled = true;
                //rrM1_5TextF.enabled = true;
                //rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //rrM1_5PointF.enabled = true;
                //rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBAC.enabled = true;
                //rrM1_5KakuAFC.enabled = true;
                //rrM1_5KakuACF.enabled = true;
                //rrM1_5KakuABG.enabled = true;
                //rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCF.enabled = true;
                //rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 130)
            {//henka130
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                //rrM1_5LineCF.enabled = true;
                //rrM1_5LineBG.enabled = true;
                //rrM1_5LineBF.enabled = true;
                //rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //rrM1_5TextD.enabled = true;
                //rrM1_5TextE.enabled = true;
                //rrM1_5TextF.enabled = true;
                //rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //rrM1_5PointF.enabled = true;
                //rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBAC.enabled = true;
                //rrM1_5KakuAFC.enabled = true;
                //rrM1_5KakuACF.enabled = true;
                //rrM1_5KakuABG.enabled = true;
                //rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCF.enabled = true;
                //rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 131)
            {//henka131
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                //rrM1_5LineCF.enabled = true;
                //rrM1_5LineBG.enabled = true;
                //rrM1_5LineBF.enabled = true;
                //rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //rrM1_5TextD.enabled = true;
                //rrM1_5TextE.enabled = true;
                //rrM1_5TextF.enabled = true;
                //rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //rrM1_5PointF.enabled = true;
                //rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBAC.enabled = true;
                //rrM1_5KakuAFC.enabled = true;
                //rrM1_5KakuACF.enabled = true;
                //rrM1_5KakuABG.enabled = true;
                //rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCF.enabled = true;
                //rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 132)
            {//henka132
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                //rrM1_5LineCF.enabled = true;
                //rrM1_5LineBG.enabled = true;
                //rrM1_5LineBF.enabled = true;
                //rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //rrM1_5TextD.enabled = true;
                //rrM1_5TextE.enabled = true;
                //rrM1_5TextF.enabled = true;
                //rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //rrM1_5PointF.enabled = true;
                //rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBAC.enabled = true;
                //rrM1_5KakuAFC.enabled = true;
                //rrM1_5KakuACF.enabled = true;
                //rrM1_5KakuABG.enabled = true;
                //rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCF.enabled = true;
                //rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 133)
            {//henka133
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                //rrM1_5LineCF.enabled = true;
                //rrM1_5LineBG.enabled = true;
                //rrM1_5LineBF.enabled = true;
                //rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //rrM1_5TextD.enabled = true;
                //rrM1_5TextE.enabled = true;
                //rrM1_5TextF.enabled = true;
                //rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //rrM1_5PointF.enabled = true;
                //rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBAC.enabled = true;
                //rrM1_5KakuAFC.enabled = true;
                //rrM1_5KakuACF.enabled = true;
                //rrM1_5KakuABG.enabled = true;
                //rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCF.enabled = true;
                //rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 134)
            {//henka134
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                //rrM1_5LineCF.enabled = true;
                //rrM1_5LineBG.enabled = true;
                //rrM1_5LineBF.enabled = true;
                //rrM1_5LineCG.enabled = true;

                //LineSt true
                rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //rrM1_5TextD.enabled = true;
                //rrM1_5TextE.enabled = true;
                //rrM1_5TextF.enabled = true;
                //rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //rrM1_5PointF.enabled = true;
                //rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBAC.enabled = true;
                //rrM1_5KakuAFC.enabled = true;
                //rrM1_5KakuACF.enabled = true;
                //rrM1_5KakuABG.enabled = true;
                //rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCF.enabled = true;
                //rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 135)
            {//henka135
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                //rrM1_5LineCF.enabled = true;
                //rrM1_5LineBG.enabled = true;
                //rrM1_5LineBF.enabled = true;
                //rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //rrM1_5TextD.enabled = true;
                //rrM1_5TextE.enabled = true;
                //rrM1_5TextF.enabled = true;
                //rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //rrM1_5PointF.enabled = true;
                //rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBAC.enabled = true;
                //rrM1_5KakuAFC.enabled = true;
                //rrM1_5KakuACF.enabled = true;
                //rrM1_5KakuABG.enabled = true;
                //rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCF.enabled = true;
                //rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 136)
            {//henka136
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                //rrM1_5LineCF.enabled = true;
                //rrM1_5LineBG.enabled = true;
                //rrM1_5LineBF.enabled = true;
                //rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //rrM1_5TextD.enabled = true;
                //rrM1_5TextE.enabled = true;
                //rrM1_5TextF.enabled = true;
                //rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //rrM1_5PointF.enabled = true;
                //rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBAC.enabled = true;
                //rrM1_5KakuAFC.enabled = true;
                //rrM1_5KakuACF.enabled = true;
                //rrM1_5KakuABG.enabled = true;
                //rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCF.enabled = true;
                //rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 137)
            {//henka137
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                //rrM1_5LineCF.enabled = true;
                //rrM1_5LineBG.enabled = true;
                //rrM1_5LineBF.enabled = true;
                //rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //rrM1_5TextD.enabled = true;
                //rrM1_5TextE.enabled = true;
                //rrM1_5TextF.enabled = true;
                //rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //rrM1_5PointF.enabled = true;
                //rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBAC.enabled = true;
                //rrM1_5KakuAFC.enabled = true;
                //rrM1_5KakuACF.enabled = true;
                //rrM1_5KakuABG.enabled = true;
                //rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCF.enabled = true;
                //rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 138)
            {//henka138
                reset();

                //k0018_99_1:マテリアルの変更
                //k0018_99_1_1://マテリアルをセット
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;

                //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
                //rrM1_5LineCG.material = MColor6;

                //Line
                rrM1_5LineAB.enabled = true;
                rrM1_5LineBC.enabled = true;
                rrM1_5LineCA.enabled = true;
                rrM1_5LineBD.enabled = true;
                rrM1_5LineCE.enabled = true;
                //rrM1_5LineCF.enabled = true;
                //rrM1_5LineBG.enabled = true;
                //rrM1_5LineBF.enabled = true;
                //rrM1_5LineCG.enabled = true;

                //LineSt true
                //rrM1_5LineStAB.enabled = true;
                //rrM1_5LineStBC.enabled = true;
                //rrM1_5LineStCA.enabled = true;
                //rrM1_5LineStBD.enabled = true;
                //rrM1_5LineStCE.enabled = true;
                //rrM1_5LineStAE.enabled = true;
                //rrM1_5LineStAF.enabled = true;
                //rrM1_5LineStAG.enabled = true;
                //rrM1_5LineStCF.enabled = true;
                //rrM1_5LineStBG.enabled = true;
                //rrM1_5LineStBF.enabled = true;
                //rrM1_5LineStCG.enabled = true;

                //LineSt tenmetu
                //rrM1_5LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStAG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5LineStCG.enabled = kyotuEla.tenmetuOnOff;

                //Text
                rrM1_5TextA.enabled = true;
                rrM1_5TextB.enabled = true;
                rrM1_5TextC.enabled = true;
                //rrM1_5TextD.enabled = true;
                //rrM1_5TextE.enabled = true;
                //rrM1_5TextF.enabled = true;
                //rrM1_5TextG.enabled = true;

                //Point
                rrM1_5PointA.enabled = true;
                rrM1_5PointB.enabled = true;
                rrM1_5PointC.enabled = true;
                //rrM1_5PointF.enabled = true;
                //rrM1_5PointG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = true;
                //rrM1_5PointStB.enabled = true;
                //rrM1_5PointStC.enabled = true;
                //rrM1_5PointStF.enabled = true;
                //rrM1_5PointStG.enabled = true;

                //PointSt true
                //rrM1_5PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5PointStG.enabled = kyotuEla.tenmetuOnOff;

                //Kaku
                rrM1_5KakuABC.enabled = true;
                rrM1_5KakuACB.enabled = true;
                //rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCG.enabled = true;
                //rrM1_5KakuBAC.enabled = true;
                //rrM1_5KakuAFC.enabled = true;
                //rrM1_5KakuACF.enabled = true;
                //rrM1_5KakuABG.enabled = true;
                //rrM1_5KakuAGB.enabled = true;
                rrM1_5KakuCBF.enabled = true;
                //rrM1_5KakuBCF.enabled = true;
                //rrM1_5KakuCBG.enabled = true;
                rrM1_5KakuBCG.enabled = true;


                //KakuSt true
                //rrM1_5KakuStABC.enabled = true;
                //rrM1_5KakuStACB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //rrM1_5KakuStBAC.enabled = true;
                //rrM1_5KakuStAFC.enabled = true;
                //rrM1_5KakuStACF.enabled = true;
                //rrM1_5KakuStABG.enabled = true;
                //rrM1_5KakuStAGB.enabled = true;
                //rrM1_5KakuStCBF.enabled = true;
                //rrM1_5KakuStBCF.enabled = true;
                //rrM1_5KakuStCBG.enabled = true;
                //rrM1_5KakuStBCG.enabled = true;
                //KakuSt tenmetu
                //rrM1_5KakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAFC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStACF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStABG.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStAGB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStBCF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_5KakuStCBG.enabled = kyotuEla.tenmetuOnOff;
            }
        }
    }
}
//end999

