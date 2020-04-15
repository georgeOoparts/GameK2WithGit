using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_17_M1_1_Henka : MonoBehaviour
{//atama

    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    public GameObject wcLineAB;
    public GameObject wcLineSAB;

    public GameObject wcLineBC;
    public GameObject wcLineSBC;

    public GameObject wcLineCA;
    public GameObject wcLineSCA;

    //public GameObject wcLineAP;
    //public GameObject wcLineSAP;

    //zukei のポイントを表すgameobject
    //アタッチするのはPPRRPointAであることに注意

    public GameObject M1_1StPointA;
    public GameObject wcPointA;
    public GameObject wcTextA;

    public GameObject M1_1StPointB;
    public GameObject wcPointB;
    public GameObject wcTextB;

    public GameObject M1_1StPointC;
    public GameObject wcPointC;
    public GameObject wcTextC;

    public GameObject M1_1StPointD;
    public GameObject wcPointD;
    public GameObject wcTextD;

    public GameObject M1_1StPointE;
    public GameObject wcPointE;
    public GameObject wcTextE;

    public GameObject wcCylinder1;
    public GameObject stWcCylinder1;//強調用

    public GameObject wcCylinder2;
    public GameObject stWcCylinder2;//強調用

    //いちいちunityで当てはめなきゃ駄目　↑---------------
    //線分を出したり消したりするときに使う Rendererを当てはめる
    //線のrenderer
    private Renderer rrlineAB;
    private Renderer rrlineSAB;

    private Renderer rrlineBC;
    private Renderer rrlineSBC;

    private Renderer rrlineCA;
    private Renderer rrlineSCA;

    //点のrenderer
    private Renderer rrM1_1StPointA;
    private Renderer rrPointA;
    private Renderer rrTextA;

    private Renderer rrM1_1StPointB;
    private Renderer rrPointB;
    private Renderer rrTextB;

    private Renderer rrM1_1StPointC;
    private Renderer rrPointC;
    private Renderer rrTextC;

    private Renderer rrM1_1StPointD;
    private Renderer rrPointD;
    private Renderer rrTextD;

    private Renderer rrM1_1StPointE;
    private Renderer rrPointE;
    private Renderer rrTextE;

    //後ろの２つの円のrenderer
    private Renderer rrCylinder1;
    private Renderer rrStCylinder1;

    private Renderer rrCylinder2;
    private Renderer rrStCylinder2;

    void Start()
    {
        //redererを当てはめていく
        rrlineAB = wcLineAB.GetComponent<Renderer>();
        rrlineSAB = wcLineSAB.GetComponent<Renderer>();

        rrlineBC = wcLineBC.GetComponent<Renderer>();
        rrlineSBC = wcLineSBC.GetComponent<Renderer>();

        rrlineCA = wcLineCA.GetComponent<Renderer>();
        rrlineSCA = wcLineSCA.GetComponent<Renderer>();

        rrM1_1StPointA = M1_1StPointA.GetComponent<Renderer>();
        rrPointA = wcPointA.GetComponent<Renderer>();
        rrTextA = wcTextA.GetComponent<Renderer>();

        rrM1_1StPointB = M1_1StPointB.GetComponent<Renderer>();
        rrPointB = wcPointB.GetComponent<Renderer>();
        rrTextB = wcTextB.GetComponent<Renderer>();

        rrM1_1StPointC = M1_1StPointC.GetComponent<Renderer>();
        rrPointC = wcPointC.GetComponent<Renderer>();
        rrTextC = wcTextC.GetComponent<Renderer>();

        rrM1_1StPointD = M1_1StPointD.GetComponent<Renderer>();
        rrPointD = wcPointD.GetComponent<Renderer>();
        rrTextD = wcTextD.GetComponent<Renderer>();

        rrM1_1StPointE = M1_1StPointE.GetComponent<Renderer>();
        rrPointE = wcPointE.GetComponent<Renderer>();
        rrTextE = wcTextE.GetComponent<Renderer>();

        // 後ろの２つの円のrenderer
        rrCylinder1 = wcCylinder1.GetComponent<Renderer>();
        rrStCylinder1 = stWcCylinder1.GetComponent<Renderer>();

        rrCylinder2 = wcCylinder2.GetComponent<Renderer>();
        rrStCylinder2 = stWcCylinder2.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        henka(kyotu.rrCount);


    }
    //リセット表示を全部消すメソッド　kyotu.rrcount-----------------------------
    private void reset()
    {//resetw
        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;
        rrlineAB.enabled = false;
        rrlineSAB.enabled = false;

        rrlineBC.enabled = false;
        rrlineSBC.enabled = false;

        rrlineCA.enabled = false;
        rrlineSCA.enabled = false;

        rrM1_1StPointA.enabled = false;
        rrPointA.enabled = false;
        rrTextA.enabled = false;

        rrM1_1StPointB.enabled = false;
        rrPointB.enabled = false;
        rrTextB.enabled = false;

        rrM1_1StPointC.enabled = false;
        rrPointC.enabled = false;
        rrTextC.enabled = false;

        rrM1_1StPointD.enabled = false;
        rrPointD.enabled = false;
        rrTextD.enabled = false;

        rrM1_1StPointE.enabled = false;
        rrPointE.enabled = false;
        rrTextE.enabled = false;

        // 後ろの２つの円のrenderer
        rrCylinder1.enabled = false;
        rrStCylinder1.enabled = false;

        rrCylinder2.enabled = false;
        rrStCylinder2.enabled = false;
    }
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count)
    {
        //m1_1のときのみ実行
        if (kyotu.mojiSwitch == 3 & kyotu.MCount == 0)
        {
            if (kyotu.rrCount == 5)//henka5w 
            {
                reset();
            }
            else if (kyotu.rrCount == 6)
            {
                reset();
                rrlineAB.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 7)
            {
                reset();
                rrlineAB.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 8)
            {
                reset();
                rrlineAB.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 9)
            {
                reset();
                rrlineAB.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 10)
            {//henka10w
                reset();
                rrlineAB.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 11)
            {
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 12)
            {
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 13)
            {
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 14)
            {//henka14w
                reset();
                rrlineAB.enabled = true;
                //rrlineBC.enabled = true;
                //rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;

                rrPointA.enabled = true;

                rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 15)
            {//henka15w
                reset();
                rrlineAB.enabled = true;
                //rrlineBC.enabled = true;
                //rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;

                rrPointA.enabled = true;

                rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 16)
            {//henka16w
                reset();
                rrlineAB.enabled = true;
                //rrlineBC.enabled = true;
                //rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;

                rrPointA.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_1StPointA.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 17)
            {//henka17w
                reset();
                rrlineAB.enabled = true;
                //rrlineBC.enabled = true;
                //rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;

                rrPointA.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_1StPointA.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 18)
            {//henka18w
                reset();
                rrlineAB.enabled = true;
                //rrlineBC.enabled = true;
                //rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_1StPointA.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;

                rrCylinder1.enabled = true;
                rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 19)
            {//henka19w
                reset();
                rrlineAB.enabled = true;
                //rrlineBC.enabled = true;
                //rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_1StPointA.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;

                rrCylinder1.enabled = true;
                rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 20)
            {//henka20w
                reset();
                rrlineAB.enabled = true;
                //rrlineBC.enabled = true;
                //rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;

                rrCylinder1.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 21)
            {//henka21w
                reset();
                rrlineAB.enabled = true;
                //rrlineBC.enabled = true;
                //rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;

                rrCylinder1.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_1StPointB.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 22)
            {//henka22w
                reset();
                rrlineAB.enabled = true;
                //rrlineBC.enabled = true;
                //rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;

                rrCylinder1.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_1StPointB.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 23)
            {//henka23w
                reset();
                rrlineAB.enabled = true;
                //rrlineBC.enabled = true;
                //rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_1StPointB.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;

            }
            else if (kyotu.rrCount == 24)
            {//henka24w
                reset();
                rrlineAB.enabled = true;
                //rrlineBC.enabled = true;
                //rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_1StPointB.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 25)
            {//henka25w
                reset();
                rrlineAB.enabled = true;
                //rrlineBC.enabled = true;
                //rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 26)
            {//henka26w
                reset();
                rrlineAB.enabled = true;
                //rrlineBC.enabled = true;
                //rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 27)
            {//henka27w
                reset();
                rrlineAB.enabled = true;
                //rrlineBC.enabled = true;
                //rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 28)
            {//henka28w
                reset();
                rrlineAB.enabled = true;
                //rrlineBC.enabled = true;
                //rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 29)
            {//henka29w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 30)
            {//henka30w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 31)
            {//henka31w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 32)
            {//henka32w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 33)
            {//henka33w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 34)
            {//henka34w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 35)
            {//henka35w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;

                rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 36)
            {//henka36w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 37)
            {//henka37w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 38)
            {//henka38w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 39)
            {//henka39w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 40)
            {//henka40w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 41)
            {//henka41w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 42)
            {//henka42w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (kyotu.rrCount == 43)
            {//henka43w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 44)
            {//henka44w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 45)
            {//henka45w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                rrlineSBC.enabled = true;

                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 46)
            {//henka46w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = true;

                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 47)
            {//henka47w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = true;

                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 48)
            {//henka48w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = true;

                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 49)
            {//henka49w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = true;

                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 50)
            {//henka50w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = true;

                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 51)
            {//henka51w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = true;

                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 52)
            {//henka52w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                rrlineSAB.enabled = true;

                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = true;

                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 53)
            {//henka53w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = true;

                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 54)
            {//henka54w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = true;

                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 55)
            {//henka55w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = true;

                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 56)
            {//henka56w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = true;

                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 57)
            {//henka57w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = true;

                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 58)
            {//henka58w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = true;

                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 59)
            {//henka59w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                rrlineSAB.enabled = true;

                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = true;

                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 60)
            {//henka60w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                rrlineSBC.enabled = true;

                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 61)
            {//henka61w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = true;

                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 62)
            {//henka62w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = true;

                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 63)
            {//henka63w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = true;

                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 64)
            {//henka64w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = true;

                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 65)
            {//henka65w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = true;

                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 66)
            {//henka66w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = true;

                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = true;
            }
            else if (kyotu.rrCount == 67)
            {//henka67w
                reset();
                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrCylinder2.enabled = true;

                //rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointA.enabled = true;
                //rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointB.enabled = true;
                //rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_1StPointC.enabled = true;

                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = true;

                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSCA.enabled = true;

                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder1.enabled = true;

                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
                //rrStCylinder2.enabled = true;
            }
        }

    }


}

