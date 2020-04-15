using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test4 : MonoBehaviour
{
    //k0014_2 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject premoji;

    //k0016_99_1_1：listの宣言
    //prehubとして呼び出したmojipanelに当てはめるオブジェ
    List<GameObject> mojiPanel = new List<GameObject>();

    void Start()
    {
        //プレハブを使う
        //k0016_99_1_1_1：list新しい値を入れる
        mojiPanel.Add(Instantiate(premoji) as GameObject);

        //k0014_2_1_1: オブジェの名前を変化させる
        mojiPanel[0].name = "mojiPanel";

        //Debug.Log("wowwww;;"+ mojiPanel[0].name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
