using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_20_M1_2RR : MonoBehaviour
{
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    //public H_99_01B_kyotuElapse kyotuEla;
    Transform M1_2RRMove;

    void Start() {
        M1_2RRMove = this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update() 
    {
        //meidai  m1_2 count5以上
        if (kyotu.mojiSwitch == 3 && kyotu.MCount == 1 && kyotu.rrCount >= 6 && kyotu.rrCount <= 82) {
            M1_2RRMove.position = new Vector3(10f, 1.5f,-1);
        } else {
            M1_2RRMove.position = new Vector2(16.35f, -3.74f);
        }
        //Debug.Log("M1_2honMS::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount); 
    }
}
