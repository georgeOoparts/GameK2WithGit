using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_42_KA_1RR : MonoBehaviour {
    //KA_1RRにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    private Transform KA_1Move;

    void Start() {
        KA_1Move = this.gameObject.GetComponent<Transform>();
    }

    void Update() {
        //meidai  m1_5 count4以下
        if (kyotu.mojiSwitch == 0 && kyotu.MCount == 0) {
            KA_1Move.position = new Vector3(10.0f, 2.73f, -1);
        } else {
            KA_1Move.position = new Vector3(20.35f, -3.74f, 0);
        }
        //Debug.Log("KA_1RR::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
}
