using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_38_KJP_2RR : MonoBehaviour
{
    //KJP_2RRにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    private Transform KJP_2Move;
    void Start() {
        KJP_2Move = this.gameObject.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update() {
        //meidai  m1_5 count4以下
        if (kyotu.mojiSwitch == 1 && kyotu.MCount == 1) {
            KJP_2Move.position = new Vector3(10f, 2.5f, -1);
        } else {
            KJP_2Move.position = new Vector3(20.35f, -3.74f, 0);
        }
        //Debug.Log("KJP_2RR::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
}
