using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_45_KA_4RRHenka : MonoBehaviour
{
    //M1_4RRにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    
    public GameObject KA_4Line1A;

    public GameObject KA_4Line1B;

    public GameObject KA_4Line2;

    public GameObject KA_4Line3A;

    public GameObject KA_4Line3B;

    public GameObject KA_4StLine1A;

    public GameObject KA_4StLine2;

    public GameObject KA_4StLine3A;

    private Renderer rrKA_4Line1A;

    private Renderer rrKA_4Line1B;

    private Renderer rrKA_4Line2;

    private Renderer rrKA_4Line3A;

    private Renderer rrKA_4Line3B;

    private Renderer rrKA_4StLine1A;

    private Renderer rrKA_4StLine2;

    private Renderer rrKA_4StLine3A;

    //k0013_1: 宣言 
    private Transform trKA_4Line1B;

    private Transform trKA_4Line3B;

    public float sitaV = 2f;

    void Start()
    {
        rrKA_4Line1A= KA_4Line1A.GetComponent<Renderer>();
        rrKA_4Line1B = KA_4Line1B.GetComponent<Renderer>();
        rrKA_4Line2 = KA_4Line2.GetComponent<Renderer>();
        rrKA_4Line3A = KA_4Line3A.GetComponent<Renderer>();
        rrKA_4Line3B = KA_4Line3B.GetComponent<Renderer>();
        rrKA_4StLine1A = KA_4StLine1A.GetComponent<Renderer>();
        rrKA_4StLine2 = KA_4StLine2.GetComponent<Renderer>();
        rrKA_4StLine3A = KA_4StLine3A.GetComponent<Renderer>();

        //k0013_1_1;オブジェに当てはめる；
        trKA_4Line1B = KA_4Line1B.gameObject.GetComponent<Transform>();

        trKA_4Line3B = KA_4Line3B.gameObject.GetComponent<Transform>();

        //Debug.Log("KA_4RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);
    }
    //リセット表示を全部消すメソッド　kyotu.rrcount------resetW-----------------------
    private void reset() {
        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;

        //gameobjectを見えなくする
        //＞line：gameobjectを見えなくする

        rrKA_4Line1A.enabled = false;
        rrKA_4Line1B.enabled = false;
        rrKA_4Line2.enabled = false;
        rrKA_4Line3A.enabled = false;
        rrKA_4Line3B.enabled = false;
        rrKA_4StLine1A.enabled = false;
        rrKA_4StLine2.enabled = false;
        rrKA_4StLine3A.enabled = false;
    }
    void Update()
    {
        henka(kyotu.rrCount);
        //Debug.Log("KA_4RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count) {//henkaW
        //m1_3のときのみ実行
        if (kyotu.mojiSwitch == 0 & kyotu.MCount == 2) {
            if (count == 0) {
                reset();
                //line1B,line3Bの位置を調整　ターンが進んだり戻ったりするのの調整
                trKA_4Line1B.localPosition = new Vector3(-1.5f, 3, 0);

                trKA_4Line3B.localPosition = new Vector3(-1.5f, 0, 0);
            } else if (count == 1) {//henka1
                reset();
                
                rrKA_4Line1A.enabled = true;
                rrKA_4Line1B.enabled = true;
                rrKA_4Line3A.enabled = true;
                rrKA_4Line3B.enabled = true;
               

                //line1B,line3Bを移動させるーーーーーーーーーーーーーーーーーーー
                //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
                //trKA_4Line1.position = new Vector3(13f, 0f, trKA_4Line1.position.z);
                if (trKA_4Line1B.localPosition.y > 1.5f) {
                    trKA_4Line1B.position += new Vector3(0, -0.01f * sitaV, 0);
                    trKA_4Line3B.position += new Vector3(0, 0.01f * sitaV, 0);
                } else {
                    trKA_4Line1B.localPosition = new Vector3(-1.5f, 1.5f, 0);
                    trKA_4Line3B.localPosition = new Vector3(-1.5f, 1.5f, 0);
                    //点滅
                    rrKA_4StLine2.enabled = kyotuEla.tenmetuOnOff;
                }
                //ーーーーーーーーーーーーーーーーーーー

            } else if (count == 2) {//henka2
                reset();
                
                //line1B,line3Bの位置を調整　ターンが進んだり戻ったりするのの調整
                trKA_4Line1B.localPosition = new Vector3(-1.5f, 3, 0);

                trKA_4Line3B.localPosition = new Vector3(-1.5f, 0, 0);

                rrKA_4Line1A.enabled = true;
                rrKA_4Line3A.enabled = true;
                rrKA_4Line2.enabled = true;

                //rrKA_4StLine1A.enabled = true;
                rrKA_4StLine1A.enabled = kyotuEla.tenmetuOnOff;

                //rrKA_4StLine3A.enabled = true;
                rrKA_4StLine3A.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 3) {//henka3
                reset();

                rrKA_4Line1A.enabled = true;
                rrKA_4Line3A.enabled = true;
                rrKA_4Line2.enabled = true;

                //rrKA_4StLine1A.enabled = true;
                rrKA_4StLine1A.enabled = kyotuEla.tenmetuOnOff;

                //rrKA_4StLine3A.enabled = true;
                rrKA_4StLine3A.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 4) {//henka4
                reset();

                rrKA_4Line1A.enabled = true;
                rrKA_4Line3A.enabled = true;
                rrKA_4Line2.enabled = true;

            }
        }
    }
}
