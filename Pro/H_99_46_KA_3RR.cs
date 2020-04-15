using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_46_KA_3RR : MonoBehaviour
{
    //KA_3RRにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    private Transform KA_3Move;

    void Start() {
        KA_3Move = this.gameObject.GetComponent<Transform>();
    }

    void Update() {
        //meidai  m1_5 count4以下
        if (kyotu.mojiSwitch == 0 && kyotu.MCount == 1) {
            KA_3Move.position = new Vector3(10.0f, 2.5f, -1);
        } else {
            KA_3Move.position = new Vector3(20.35f, -3.74f, 0);
        }
        //Debug.Log("KA_3RR::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
}
