using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T0008N_mokujiTextPanelNarabe : MonoBehaviour
{
    //透明なUI：MoveMokujiPanelの子UIのMokujiTextPanel1_1～6を最初に1回定位置に並べ替える
    //透明なUI：MoveMokujiPanelにアタッチ
    //MoveMokujiPanelのアンカーは中央上にセットしておく

    //MokujiTextPanelの列の一番上からのスペース、同時に一番下からのスペース
    public float ueSpaceMokuji = 20f;

    //MokujiTextPanelの列の間のスペース
    public float aidaSpaceMokuji = 20f;

    //MokujiTextPanel1_1～6(アンカー中央上)達が始まる位置が入る
    float startMokujiTextPanel = 0;

    //子UIのMokujiTextPanel1_1～6のRectTransformの変数を作る
    //k4_1:どこかに書いてあるRectTransformの変数を作る
    //k0016_99_1_1：listの宣言
    private List<RectTransform> trMokujiTextPanel = new List<RectTransform>();

    void Start() {
        //k0013_1_1; オブジェに当てはめる；
        //k8_1:子(孫、ひ孫　無限にＯＫ)になっているＯＢＪを得る。
        //自分の直下の子供を得る。(数字は子供オブジェのヒエラルキー：一番上0)
        //k0016_99_1_1_1：list新しい値を入れる
        trMokujiTextPanel.Add(this.gameObject.transform.GetChild(0).GetComponent<RectTransform>());
        trMokujiTextPanel.Add(this.gameObject.transform.GetChild(1).GetComponent<RectTransform>());
        trMokujiTextPanel.Add(this.gameObject.transform.GetChild(2).GetComponent<RectTransform>());
        trMokujiTextPanel.Add(this.gameObject.transform.GetChild(3).GetComponent<RectTransform>());
        trMokujiTextPanel.Add(this.gameObject.transform.GetChild(4).GetComponent<RectTransform>());
        trMokujiTextPanel.Add(this.gameObject.transform.GetChild(5).GetComponent<RectTransform>());

        //まずstartでパネルMokujiTextPanelを一列に並べる
        //最初の上からのスペースを代入（下へ行くほどマイナス）
        startMokujiTextPanel = -ueSpaceMokuji;

        //k4_1_1_4:uiをスクリーン値で移動（中央上にアンカーセット、下方向は-の値)
        //rt.anchoredPosition = new Vector2(190, -145);
        trMokujiTextPanel[0].anchoredPosition = new Vector3(0, startMokujiTextPanel, -0.1f);

        //2番目のstartMokujiTextPanelの座標をstartMokujiTextPanelに代入
        //k4_1_1_2:uiオブジェクトのスクリーン座標高さを得る
        startMokujiTextPanel -= aidaSpaceMokuji;
        startMokujiTextPanel -= trMokujiTextPanel[0].sizeDelta.y;

        trMokujiTextPanel[1].anchoredPosition = new Vector3(0, startMokujiTextPanel, -0.1f);

        //3番目のstartMokujiTextPanelの座標をstartMokujiTextPanelに代入
        startMokujiTextPanel -= aidaSpaceMokuji;
        startMokujiTextPanel -= trMokujiTextPanel[1].sizeDelta.y;

        trMokujiTextPanel[2].anchoredPosition = new Vector3(0, startMokujiTextPanel, -0.1f);

        //4番目のstartMokujiTextPanelの座標をstartMokujiTextPanelに代入
        startMokujiTextPanel -= aidaSpaceMokuji;
        startMokujiTextPanel -= trMokujiTextPanel[2].sizeDelta.y;

        trMokujiTextPanel[3].anchoredPosition = new Vector3(0, startMokujiTextPanel, -0.1f);

        //5番目のstartMokujiTextPanelの座標をstartMokujiTextPanelに代入
        startMokujiTextPanel -= aidaSpaceMokuji;
        startMokujiTextPanel -= trMokujiTextPanel[3].sizeDelta.y;

        trMokujiTextPanel[4].anchoredPosition = new Vector3(0, startMokujiTextPanel, -0.1f);

        //6番目のstartMokujiTextPanelの座標をstartMokujiTextPanelに代入
        startMokujiTextPanel -= aidaSpaceMokuji;
        startMokujiTextPanel -= trMokujiTextPanel[4].sizeDelta.y;

        trMokujiTextPanel[5].anchoredPosition = new Vector3(0, startMokujiTextPanel, -0.1f);
    }
}
