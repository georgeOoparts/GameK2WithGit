using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_19_M1_2preRRHenka : MonoBehaviour {
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    public GameObject M1_2preLine;
    public GameObject M1_2preSLine;

    public GameObject M1_2preLine2;
    public GameObject M1_2preSLine2;

    public GameObject M1_2prePoint;

    //いちいちunityで当てはめなきゃ駄目　↑---------------
    //線分を出したり消したりするときに使う Rendererを当てはめる

    private Renderer rrM1_2preLine;
    private Renderer rrM1_2preSLine;

    private Renderer rrM1_2preLine2;
    private Renderer rrM1_2preSLine2;

    //点のrenderer
    private Renderer rrM1_2prePoint;

    void Start() {
        //redererを当てはめていく

        rrM1_2preLine = M1_2preLine.GetComponent<Renderer>();
        rrM1_2preSLine = M1_2preSLine.GetComponent<Renderer>();

        rrM1_2preLine2 = M1_2preLine2.GetComponent<Renderer>();
        rrM1_2preSLine2 = M1_2preSLine2.GetComponent<Renderer>();

        rrM1_2prePoint = M1_2prePoint.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update() {
        henka(kyotu.rrCount);
        //Debug.Log("M1_2hon_MS::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);
    }
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count) 
    {
        //m1_2のときのみ実行
        if (kyotu.mojiSwitch==3 &kyotu.MCount==1) 
        {
            if (count == 0) 
            {
                reset();
            } 
            else if (count == 1) 
            {
                reset();
                rrM1_2preLine.enabled = true;
                rrM1_2preSLine.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_2prePoint.enabled = true;
            } 
            else if (count == 2) {
                reset();
                rrM1_2preLine.enabled = true;
                //rrM1_2preSLine.enabled = kyotuEla.tenmetuOnOff;

                rrM1_2preLine2.enabled = true;
                rrM1_2preSLine2.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_2prePoint.enabled = true;
            } 
            else if (count == 3) {
                reset();
                rrM1_2preLine.enabled = true;
                //rrM1_2preSLine.enabled = kyotuEla.tenmetuOnOff;

                rrM1_2preLine2.enabled = true;
                //rrM1_2preSLine2.enabled = kyotuEla.tenmetuOnOff;

                rrM1_2prePoint.enabled = kyotuEla.tenmetuOnOff;
            } 
            else if (count == 4) {
                reset();
                rrM1_2preLine.enabled = true;
                //rrM1_2preSLine.enabled = kyotuEla.tenmetuOnOff;

                rrM1_2preLine2.enabled = true;
                rrM1_2preSLine2.enabled = kyotuEla.tenmetuOnOff;

                rrM1_2prePoint.enabled = true;
            }
        }
        
    }
    //リセット表示を全部消すメソッド　kyotu.rrcount-----------------------------
    private void reset() 
    {
        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;
        rrM1_2preLine.enabled = false;
        rrM1_2preSLine.enabled = false;

        rrM1_2preLine2.enabled = false;
        rrM1_2preSLine2.enabled = false;

        rrM1_2prePoint.enabled = false;

    }
}
