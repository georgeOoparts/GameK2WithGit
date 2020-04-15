using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_27_M1_3preHenka : MonoBehaviour
{
    //M1_3Objectにアタッチ、countで変化させる

    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    //lineを当てはめる
    public GameObject M1_3preLineS;
    public GameObject M1_3preLineStS;

    public GameObject M1_3preLineL;
    public GameObject M1_3preLineStL;

    public GameObject M1_3preLineS2;
    public GameObject M1_3preLineStS2;

   

    //renderer当てはめ
    //＞linerederer当てはめ
    private Renderer rrM1_3preLineS;
    private Renderer rrM1_3preLineStS;

    private Renderer rrM1_3preLineL;
    private Renderer rrM1_3preLineStL;

    private Renderer rrM1_3preLineS2;
    private Renderer rrM1_3preLineStS2;

    

    void Start()
    {
        //gameobjectをredererに当てはめていく
        //＞line：gameobjectをredererに当てはめていく
        rrM1_3preLineS = M1_3preLineS.GetComponent<Renderer>();
        rrM1_3preLineStS = M1_3preLineStS.GetComponent<Renderer>();

        rrM1_3preLineL = M1_3preLineL.GetComponent<Renderer>();
        rrM1_3preLineStL = M1_3preLineStL.GetComponent<Renderer>();

        rrM1_3preLineS2 = M1_3preLineS2.GetComponent<Renderer>();
        rrM1_3preLineStS2 = M1_3preLineStS2.GetComponent<Renderer>();

        


    }

    // Update is called once per frame
    void Update()
    {
        henka(kyotu.rrCount);
        //Debug.Log("M1_3Henka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
    //リセット表示を全部消すメソッド　kyotu.rrcount-----------------------------
    private void reset() 
    {
        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;

        //gameobjectを見えなくする
        //＞line：gameobjectを見えなくする
        rrM1_3preLineS.enabled = false;
        rrM1_3preLineStS.enabled = false;

        rrM1_3preLineL.enabled = false;
        rrM1_3preLineStL.enabled = false;

        rrM1_3preLineS2.enabled = false;
        rrM1_3preLineStS2.enabled = false;

        

    }
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count) {
        //m1_2のときのみ実行
        if (kyotu.mojiSwitch == 3 & kyotu.MCount == 2 & count<=6) {
            if (count == 0) {
                reset();
            }
            else if (count ==1) {
                reset();
                //gameobjectを見えるようにする
                rrM1_3preLineS.enabled = true;
                rrM1_3preLineStS.enabled = kyotuEla.tenmetuOnOff;

                rrM1_3preLineL.enabled = true;
                rrM1_3preLineStL.enabled = kyotuEla.tenmetuOnOff;
                
            } else if (count == 2) {
                reset();
                //gameobjectを見えるようにする
                rrM1_3preLineS.enabled = true;
                rrM1_3preLineStS.enabled = kyotuEla.tenmetuOnOff;

                rrM1_3preLineL.enabled = true;
                rrM1_3preLineStL.enabled = kyotuEla.tenmetuOnOff;

            } else if (count == 3) {
                reset();
                //gameobjectを見えるようにする
                rrM1_3preLineS.enabled = true;
                rrM1_3preLineStS.enabled = kyotuEla.tenmetuOnOff;

                rrM1_3preLineL.enabled = true;
                rrM1_3preLineStL.enabled = kyotuEla.tenmetuOnOff;

            } else if (count == 4) {
                reset();
                //gameobjectを見えるようにする
                rrM1_3preLineS.enabled = true;
                //rrM1_3preLineStS.enabled = kyotuEla.tenmetuOnOff;

                rrM1_3preLineL.enabled = true;
                rrM1_3preLineStL.enabled = kyotuEla.tenmetuOnOff;

            }
            else if (count == 5) {
                reset();
                //gameobjectを見えるようにする
                rrM1_3preLineS.enabled = true;
                rrM1_3preLineL.enabled = true;

                rrM1_3preLineStS.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3preLineStL.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3preLineStL.enabled = true;
            } else if (count == 6) {
                reset();
                //gameobjectを見えるようにする
                rrM1_3preLineS.enabled = true;
                rrM1_3preLineL.enabled = true;

                rrM1_3preLineStS.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3preLineStS.enabled = true;

                //rrM1_3preLineStL.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_3preLineStL.enabled = true;

                rrM1_3preLineStS2.enabled = kyotuEla.tenmetuOnOff;
            }
        }
    }
}
