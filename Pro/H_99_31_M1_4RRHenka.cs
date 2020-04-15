using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//0019_99_1：shape2dで色をスクリプトから変更する
using Shapes2D;
//atama
public class H_99_31_M1_4RRHenka : MonoBehaviour {//atama
    //M1_3preにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    //public Material MColor0;//blue
    //public Material MColor1;//yellow
    //public Material MColor2;//green
    //public Material MColor3;//red
    //public Material MColor4;//orange
    //public Material MColor5;//purple
    //public Material MColor6;//pink
    //public Material MColor7;//darkpurple
    //public Material MColor8;//white
    //public Material MColor9;//black

    public Material StLineNewm3red;
    public Material Line1NewM1Yellow;
    public Material Line2NewM10DarkBlue;
    public Material Line3NewM7DarkPurple;
    public Material Line4NewM8White;
    public Material Line5NewM9Black;
    public Material PointNewm12MidGreen;



    public GameObject M1_4LineAB;
    public GameObject M1_4LineBC;
    public GameObject M1_4LineCA;
    public GameObject M1_4LineDE;
    public GameObject M1_4LineEF;
    public GameObject M1_4LineFD;

    public GameObject M1_4LineStAB;
    public GameObject M1_4LineStBC;
    public GameObject M1_4LineStCA;
    public GameObject M1_4LineStDE;
    public GameObject M1_4LineStEF;
    public GameObject M1_4LineStFD;

    public GameObject M1_4PointA;
    public GameObject M1_4PointB;
    public GameObject M1_4PointC;
    public GameObject M1_4PointD;
    public GameObject M1_4PointE;
    public GameObject M1_4PointF;

    public GameObject M1_4PointStA;
    public GameObject M1_4PointStB;
    public GameObject M1_4PointStC;
    public GameObject M1_4PointStD;
    public GameObject M1_4PointStE;
    public GameObject M1_4PointStF;

    public GameObject M1_4TextA;
    public GameObject M1_4TextB;
    public GameObject M1_4TextC;
    public GameObject M1_4TextD;
    public GameObject M1_4TextE;
    public GameObject M1_4TextF;

    public GameObject M1_4kakuBAC;
    public GameObject M1_4kakuStBAC;
    public GameObject M1_4kakuABC;
    public GameObject M1_4kakuStABC;
    public GameObject M1_4kakuACB;
    public GameObject M1_4kakuStACB;

    public GameObject M1_4kakuEDF;
    public GameObject M1_4kakuStEDF;
    public GameObject M1_4kakuDEF;
    public GameObject M1_4kakuStDEF;
    public GameObject M1_4kakuDFE;
    public GameObject M1_4kakuStDFE;

    private Renderer rrM1_4LineAB;
    private Renderer rrM1_4LineBC;
    private Renderer rrM1_4LineCA;
    private Renderer rrM1_4LineDE;
    private Renderer rrM1_4LineEF;
    private Renderer rrM1_4LineFD;

    private Renderer rrM1_4LineStAB;
    private Renderer rrM1_4LineStBC;
    private Renderer rrM1_4LineStCA;
    private Renderer rrM1_4LineStDE;
    private Renderer rrM1_4LineStEF;
    private Renderer rrM1_4LineStFD;

    private Renderer rrM1_4PointA;
    private Renderer rrM1_4PointB;
    private Renderer rrM1_4PointC;
    private Renderer rrM1_4PointD;
    private Renderer rrM1_4PointE;
    private Renderer rrM1_4PointF;

    private Renderer rrM1_4PointStA;
    private Renderer rrM1_4PointStB;
    private Renderer rrM1_4PointStC;
    private Renderer rrM1_4PointStD;
    private Renderer rrM1_4PointStE;
    private Renderer rrM1_4PointStF;

    private Renderer rrM1_4TextA;
    private Renderer rrM1_4TextB;
    private Renderer rrM1_4TextC;
    private Renderer rrM1_4TextD;
    private Renderer rrM1_4TextE;
    private Renderer rrM1_4TextF;

    private Renderer rrM1_4kakuBAC;
    private Renderer rrM1_4kakuStBAC;
    private Renderer rrM1_4kakuABC;
    private Renderer rrM1_4kakuStABC;
    private Renderer rrM1_4kakuACB;
    private Renderer rrM1_4kakuStACB;

    private Renderer rrM1_4kakuEDF;
    private Renderer rrM1_4kakuStEDF;
    private Renderer rrM1_4kakuDEF;
    private Renderer rrM1_4kakuStDEF;
    private Renderer rrM1_4kakuDFE;
    private Renderer rrM1_4kakuStDFE;

