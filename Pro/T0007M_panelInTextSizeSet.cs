using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目

public class T0007M_panelInTextSizeSet : MonoBehaviour
{
    //テキストを子にもつ、textPanelのサイズを　子のＴＥＸＴにばっちり合わせる。
    //テキストオブジェを子に持つpanelオブジェにアタッチ
    //このオブジェのアンカーをストレッチにするとうまく動かない。
    //このオブジェのアンカーはやはりshift　左上。
    //子のTEXTのアンカーはshift 中央　ミドルセンター
    //子のTEXTのtextスクリプト＞パラグラフ＞アリグメント＞ミドルセンター
    GameObject kodomoObj;
    //k2_a:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text kodomoText;
    //k4_a:どこかに書いてあるRectTransformの変数を作る
    RectTransform Rt;

    RectTransform rtKodomoText;

    public float yohaku = 10;

    void Start() {
        //k8_a:子(孫、ひ孫　無限にＯＫ)になっているＯＢＪを得る。
        kodomoObj = this.gameObject.transform.GetChild(0).gameObject;
        //k2_aa:Textをこのオブジェクトで使うためのおまじない
        kodomoText = kodomoObj.GetComponent<Text>();
        //k4_aa:このオブジェクトにＵＩ専門であるRectTransformをアタッチ
        Rt = this.gameObject.GetComponent<RectTransform>();

        rtKodomoText = kodomoObj.GetComponent<RectTransform>();
    }
    void Update() 
    {
        //子ＴＥＸＴの幅が０でなければ（子テキストが空でなければ）
        if (kodomoText.preferredWidth != 0) 
        {
            //アンカーがストレッチ以外ならスクリーン座標の値でパネルの幅、高さを
            //指定できる。アンカー左上以外　あり得ないぜええ
            //k4_aab:uiの幅、高さをスクリーン値で変形させる
            //k2_aab1:スクリーン座標のテキスト幅   text.preferredWidth
            //k2_aab2:スクリーン座標のテキスト高さ text.preferredHeight
            Rt.sizeDelta
                = new Vector2(kodomoText.preferredWidth + yohaku
                , kodomoText.preferredHeight + yohaku);
        } 
        else 
        {
            //子ＴＥＸＴが空ならば、このＰＡＮＥＬの幅０でＯＫ
            //k4_aab:uiの幅、高さをスクリーン値で変形させる
            //k2_aab2:スクリーン座標のテキスト高さ text.preferredHeight
            Rt.sizeDelta = new Vector2(0, kodomoText.preferredHeight + yohaku);
        }
    }
}
