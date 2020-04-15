using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_40_KJP_3RR : MonoBehaviour
{
    //M1_5RRにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    private Transform KJP_3Move;

    void Start() 
    {
        KJP_3Move = this.gameObject.GetComponent<Transform>();
    }

    void Update() 
    {
        //meidai  m1_5 count4以下
        if (kyotu.mojiSwitch == 1 && kyotu.MCount == 2) {
            KJP_3Move.position = new Vector3(10f, 2.5f, -1);
        } else {
            KJP_3Move.position = new Vector3(20.35f, -3.74f, 0);
        }
        //Debug.Log("KJP_3RR::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
}
