using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_36_KJP_1RR : MonoBehaviour
{
    //M1_5RRにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    private Transform KJP_1Move;
    void Start() {
        KJP_1Move = this.gameObject.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update() {
        //meidai  m1_5 count4以下
        if (kyotu.mojiSwitch == 1 && kyotu.MCount == 0) {
            KJP_1Move.position = new Vector3(10f, 2.5f, -1);
        } else {
            KJP_1Move.position = new Vector3(20.35f, -3.74f, 0);
        }
        //Debug.Log("KJP_1RR::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
}
