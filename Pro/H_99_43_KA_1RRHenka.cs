using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_43_KA_1RRHenka : MonoBehaviour {
    //M1_5RRにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    public GameObject KA_1Line1;
    public GameObject KA_1Line2;
    public GameObject KA_1Line3;

    public GameObject KA_1StLine1;
    public GameObject KA_1StLine2;
    public GameObject KA_1StLine3;

    private Renderer rrKA_1Line1;
    private Renderer rrKA_1Line2;
    private Renderer rrKA_1Line3;

    private Renderer rrKA_1StLine1;
    private Renderer rrKA_1StLine2;
    private Renderer rrKA_1StLine3;

    void Start() {
        rrKA_1Line1 = KA_1Line1.GetComponent<Renderer>();
        rrKA_1Line2 = KA_1Line2.GetComponent<Renderer>();
        rrKA_1Line3 = KA_1Line3.GetComponent<Renderer>();

        rrKA_1StLine1 = KA_1StLine1.GetComponent<Renderer>();
        rrKA_1StLine2 = KA_1StLine2.GetComponent<Renderer>();
        rrKA_1StLine3 = KA_1StLine3.GetComponent<Renderer>();
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

        rrKA_1Line1.enabled = false;
        rrKA_1Line2.enabled = false;
        rrKA_1Line3.enabled = false;

        rrKA_1StLine1.enabled = false;
        rrKA_1StLine2.enabled = false;
        rrKA_1StLine3.enabled = false;


    }
    void Update() {
        henka(kyotu.rrCount);
        //Debug.Log("KA_1RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }

    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count) {//henkaW
        //m1_3のときのみ実行
        if (kyotu.mojiSwitch == 0 & kyotu.MCount == 0) {
            if (count == 0) {
                reset();
            } else if (count == 1) {//henka1
                reset();
                rrKA_1Line1.enabled = true;
                rrKA_1Line2.enabled = true;
                //rrKA_1Line3.enabled = true;

                rrKA_1StLine1.enabled = kyotuEla.tenmetuOnOff;
                rrKA_1StLine2.enabled = kyotuEla.tenmetuOnOff;
                //rrKA_1StLine3.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 2) {//henka2
                reset();
                rrKA_1Line1.enabled = true;
                rrKA_1Line2.enabled = true;
                rrKA_1Line3.enabled = true;

                rrKA_1StLine1.enabled = kyotuEla.tenmetuOnOff;
                //rrKA_1StLine1.enabled = false;

                //rrKA_1StLine2.enabled = kyotuEla.tenmetuOnOff;
                rrKA_1StLine3.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 3) {//henka3
                reset();
                rrKA_1Line1.enabled = true;
                rrKA_1Line2.enabled = true;
                rrKA_1Line3.enabled = true;

                //rrKA_1StLine1.enabled = kyotuEla.tenmetuOnOff;
                //rrKA_1StLine1.enabled = false;

                rrKA_1StLine2.enabled = kyotuEla.tenmetuOnOff;
                //rrKA_1StLine2.enabled = false;

                rrKA_1StLine3.enabled = kyotuEla.tenmetuOnOff;
                //rrKA_1StLine3.enabled = false;

            } else if (count == 4) {//henka4
                reset();
                rrKA_1Line1.enabled = true;
                rrKA_1Line2.enabled = true;
                rrKA_1Line3.enabled = true;

                //rrKA_1StLine1.enabled = kyotuEla.tenmetuOnOff;
                rrKA_1StLine1.enabled = false;

                //rrKA_1StLine2.enabled = kyotuEla.tenmetuOnOff;
                rrKA_1StLine1.enabled = false;

                //rrKA_1StLine3.enabled = kyotuEla.tenmetuOnOff;
                rrKA_1StLine1.enabled = false;
            }
        }
    }
}
