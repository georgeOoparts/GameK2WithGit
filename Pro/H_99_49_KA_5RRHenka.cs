using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_49_KA_5RRHenka : MonoBehaviour {
    //M1_5RRにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    public GameObject KA_5Circle1;
    public GameObject KA_5Circle2;

    public GameObject KA_5StCircle1;
    public GameObject KA_5StCircle2;

    private Renderer rrKA_5Circle1;
    private Renderer rrKA_5Circle2;

    private Renderer rrKA_5StCircle1;
    private Renderer rrKA_5StCircle2;

    void Start() {
        rrKA_5Circle1 = KA_5Circle1.GetComponent<Renderer>();
        rrKA_5Circle2 = KA_5Circle2.GetComponent<Renderer>();

        rrKA_5StCircle1 = KA_5StCircle1.GetComponent<Renderer>();
        rrKA_5StCircle2 = KA_5StCircle2.GetComponent<Renderer>();
    }

    //リセット表示を全部消すメソッド　kyotu.rrcount------resetW-----------------------
    private void reset() {
        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;

        //gameobjectを見えなくする
        //＞line：gameobjectを見えなくす

        rrKA_5Circle1.enabled = false;
        rrKA_5Circle2.enabled = false;

        rrKA_5StCircle1.enabled = false;
        rrKA_5StCircle2.enabled = false;
    }
    void Update() {
        henka(kyotu.rrCount);
        //Debug.Log("KA_5RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);
    }
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count) {//henkaW
        //m1_3のときのみ実行
        if (kyotu.mojiSwitch == 0 & kyotu.MCount == 3) {
            if (count == 0) {
                reset();
            }
            else if (count == 1) {//henka1
                reset();
                //rrKA_5Circle1.enabled = true;
                rrKA_5Circle2.enabled = true;

                //rrKA_5StCircle1.enabled = kyotuEla.tenmetuOnOff;
                rrKA_5StCircle2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 2) {//henka2
                reset();
                rrKA_5Circle1.enabled = true;
                rrKA_5Circle2.enabled = true;

                rrKA_5StCircle1.enabled = kyotuEla.tenmetuOnOff;
                //rrKA_5StCircle2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 3) {//henka3
                reset();
                rrKA_5Circle1.enabled = true;
                rrKA_5Circle2.enabled = true;

                //rrKA_5StCircle1.enabled = kyotuEla.tenmetuOnOff;
                rrKA_5StCircle2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 4) {//henka4
                reset();
                rrKA_5Circle1.enabled = true;
                rrKA_5Circle2.enabled = true;
            }
        }
    }
}

