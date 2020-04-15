using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_44_KA_4RR : MonoBehaviour
{
    //KA_4RRにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    private Transform KA_4Move;

    void Start() {
        KA_4Move = this.gameObject.GetComponent<Transform>();
    }

    void Update() 
    {
        //meidai  m1_5 count4以下
        if (kyotu.mojiSwitch == 0 && kyotu.MCount == 2) {
            KA_4Move.position = new Vector3(10f, 1f, -1);
        } else {
            KA_4Move.position = new Vector3(20.35f, -3.74f, 0);
        }
        //Debug.Log("KA_4RR::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
}
