using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_47_KA_3RRHenka : MonoBehaviour {
    //M1_5RRにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    public GameObject KA_3LineA1;
    public GameObject KA_3LineA2;
    public GameObject KA_3LineA3;

    public GameObject KA_3LineB1;
    public GameObject KA_3LineB2;
    public GameObject KA_3LineB3;

    public GameObject KA_3StLineA1;
    public GameObject KA_3StLineA2;
    public GameObject KA_3StLineA3;

    public GameObject KA_3StLineB1;
    public GameObject KA_3StLineB2;
    public GameObject KA_3StLineB3;

    private Renderer rrKA_3LineA1;
    private Renderer rrKA_3LineA2;
    private Renderer rrKA_3LineA3;

    private Renderer rrKA_3LineB1;
    private Renderer rrKA_3LineB2;
    private Renderer rrKA_3LineB3;

    private Renderer rrKA_3StLineA1;
    private Renderer rrKA_3StLineA2;
    private Renderer rrKA_3StLineA3;

    private Renderer rrKA_3StLineB1;
    private Renderer rrKA_3StLineB2;
    private Renderer rrKA_3StLineB3;
    void Start() {
        rrKA_3LineA1 = KA_3LineA1.GetComponent<Renderer>();
        rrKA_3LineA2 = KA_3LineA2.GetComponent<Renderer>();
        rrKA_3LineA3 = KA_3LineA3.GetComponent<Renderer>();

        rrKA_3LineB1 = KA_3LineB1.GetComponent<Renderer>();
        rrKA_3LineB2 = KA_3LineB2.GetComponent<Renderer>();
        rrKA_3LineB3 = KA_3LineB3.GetComponent<Renderer>();

        rrKA_3StLineA1 = KA_3StLineA1.GetComponent<Renderer>();
        rrKA_3StLineA2 = KA_3StLineA2.GetComponent<Renderer>();
        rrKA_3StLineA3 = KA_3StLineA3.GetComponent<Renderer>();

        rrKA_3StLineB1 = KA_3StLineB1.GetComponent<Renderer>();
        rrKA_3StLineB2 = KA_3StLineB2.GetComponent<Renderer>();
        rrKA_3StLineB3 = KA_3StLineB3.GetComponent<Renderer>();
    }

    //リセット表示を全部消すメソッド　kyotu.rrcount------resetW-----------------------
    private void reset() {
        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;

        //gameobjectを見えなくする
        //＞line：gameobjectを見えなくする
        
        rrKA_3LineA1.enabled = false;
        rrKA_3LineA2.enabled = false;
        rrKA_3LineA3.enabled = false;

        rrKA_3LineB1.enabled = false;
        rrKA_3LineB2.enabled = false;
        rrKA_3LineB3.enabled = false;

        rrKA_3StLineA1.enabled = false;
        rrKA_3StLineA2.enabled = false;
        rrKA_3StLineA3.enabled = false;

        rrKA_3StLineB1.enabled = false;
        rrKA_3StLineB2.enabled = false;
        rrKA_3StLineB3.enabled = false;
    }
    void Update() {
        henka(kyotu.rrCount);
        //Debug.Log("KA_1RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }

    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count) {//henkaW
        //m1_3のときのみ実行
        if (kyotu.mojiSwitch == 0 & kyotu.MCount == 1) {
            if (count == 0) {
                reset();
            } else if (count == 1) {//henka1
                reset();
                rrKA_3LineA1.enabled = true;

                rrKA_3StLineA1.enabled = kyotuEla.tenmetuOnOff;

                rrKA_3LineB1.enabled = true;

                rrKA_3StLineB1.enabled = kyotuEla.tenmetuOnOff;

            } else if (count == 2) {//henka2
                reset();
                rrKA_3LineA1.enabled = true;

                rrKA_3LineA2.enabled = true;

                //rrKA_3StLineA1.enabled = kyotuEla.tenmetuOnOff;
                rrKA_3StLineA1.enabled = false;

                rrKA_3StLineA2.enabled = kyotuEla.tenmetuOnOff;
                //rrKA_3StLineA2.enabled = false;

                rrKA_3LineB1.enabled = true;

                rrKA_3LineB2.enabled = true;

                //rrKA_3StLineB1.enabled = kyotuEla.tenmetuOnOff;
                rrKA_3StLineB1.enabled = false;

                rrKA_3StLineB2.enabled = kyotuEla.tenmetuOnOff;
                //rrKA_3StLineB2.enabled = false;
            } else if (count == 3) {//henka3
                reset();
                rrKA_3LineA1.enabled = true;

                rrKA_3LineA2.enabled = true;

                //rrKA_3StLineA1.enabled = kyotuEla.tenmetuOnOff;
                rrKA_3StLineA1.enabled = false;

                //rrKA_3StLineA2.enabled = kyotuEla.tenmetuOnOff;
                rrKA_3StLineA2.enabled = false;

                rrKA_3StLineA3.enabled = kyotuEla.tenmetuOnOff;
                //rrKA_3StLineA3.enabled = false;

                rrKA_3LineB1.enabled = true;

                rrKA_3LineB2.enabled = true;

                //rrKA_3StLineB1.enabled = kyotuEla.tenmetuOnOff;
                rrKA_3StLineB1.enabled = false;

                //rrKA_3StLineB2.enabled = kyotuEla.tenmetuOnOff;
                //rrKA_3StLineB2.enabled = false;

                rrKA_3StLineB3.enabled = kyotuEla.tenmetuOnOff;
                //rrKA_3StLineB3.enabled = false;
            } else if (count == 4) {//henka4
                reset();
                rrKA_3LineA1.enabled = true;

                rrKA_3LineA2.enabled = true;

                //rrKA_3StLineA1.enabled = kyotuEla.tenmetuOnOff;
                rrKA_3StLineA1.enabled = false;

                //rrKA_3StLineA2.enabled = kyotuEla.tenmetuOnOff;
                rrKA_3StLineA2.enabled = false;

                rrKA_3StLineA3.enabled = kyotuEla.tenmetuOnOff;
                //rrKA_3StLineA3.enabled = false;

                rrKA_3LineB1.enabled = true;

                rrKA_3LineB2.enabled = true;

                //rrKA_3StLineB1.enabled = kyotuEla.tenmetuOnOff;
                rrKA_3StLineB1.enabled = false;

                //rrKA_3StLineB2.enabled = kyotuEla.tenmetuOnOff;
                //rrKA_3StLineB2.enabled = false;

                rrKA_3StLineB3.enabled = kyotuEla.tenmetuOnOff;
                //rrKA_3StLineB3.enabled = false;
            } else if (count == 5) {//henka5
                reset();
                rrKA_3LineA1.enabled = true;

                rrKA_3LineA2.enabled = true;

                //rrKA_3StLineA1.enabled = kyotuEla.tenmetuOnOff;
                rrKA_3StLineA1.enabled = false;

                //rrKA_3StLineA2.enabled = kyotuEla.tenmetuOnOff;
                rrKA_3StLineA2.enabled = false;

                //rrKA_3StLineA3.enabled = kyotuEla.tenmetuOnOff;
                rrKA_3StLineA3.enabled = false;

                rrKA_3LineB1.enabled = true;

                rrKA_3LineB2.enabled = true;

                //rrKA_3StLineB1.enabled = kyotuEla.tenmetuOnOff;
                rrKA_3StLineB1.enabled = false;

                //rrKA_3StLineB2.enabled = kyotuEla.tenmetuOnOff;
                rrKA_3StLineB2.enabled = false;

                //rrKA_3StLineB3.enabled = kyotuEla.tenmetuOnOff;
                rrKA_3StLineB3.enabled = false;
            }
        }
    }
}