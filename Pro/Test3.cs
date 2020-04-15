using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    //UIの位置を画面左上に表示させる
    //UIのアンカーを左上にセットしておく
    //対象のUIにアタッチ
    //k4_1:どこかに書いてあるRectTransformの変数を作る
    RectTransform rt;

    void Start() 
    {
        //k4_1_1:このオブジェクトにＵＩ専門であるRectTransformをアタッチ
        rt = this.gameObject.GetComponent<RectTransform>();
    }

    void Update() 
    {
        //k4_1_1_4:uiをスクリーン値で移動（左上にアンカーセット、下方向は-の値)
        rt.anchoredPosition = new Vector2(0, 0);
    }
}