    void Start() {
        //0019_99_1：shape2dで色をスクリプトから変更する
        //円、角の色の変化
        var shape = GetComponent<Shape>();
        
        rrM1_4LineAB = M1_4LineAB.GetComponent<Renderer>();
        rrM1_4LineBC = M1_4LineBC.GetComponent<Renderer>();
        rrM1_4LineCA = M1_4LineCA.GetComponent<Renderer>();
        rrM1_4LineDE = M1_4LineDE.GetComponent<Renderer>();
        rrM1_4LineEF = M1_4LineEF.GetComponent<Renderer>();
        rrM1_4LineFD = M1_4LineFD.GetComponent<Renderer>();

        rrM1_4LineStAB = M1_4LineStAB.GetComponent<Renderer>();
        rrM1_4LineStBC = M1_4LineStBC.GetComponent<Renderer>();
        rrM1_4LineStCA = M1_4LineStCA.GetComponent<Renderer>();
        rrM1_4LineStDE = M1_4LineStDE.GetComponent<Renderer>();
        rrM1_4LineStEF = M1_4LineStEF.GetComponent<Renderer>();
        rrM1_4LineStFD = M1_4LineStFD.GetComponent<Renderer>();

        rrM1_4PointA = M1_4PointA.GetComponent<Renderer>();
        rrM1_4PointB = M1_4PointB.GetComponent<Renderer>();
        rrM1_4PointC = M1_4PointC.GetComponent<Renderer>();
        rrM1_4PointD = M1_4PointD.GetComponent<Renderer>();
        rrM1_4PointE = M1_4PointE.GetComponent<Renderer>();
        rrM1_4PointF = M1_4PointF.GetComponent<Renderer>();

        rrM1_4PointStA = M1_4PointStA.GetComponent<Renderer>();
        rrM1_4PointStB = M1_4PointStB.GetComponent<Renderer>();
        rrM1_4PointStC = M1_4PointStC.GetComponent<Renderer>();
        rrM1_4PointStD = M1_4PointStD.GetComponent<Renderer>();
        rrM1_4PointStE = M1_4PointStE.GetComponent<Renderer>();
        rrM1_4PointStF = M1_4PointStF.GetComponent<Renderer>();

        rrM1_4TextA = M1_4TextA.GetComponent<Renderer>();
        rrM1_4TextB = M1_4TextB.GetComponent<Renderer>();
        rrM1_4TextC = M1_4TextC.GetComponent<Renderer>();
        rrM1_4TextD = M1_4TextD.GetComponent<Renderer>();
        rrM1_4TextE = M1_4TextE.GetComponent<Renderer>();
        rrM1_4TextF = M1_4TextF.GetComponent<Renderer>();

       

        rrM1_4kakuBAC = M1_4kakuBAC.GetComponent<Renderer>();
        rrM1_4kakuStBAC = M1_4kakuStBAC.GetComponent<Renderer>();
        rrM1_4kakuABC = M1_4kakuABC.GetComponent<Renderer>();
        rrM1_4kakuStABC = M1_4kakuStABC.GetComponent<Renderer>();
        rrM1_4kakuACB = M1_4kakuACB.GetComponent<Renderer>();
        rrM1_4kakuStACB = M1_4kakuStACB.GetComponent<Renderer>();


        rrM1_4kakuEDF = M1_4kakuEDF.GetComponent<Renderer>();
        rrM1_4kakuStEDF = M1_4kakuStEDF.GetComponent<Renderer>();
        rrM1_4kakuDEF = M1_4kakuDEF.GetComponent<Renderer>();
        rrM1_4kakuStDEF = M1_4kakuStDEF.GetComponent<Renderer>();
        rrM1_4kakuDFE = M1_4kakuDFE.GetComponent<Renderer>();
        rrM1_4kakuStDFE = M1_4kakuStDFE.GetComponent<Renderer>();

    }
    //リセット表示を全部消すメソッド　kyotu.rrcount-----------------------------
    private void reset() {//resetw
        //colorの設定
        //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
        //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
        // 0020_99_1:マテリアルのエミッションの色を得る
        //rrM1_4kakuBAC.GetComponent<Shape>().settings.fillColor = MColor1.GetColor("_EmissionColor");
        
        rrM1_4LineAB.material = Line1NewM1Yellow;
        rrM1_4LineBC.material = Line1NewM1Yellow;
        rrM1_4LineCA.material = Line1NewM1Yellow;
        rrM1_4LineDE.material = Line1NewM1Yellow;
        rrM1_4LineEF.material = Line1NewM1Yellow;
        rrM1_4LineFD.material = Line1NewM1Yellow;

        rrM1_4LineStAB.material = StLineNewm3red;
        rrM1_4LineStBC.material = StLineNewm3red;
        rrM1_4LineStCA.material = StLineNewm3red;
        rrM1_4LineStDE.material = StLineNewm3red;
        rrM1_4LineStEF.material = StLineNewm3red;
        rrM1_4LineStFD.material = StLineNewm3red;

        // 0020_99_1:マテリアルのエミッションの色を得る
        //rrM1_4kakuBAC.GetComponent<Shape>().settings.fillColor = MColor1.GetColor("_EmissionColor");
        rrM1_4PointA.GetComponent<Shape>().settings.fillColor = PointNewm12MidGreen.GetColor("_EmissionColor");
        rrM1_4PointB.GetComponent<Shape>().settings.fillColor = PointNewm12MidGreen.GetColor("_EmissionColor");
        rrM1_4PointC.GetComponent<Shape>().settings.fillColor = PointNewm12MidGreen.GetColor("_EmissionColor");
        rrM1_4PointD.GetComponent<Shape>().settings.fillColor = PointNewm12MidGreen.GetColor("_EmissionColor");
        rrM1_4PointE.GetComponent<Shape>().settings.fillColor = PointNewm12MidGreen.GetColor("_EmissionColor");
        rrM1_4PointF.GetComponent<Shape>().settings.fillColor = PointNewm12MidGreen.GetColor("_EmissionColor");

        rrM1_4PointStA.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_4PointStB.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_4PointStC.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_4PointStD.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_4PointStE.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_4PointStF.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");

        rrM1_4kakuBAC.GetComponent<Shape>().settings.fillColor = Line1NewM1Yellow.GetColor("_EmissionColor");
        rrM1_4kakuABC.GetComponent<Shape>().settings.fillColor = Line3NewM7DarkPurple.GetColor("_EmissionColor");
        rrM1_4kakuACB.GetComponent<Shape>().settings.fillColor = Line2NewM10DarkBlue.GetColor("_EmissionColor");
        rrM1_4kakuEDF.GetComponent<Shape>().settings.fillColor = Line1NewM1Yellow.GetColor("_EmissionColor");
        rrM1_4kakuDEF.GetComponent<Shape>().settings.fillColor = Line3NewM7DarkPurple.GetColor("_EmissionColor");
        rrM1_4kakuDFE.GetComponent<Shape>().settings.fillColor = Line2NewM10DarkBlue.GetColor("_EmissionColor");

        rrM1_4kakuStBAC.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_4kakuStABC.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_4kakuStACB.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_4kakuStEDF.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_4kakuStDEF.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        rrM1_4kakuStDFE.GetComponent<Shape>().settings.fillColor = StLineNewm3red.GetColor("_EmissionColor");
        //rrM1_4kakuStBAC = M1_4kakuStBAC.GetComponent<Renderer>();
        //rrM1_4kakuABC = M1_4kakuABC.GetComponent<Renderer>();
        //rrM1_4kakuStABC = M1_4kakuStABC.GetComponent<Renderer>();
        //rrM1_4kakuACB = M1_4kakuACB.GetComponent<Renderer>();
        //rrM1_4kakuStACB = M1_4kakuStACB.GetComponent<Renderer>();


        //rrM1_4kakuEDF = M1_4kakuEDF.GetComponent<Renderer>();
        //rrM1_4kakuStEDF = M1_4kakuStEDF.GetComponent<Renderer>();
        //rrM1_4kakuDEF = M1_4kakuDEF.GetComponent<Renderer>();
        //rrM1_4kakuStDEF = M1_4kakuStDEF.GetComponent<Renderer>();
        //rrM1_4kakuDFE = M1_4kakuDFE.GetComponent<Renderer>();
        //rrM1_4kakuStDFE = M1_4kakuStDFE.GetComponent<Renderer>();
        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;

        //gameobjectを見えなくする
        //＞line：gameobjectを見えなくする

        rrM1_4LineAB.enabled = false;
        rrM1_4LineStAB.enabled = false;
        

        rrM1_4LineBC.enabled = false;
        rrM1_4LineStBC.enabled = false;

        rrM1_4LineCA.enabled = false;
        rrM1_4LineStCA.enabled = false;
        
        rrM1_4LineDE.enabled = false;
        rrM1_4LineStDE.enabled = false;
       

        rrM1_4LineEF.enabled = false;
        rrM1_4LineStEF.enabled = false;

        rrM1_4LineFD.enabled = false;
        rrM1_4LineStFD.enabled = false;
        


        //＞point：gameobjectを見えなくする
        rrM1_4PointA.enabled = false;
        rrM1_4PointB.enabled = false;
        rrM1_4PointC.enabled = false;

        rrM1_4PointD.enabled = false;
        rrM1_4PointE.enabled = false;
        rrM1_4PointF.enabled = false;
        //＞pointSt：gameobjectを見えなくする
        rrM1_4PointStA.enabled = false;
        rrM1_4PointStB.enabled = false;
        rrM1_4PointStC.enabled = false;
        rrM1_4PointStD.enabled = false;
        rrM1_4PointStE.enabled = false;
        rrM1_4PointStF.enabled = false;

        ////＞text：gameobjectを見えなくする
        rrM1_4TextA.enabled = false;
        rrM1_4TextB.enabled = false;
        rrM1_4TextC.enabled = false;
        rrM1_4TextD.enabled = false;
        rrM1_4TextE.enabled = false;
        rrM1_4TextF.enabled = false;

        rrM1_4kakuBAC.enabled = false;
        rrM1_4kakuStBAC.enabled = false;
        rrM1_4kakuABC.enabled = false;
        rrM1_4kakuStABC.enabled = false;
        rrM1_4kakuACB.enabled = false;
        rrM1_4kakuStACB.enabled = false;

        rrM1_4kakuEDF.enabled = false;
        rrM1_4kakuStEDF.enabled = false;
        rrM1_4kakuDEF.enabled = false;
        rrM1_4kakuStDEF.enabled = false;
        rrM1_4kakuDFE.enabled = false;
        rrM1_4kakuStDFE.enabled = false;
    }

    // Update is called once per frame
    void Update() 
    {

        henka(kyotu.rrCount);
        Debug.Log("M1_4RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count) 
    {
        //m1_3のときのみ実行
        if (kyotu.mojiSwitch == 3 & kyotu.MCount == 3) 
        {
            if (count == 0) 
            {
                reset();
            }
            else if (count == 1) //henka1
            {
                reset();
                
                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 2) {
                reset();
                
                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 3) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                //rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                //rrM1_4LineFD.material = MColor4;

                
                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 4) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 5) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 6) {//henka6w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                //0019_99_1：shape2dで色をスクリプトから変更する

                //shape.settings.fillColor = new Color32(255,255,255,0);
                //rrM1_4kakuStBAC.material = MColor5;
                //rrM1_4kakuStEDF.material = MColor5;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 7) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 8) {//henka8
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 9) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 10) {//henka10w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 11) {//henka11w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 12) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 13) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 14) {//henka14w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                rrM1_4kakuACB.enabled = true;
                rrM1_4kakuDFE.enabled = true;

                rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 15) {//henka15w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuDEF.enabled = true;
                rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 16) {//16w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuDEF.enabled = true;
                rrM1_4kakuDFE.enabled = true;

                rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 17) {//17w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuDEF.enabled = true;
                rrM1_4kakuDFE.enabled = true;

                rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 18) {//henka18w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;


            } else if (count == 19) {//henka19w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_4LineAB.material = Line2NewM10DarkBlue;
                //rrM1_4LineCA.material = Line3NewM7DarkPurple;
                //rrM1_4LineDE.material = Line2NewM10DarkBlue;
                //rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                //rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 20) {//henka20w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_4LineAB.material = Line2NewM10DarkBlue;
                //rrM1_4LineCA.material = Line3NewM7DarkPurple;
                //rrM1_4LineDE.material = Line2NewM10DarkBlue;
                //rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                //rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 21) {//henka21w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_4LineAB.material = Line2NewM10DarkBlue;
                //rrM1_4LineCA.material = Line3NewM7DarkPurple;
                //rrM1_4LineDE.material = Line2NewM10DarkBlue;
                //rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                //rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 22) {//henka22w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                //rrM1_4LineCA.material = Line3NewM7DarkPurple;
                //rrM1_4LineDE.material = Line2NewM10DarkBlue;
                //rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                //rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 23) {//henka23
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                //rrM1_4LineDE.material = Line2NewM10DarkBlue;
                //rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                //rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 24) {//henka24
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                //rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                //rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 25) {//henka25w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                //rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 26) {//henka26w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                //rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 27) {//henka27w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                //rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 28) {//henka28w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 29) {//henka29w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 30) {//henka30w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 31) {//henka31
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 32) {//henka32
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 33) {//henka33
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 34) {//henka34
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 35) {//henka35
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 36) {//henka36
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 37) {//henka37
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuDEF.enabled = true;
                rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 38) {//henka38
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuDEF.enabled = true;
                rrM1_4kakuDFE.enabled = true;

                rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 39) {//henka39
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 40) {//henka40w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 41) {//henka41
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 42) {//henka42
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 43) {//henka43
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 44) {//henka44
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 45) {//henka45
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 46) {//henka46
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStA.enabled = true;

                rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStD.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 47) {//henka47
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 48) {//henka48
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 49) {//henka49
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 50) {//henka50w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 51) {//henka51
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 52) {//henka52
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 53) {//henka53
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 54) {//henka54
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 55) {//henka55
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 56) {//henka56
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 57) {//henka57
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 58) {//henka58
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 59) {//henka59
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 60) {//henka60w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 61) {//henka61
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 62) {//henka62
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 63) {//henka63
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 64) {//henka64
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 65) {//henka65w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 66) {//henka66w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 67) {//henka67w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 68) {//henka68w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 69) {//henka69w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 70) {//henka70w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 71) {//henka71w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 72) {//henka72w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                //rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 73) {//henka73w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStE.enabled = true;

                //rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 74) {//henka74w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStE.enabled = true;

                //rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 75) {//henka75w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                //rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 76) {//henka76w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                //rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 77) {//henka77w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                //rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 78) {//henka78w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                //rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 79) {//henka79w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStB.enabled = true;

                rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStE.enabled = true;

                rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = true;

                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 80) {//henka80w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                //rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = true;

                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 81) {//henka81w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                //rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = true;

                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 82) {//henka82w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                
                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                //rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = true;

                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 83) {//henka83w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                
                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                //rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = true;

                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 84) {//henka84w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                //rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = true;

                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 85) {//henka85
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                //rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = true;

                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 86) {//henka86
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                //rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = true;

                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 87) {//henka87w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                //rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = true;

                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 88) {//henka88w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStE.enabled = true;

                //rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = true;

                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 89) {//henka89w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStE.enabled = true;

                //rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = true;

                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 90) {//henka90w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStE.enabled = true;

                //rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = true;

                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 91) {//henka91w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStE.enabled = true;

                //rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = true;

                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 92) {//henka92w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStE.enabled = true;

                //rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = true;

                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuDEF.enabled = true;
                rrM1_4kakuDFE.enabled = true;

                rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 93) {//henka93w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStE.enabled = true;

                //rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = true;

                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuDEF.enabled = true;
                rrM1_4kakuDFE.enabled = true;

                rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 94) {//henka94w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStB.enabled = true;

                //rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStC.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStE.enabled = true;

                //rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = true;

                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = true;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuDEF.enabled = true;
                rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 95) //henka95w
            {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                //rrM1_4LineAB.material = Line2NewM10DarkBlue;
                //rrM1_4LineCA.material = Line3NewM7DarkPurple;
                //rrM1_4LineDE.material = Line2NewM10DarkBlue;
                //rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;
                

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 96) {//96w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;
                

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 97) {//97w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;
                

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 98) {//98w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;
                

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 99) {//99w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;
                

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 100) {
                reset();

                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;
                

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 101) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;
                

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 102) {//henka102
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;
                

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 103) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;
                

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 104) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;
                

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 105) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;
                

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 106) {//henka106
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;
                

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 107) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;
                


                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 108) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;
                

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                rrM1_4kakuACB.enabled = true;
                rrM1_4kakuDFE.enabled = true;

                rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 109) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;
                

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuDEF.enabled = true;
                rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 110) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;
                


                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuDEF.enabled = true;
                rrM1_4kakuDFE.enabled = true;

                rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 111) {//henka111
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;
                

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuDEF.enabled = true;
                rrM1_4kakuDFE.enabled = true;

                rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 112) {//henka112w
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = Line2NewM10DarkBlue;
                rrM1_4LineCA.material = Line3NewM7DarkPurple;
                rrM1_4LineDE.material = Line2NewM10DarkBlue;
                rrM1_4LineFD.material = Line3NewM7DarkPurple;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;
                


                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuDEF.enabled = true;
                rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            }
        }
    }
}
