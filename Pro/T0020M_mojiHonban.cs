using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class T0020M_mojiHonban : MonoBehaviour
{
    //atama
    //{"", "","","","","","","","","","","","","","","","99","99","99"},

    //クリックした回数に合わせて、文字の表示、文字のバック点滅強調をするプログラム
    //ユクユクはこれを分割させたい。
    //プレハブセット、共通変数セット、最後までクリックしても表示させる。めん土井。

    //testPrehubNarabeとセット
    //このプログラムでmojipanelの内容を変更
    //testPrehubNarabeでそれを並べ替える

    //UIオブジェcanvasworld＞UIオブジェtextpanelの中に
    //UIプレハブpremoji（UIpanel＞UITEXT）を呼び出す
    //UIプレハブの文章の内容を決定する。
    //アタッチ＞UIオブジェcanvasworld＞UIオブジェtextpanel
    //セット＞kyotuhensu、kyotuhensuelapse(maincameraをセット)、UIオブジェプレハブpremoji

    //uitext のプレハブ //canvasはプレハブ化せずにおく、publicにはしておく

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    //このスクリプトをアタッチしたオブジェクトにいちいちこのオブジェクトをアタッチ
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    //k0014_2 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject premoji;

    //k0016_99_1_1：listの宣言
    //prehubとして呼び出したmojipanelに当てはめるオブジェ
    List<GameObject> mojiPanel = new List<GameObject>();

    //mojipanelの子オブジェtextに当てはめるオブジェ
    List<GameObject> kodomoTextObj = new List<GameObject>();

    //textオブジェのコンポTEXTに当てはめるText変数
    List<Text> kodomoTextText = new List<Text>();

    //4次元listを定義
    //List<List<List<List<string>>>> bunsho = new List<List<List<List<string>>>>();
    //k0016_99_2_1：2次元listの宣言
    private List<List<string>> kariList = new List<List<string>>();

    //k0016_99_1_1：listの宣言
    private List<string> M1 = new List<string>();

    void Start()
    {
        //ここから↓ないとバグ出る-----------------
        for (int i = 0; i < 16; i++)
        {
            //プレハブを使う
            //k0016_99_1_1_1：list新しい値を入れる
            mojiPanel.Add(Instantiate(premoji) as GameObject);
            //premojiの子供オブジェであるtextをlistにする。
            kodomoTextObj.Add(mojiPanel[i].transform.GetChild(0).gameObject);
            ////premojiの子供オブジェであるtextのコンポートメントであるTextをlistにする。
            kodomoTextText.Add(kodomoTextObj[i].GetComponent<Text>());

            //k0014_2_1_1 :プレハブをtextPanelの子供にする()
            mojiPanel[i].transform.SetParent(this.gameObject.transform, false);

            //k0014_2_1_1: オブジェの名前を変化させる
            mojiPanel[i].name = "mojiPanel" + i;
            kodomoTextObj[i].name = "text" + i;
        }
        //ここから↑ないとバグ出る-----------------
    }

    //強調する文字が配列の何番目かを入れる変数（強調できる文字数3つ）
    //99は何も文字を強調しないという整数
    private int kyouchouHenkanInt1 = 99;
    private int kyouchouHenkanInt2 = 99;
    private int kyouchouHenkanInt3 = 99;

    void Update()
    {
        //kyotu.mojiSwitch 初期値:3
        //変更
        //公理:0,公準:1,定義:2,meidai:3
        if (Input.GetKeyDown("0"))
        {
            listReset();
            kyotu.rrCount = 0;
            //kyotu.MCount = 0;
            kyotu.mojiSwitch = 0;
        }
        else if (Input.GetKeyDown("1"))
        {
            listReset();
            kyotu.rrCount = 0;
            kyotu.mojiSwitch = 1;
        }
        else if (Input.GetKeyDown("2"))
        {
            listReset();
            kyotu.rrCount = 0;
            kyotu.mojiSwitch = 2;
        }
        else if (Input.GetKeyDown("3"))
        {
            listReset();
            kyotu.rrCount = 0;
            kyotu.mojiSwitch = 3;
        }
        //rrcountを戻すにはとりあえずｂを押す
        else if (Input.GetKeyDown("b"))
        {
            listReset();
            if (kyotu.rrCount > 0)//0の時はバックできない
                kyotu.rrCount--;
        }
        //mcountを戻すにはとりあえずｂを押す
        else if (Input.GetKeyDown("n"))
        {
            listReset();
            kyotu.rrCount = 0;
            if (kyotu.MCount > 0)//0の時はバックできない
                kyotu.MCount--;
        }

        //kyotu.rrCountの数を増やす
        if (Input.GetMouseButtonDown(0))
        {
            listReset();
            //rrcountが紙芝居の最後のページじゃなければ
            //文字が増えるたびここも増える1--------ここから-----123----------
            //公理:0,公準:1,定義:2,meidai:3
            if (kyotu.mojiSwitch == 0)//kouri　4つ
            {
                if (kyotu.MCount == 0)
                {
                    if (kyotu.rrCount < ka1.GetLength(0) - 1)
                    {
                        kyotu.rrCount++;
                    }

                }
                else if (kyotu.MCount == 1)
                {
                    if (kyotu.rrCount < ka3.GetLength(0) - 1)
                    {
                        kyotu.rrCount++;
                    }
                }
                else if (kyotu.MCount == 2)
                {
                    if (kyotu.rrCount < ka4.GetLength(0) - 1)
                    {
                        kyotu.rrCount++;
                    }
                }
                else if (kyotu.MCount == 3)
                {
                    if (kyotu.rrCount < ka5.GetLength(0) - 1)
                    {
                        kyotu.rrCount++;
                    }
                }
            }
            else if (kyotu.mojiSwitch == 1)//koujun　3つ kjp1～3
            {
                if (kyotu.MCount == 0)
                {
                    if (kyotu.rrCount < kjp1.GetLength(0) - 1)
                    {
                        kyotu.rrCount++;
                    }

                }
                else if (kyotu.MCount == 1)
                {
                    if (kyotu.rrCount < kjp2.GetLength(0) - 1)
                    {
                        kyotu.rrCount++;
                    }
                }
                else if (kyotu.MCount == 2)
                {
                    if (kyotu.rrCount < kjp3.GetLength(0) - 1)
                    {
                        kyotu.rrCount++;
                    }
                }
            }
            else if (kyotu.mojiSwitch == 2)//teigi　2つ
            {
                if (kyotu.MCount == 0)
                {
                    if (kyotu.rrCount < tdi1.GetLength(0) - 1)
                    {
                        kyotu.rrCount++;
                    }

                }
                else if (kyotu.MCount == 1)
                {
                    if (kyotu.rrCount < tdi15.GetLength(0) - 1)
                    {
                        kyotu.rrCount++;
                    }
                }
            }
            else if (kyotu.mojiSwitch == 3)//meidai 
            {
                if (kyotu.MCount == 0)
                {
                    if (kyotu.rrCount < m1_1.GetLength(0) - 1)
                    {
                        kyotu.rrCount++;
                    }
                }
                else if (kyotu.MCount == 1)
                {
                    if (kyotu.rrCount < m1_2.GetLength(0) - 1)
                    {
                        kyotu.rrCount++;
                    }
                }
                else if (kyotu.MCount == 2)
                {
                    if (kyotu.rrCount < m1_3.GetLength(0) - 1)
                    {
                        kyotu.rrCount++;
                    }
                }
                else if (kyotu.MCount == 3)
                {
                    if (kyotu.rrCount < m1_4.GetLength(0) - 1)
                    {
                        kyotu.rrCount++;
                    }
                }
                else if (kyotu.MCount == 4)
                {
                    if (kyotu.rrCount < m1_5.GetLength(0) - 1)
                    {
                        kyotu.rrCount++;
                    }
                }
                else if (kyotu.MCount == 5)
                {
                    if (kyotu.rrCount < m1_6.GetLength(0) - 1)
                    {
                        kyotu.rrCount++;
                    }
                }
            }

        }
        else if (Input.GetMouseButtonDown(1))
        {
            listReset();
            kyotu.MCount++;
            kyotu.rrCount = 0;
        }

        hairetuToList();



        //UItextに2次元配列の値を入れていく
        //文章増えるたびに変更2---------------------------------
        for (int i = 0; i < kodomoTextText.Count; i++)
        {
            //公理:0,公準:1,定義:2,meidai:3
            if (kyotu.mojiSwitch == 0)//kouri
            {
                if (kyotu.MCount == 0)
                {
                    if (kyotu.rrCount < ka1.GetLength(0))
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];
                    }
                    else
                    {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[ka1.GetLength(0) - 1][i];
                    }

                }
                else if (kyotu.MCount == 1)
                {
                    if (kyotu.rrCount < ka3.GetLength(0))
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];
                    }
                    else
                    {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[ka3.GetLength(0) - 1][i];
                    }

                }
                else if (kyotu.MCount == 2)
                {
                    if (kyotu.rrCount < ka4.GetLength(0))
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];
                    }
                    else
                    {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[ka4.GetLength(0) - 1][i];
                    }

                }
                else if (kyotu.MCount == 3)
                {
                    if (kyotu.rrCount < ka5.GetLength(0))
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];
                    }
                    else
                    {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[ka5.GetLength(0) - 1][i];
                    }
                }
            }
            else if (kyotu.mojiSwitch == 1)//koujun 3tu
            {
                if (kyotu.MCount == 0)
                {
                    if (kyotu.rrCount < kjp1.GetLength(0))
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];
                    }
                    else
                    {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kjp1.GetLength(0) - 1][i];
                    }

                }
                else if (kyotu.MCount == 1)
                {
                    if (kyotu.rrCount < kjp2.GetLength(0))
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];
                    }
                    else
                    {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kjp2.GetLength(0) - 1][i];
                    }

                }
                else if (kyotu.MCount == 2)
                {
                    if (kyotu.rrCount < kjp3.GetLength(0))
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];
                    }
                    else
                    {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kjp3.GetLength(0) - 1][i];
                    }

                }
            }
            else if (kyotu.mojiSwitch == 2)//teigi 2tu
            {
                if (kyotu.MCount == 0)
                {
                    if (kyotu.rrCount < tdi1.GetLength(0))
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];
                    }
                    else
                    {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[tdi1.GetLength(0) - 1][i];
                    }

                }
                else if (kyotu.MCount == 1)
                {
                    if (kyotu.rrCount < tdi15.GetLength(0))
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];
                    }
                    else
                    {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[tdi15.GetLength(0) - 1][i];
                    }

                }
            }
            else if (kyotu.mojiSwitch == 3)//meidai 
            {
                if (kyotu.MCount == 0)
                {
                    if (kyotu.rrCount < m1_1.GetLength(0))
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];
                    }
                    else
                    {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[m1_1.GetLength(0) - 1][i];
                    }
                }
                else if (kyotu.MCount == 1)
                {
                    if (kyotu.rrCount < m1_2.GetLength(0))
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];//eeee
                    }
                    else
                    {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[m1_2.GetLength(0) - 1][i];
                    }
                }
                else if (kyotu.MCount == 2)
                {
                    if (kyotu.rrCount < m1_3.GetLength(0))
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];//eeee
                    }
                    else
                    {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[m1_3.GetLength(0) - 1][i];
                    }
                }
                else if (kyotu.MCount == 3)
                {
                    if (kyotu.rrCount < m1_4.GetLength(0))
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];//eeee
                    }
                    else
                    {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[m1_4.GetLength(0) - 1][i];
                    }
                }
                else if (kyotu.MCount == 4)
                {
                    if (kyotu.rrCount < m1_5.GetLength(0))
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];//eeee
                    }
                    else
                    {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[m1_5.GetLength(0) - 1][i];
                    }
                }
                else if (kyotu.MCount == 5)
                {
                    if (kyotu.rrCount < m1_6.GetLength(0))
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];//eeee
                    }
                    else
                    {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[m1_6.GetLength(0) - 1][i];
                    }
                }
            }

        }
        //文章増えるたびに変更
        //文字が入った配列の情報から、強調すべき文字の順番をintで得る
        //強調できる文字数２つ
        //ka1.GetLength(1) - 2　１つめ
        //ka1.GetLength(1) - 1　2つめ
        //公理:0,公準:1,定義:2,meidai:3
        if (kyotu.mojiSwitch == 0)//kouri
        {
            //k10_2:strin>int変換
            if (kyotu.MCount == 0)
            {
                if (kyotu.rrCount < ka1.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(ka1[kyotu.rrCount, ka1.GetLength(1) - 1]);
                kyouchouHenkanInt2 = int.Parse(ka1[kyotu.rrCount, ka1.GetLength(1) - 2]);
                kyouchouHenkanInt3 = int.Parse(ka1[kyotu.rrCount, ka1.GetLength(1) - 3]);
            }
            else if (kyotu.MCount == 1)
            {
                if (kyotu.rrCount < ka3.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(ka3[kyotu.rrCount, ka3.GetLength(1) - 1]);
                kyouchouHenkanInt2 = int.Parse(ka3[kyotu.rrCount, ka3.GetLength(1) - 2]);
                kyouchouHenkanInt3 = int.Parse(ka3[kyotu.rrCount, ka3.GetLength(1) - 3]);

            }
            else if (kyotu.MCount == 2)
            {
                if (kyotu.rrCount < ka4.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(ka4[kyotu.rrCount, ka4.GetLength(1) - 1]);
                kyouchouHenkanInt2 = int.Parse(ka4[kyotu.rrCount, ka4.GetLength(1) - 2]);
                kyouchouHenkanInt3 = int.Parse(ka4[kyotu.rrCount, ka4.GetLength(1) - 3]);

            }
            else if (kyotu.MCount == 3)
            {
                if (kyotu.rrCount < ka5.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(ka5[kyotu.rrCount, ka5.GetLength(1) - 1]);
                kyouchouHenkanInt2 = int.Parse(ka5[kyotu.rrCount, ka5.GetLength(1) - 2]);
                kyouchouHenkanInt3 = int.Parse(ka5[kyotu.rrCount, ka5.GetLength(1) - 3]);

            }
        }
        else if (kyotu.mojiSwitch == 1)//koujun
        {
            //k10_2:strin>int変換
            if (kyotu.MCount == 0)
            {
                if (kyotu.rrCount < kjp1.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(kjp1[kyotu.rrCount, kjp1.GetLength(1) - 1]);
                kyouchouHenkanInt2 = int.Parse(kjp1[kyotu.rrCount, kjp1.GetLength(1) - 2]);
                kyouchouHenkanInt3 = int.Parse(kjp1[kyotu.rrCount, kjp1.GetLength(1) - 3]);

            }
            else if (kyotu.MCount == 1)
            {
                if (kyotu.rrCount < kjp2.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(kjp2[kyotu.rrCount, kjp2.GetLength(1) - 1]);
                kyouchouHenkanInt2 = int.Parse(kjp2[kyotu.rrCount, kjp2.GetLength(1) - 2]);
                kyouchouHenkanInt3 = int.Parse(kjp2[kyotu.rrCount, kjp2.GetLength(1) - 3]);

            }
            else if (kyotu.MCount == 2)
            {
                if (kyotu.rrCount < kjp3.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(kjp3[kyotu.rrCount, kjp3.GetLength(1) - 1]);
                kyouchouHenkanInt2 = int.Parse(kjp3[kyotu.rrCount, kjp3.GetLength(1) - 2]);
                kyouchouHenkanInt3 = int.Parse(kjp3[kyotu.rrCount, kjp3.GetLength(1) - 3]);

            }
        }
        else if (kyotu.mojiSwitch == 2)//teigi
        {
            //k10_2:strin>int変換
            if (kyotu.MCount == 0)
            {
                if (kyotu.rrCount < tdi1.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(tdi1[kyotu.rrCount, tdi1.GetLength(1) - 1]);
                kyouchouHenkanInt2 = int.Parse(tdi1[kyotu.rrCount, tdi1.GetLength(1) - 2]);
                kyouchouHenkanInt3 = int.Parse(tdi1[kyotu.rrCount, tdi1.GetLength(1) - 3]);

            }
            else if (kyotu.MCount == 1)
            {
                if (kyotu.rrCount < tdi15.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(tdi15[kyotu.rrCount, tdi15.GetLength(1) - 1]);
                kyouchouHenkanInt2 = int.Parse(tdi15[kyotu.rrCount, tdi15.GetLength(1) - 2]);
                kyouchouHenkanInt3 = int.Parse(tdi15[kyotu.rrCount, tdi15.GetLength(1) - 3]);


            }
        }
        else if (kyotu.mojiSwitch == 3)//meidai 
        {
            //k10_2:strin>int変換
            if (kyotu.MCount == 0)
            {
                if (kyotu.rrCount < m1_1.GetLength(0))
                    //強調する配列番号１、最後の番号から1つ手前である
                    kyouchouHenkanInt1 = int.Parse(m1_1[kyotu.rrCount, m1_1.GetLength(1) - 1]);
                //強調する配列番号２、最後の番号である
                kyouchouHenkanInt2 = int.Parse(m1_1[kyotu.rrCount, m1_1.GetLength(1) - 2]);
                kyouchouHenkanInt3 = int.Parse(m1_1[kyotu.rrCount, m1_1.GetLength(1) - 3]);

            }
            else if (kyotu.MCount == 1)
            {
                if (kyotu.rrCount < m1_2.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(m1_2[kyotu.rrCount, m1_2.GetLength(1) - 1]);///bug
                kyouchouHenkanInt2 = int.Parse(m1_2[kyotu.rrCount, m1_2.GetLength(1) - 2]);
                kyouchouHenkanInt3 = int.Parse(m1_2[kyotu.rrCount, m1_2.GetLength(1) - 3]);

            }
            else if (kyotu.MCount == 2)
            {
                if (kyotu.rrCount < m1_3.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(m1_3[kyotu.rrCount, m1_3.GetLength(1) - 1]);
                kyouchouHenkanInt2 = int.Parse(m1_3[kyotu.rrCount, m1_3.GetLength(1) - 2]);
                kyouchouHenkanInt3 = int.Parse(m1_3[kyotu.rrCount, m1_3.GetLength(1) - 3]);

            }
            else if (kyotu.MCount == 3)
            {
                if (kyotu.rrCount < m1_4.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(m1_4[kyotu.rrCount, m1_4.GetLength(1) - 1]);
                kyouchouHenkanInt2 = int.Parse(m1_4[kyotu.rrCount, m1_4.GetLength(1) - 2]);
                kyouchouHenkanInt3 = int.Parse(m1_4[kyotu.rrCount, m1_4.GetLength(1) - 3]);

            }
            else if (kyotu.MCount == 4)
            {
                if (kyotu.rrCount < m1_5.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(m1_5[kyotu.rrCount, m1_5.GetLength(1) - 1]);
                kyouchouHenkanInt2 = int.Parse(m1_5[kyotu.rrCount, m1_5.GetLength(1) - 2]);
                kyouchouHenkanInt3 = int.Parse(m1_5[kyotu.rrCount, m1_5.GetLength(1) - 3]);

            }
            else if (kyotu.MCount == 5)
            {
                if (kyotu.rrCount < m1_6.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(m1_6[kyotu.rrCount, m1_6.GetLength(1) - 1]);
                kyouchouHenkanInt2 = int.Parse(m1_6[kyotu.rrCount, m1_6.GetLength(1) - 2]);
                kyouchouHenkanInt3 = int.Parse(m1_6[kyotu.rrCount, m1_6.GetLength(1) - 3]);

            }

        }




        //てきすとの強調kyochouPanel(kyouchouHenkanInt);でどこも強調しない数値99
        //kyouchouHenkanInt = 99;

        //強調すべきパネルを強調するメソッド
        kyochouPanel(kyouchouHenkanInt1, kyouchouHenkanInt2, kyouchouHenkanInt3);///

        //Debug.Log("MS::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }

    //list 初期化
    void listReset()
    {
        //kyotu.rrCount = 0;
        ///k0016_99_1_1_4　：Listすべての要素を削除
        kariList.Clear();

        //UItextに2次元配列の値を全てリセット
        //文章増えるたびに変更3---------------------------------
        for (int i = 0; i < kodomoTextText.Count; i++)
        {
            //配列後ろから2つが強調文字につかわれるので
            //if (kyotu.rrCount < ka1.GetLength(0)-1)となる
            //公理:0,公準:1,定義:2,meidai:3
            if (kyotu.mojiSwitch == 0)//kouri
            {
                if (kyotu.MCount == 0)
                {
                    if (kyotu.rrCount < ka1.GetLength(0) - 1)
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                }
                else if (kyotu.MCount == 1)
                {
                    if (kyotu.rrCount < ka3.GetLength(0) - 1)
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                }
                else if (kyotu.MCount == 2)
                {
                    if (kyotu.rrCount < ka4.GetLength(0) - 1)
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                }
                else if (kyotu.MCount == 3)
                {
                    if (kyotu.rrCount < ka5.GetLength(0) - 1)
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                }
            }
            else if (kyotu.mojiSwitch == 1)//koujun
            {
                if (kyotu.MCount == 0)
                {
                    if (kyotu.rrCount < kjp1.GetLength(0) - 1)
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                }
                else if (kyotu.MCount == 1)
                {
                    if (kyotu.rrCount < kjp2.GetLength(0) - 1)
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                }
                else if (kyotu.MCount == 2)
                {
                    if (kyotu.rrCount < kjp3.GetLength(0) - 1)
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                }
            }
            else if (kyotu.mojiSwitch == 2)//teigi
            {
                if (kyotu.MCount == 0)
                {
                    if (kyotu.rrCount < tdi1.GetLength(0) - 1)
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                }
                else if (kyotu.MCount == 1)
                {
                    if (kyotu.rrCount < tdi15.GetLength(0) - 1)
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                }
            }
            else if (kyotu.mojiSwitch == 3)//meidai
            {
                if (kyotu.MCount == 0)
                {
                    if (kyotu.rrCount < m1_1.GetLength(0) - 1)
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                }
                else if (kyotu.MCount == 1)
                {
                    if (kyotu.rrCount < m1_2.GetLength(0) - 1)
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";//eeee
                    }
                }
                else if (kyotu.MCount == 2)
                {
                    if (kyotu.rrCount < m1_3.GetLength(0) - 1)
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";//eeee
                    }
                }
                else if (kyotu.MCount == 3)
                {
                    if (kyotu.rrCount < m1_4.GetLength(0) - 1)
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";//eeee
                    }
                }
                else if (kyotu.MCount == 4)
                {
                    if (kyotu.rrCount < m1_5.GetLength(0) - 1)
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";//eeee
                    }
                }
                else if (kyotu.MCount == 5)
                {
                    if (kyotu.rrCount < m1_6.GetLength(0) - 1)
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";//eeee
                    }
                }
            }

        }
    }

    //文章増えるたびに変更
    //配列からlistへ文字を送る
    void hairetuToList()
    {
        //文章増えるたびに変更4---------------------------------
        //文字パネルに入れるlistに内容を入れる
        //公理:0,公準:1,定義:2,meidai:3
        //kouriに対応

        if (kyotu.mojiSwitch == 0)
        {
            //kouriに対応
            if (kyotu.MCount == 0)
            {
                for (int i = 0; i < ka1.GetLength(0); i++)
                {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());
                    // ka1.GetLength(1)-1 注意　後ろ2つは文字強調
                    for (int j = 0; j < ka1.GetLength(1) - 1; j++)
                    {
                        kariList[i].Add(ka1[i, j]);
                    }
                }
            }
            else if (kyotu.MCount == 1)
            {
                for (int i = 0; i < ka3.GetLength(0); i++)
                {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < ka3.GetLength(1) - 1; j++)
                    {
                        kariList[i].Add(ka3[i, j]);
                    }
                }
            }
            else if (kyotu.MCount == 2)
            {
                for (int i = 0; i < ka4.GetLength(0); i++)
                {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < ka4.GetLength(1) - 1; j++)
                    {
                        kariList[i].Add(ka4[i, j]);
                    }
                }
            }
            else if (kyotu.MCount == 3)
            {
                for (int i = 0; i < ka5.GetLength(0); i++)
                {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < ka5.GetLength(1) - 1; j++)
                    {
                        kariList[i].Add(ka5[i, j]);
                    }
                }
            }

        }
        else if (kyotu.mojiSwitch == 1)
        {
            //koujunに対応 3tu
            if (kyotu.MCount == 0)
            {
                for (int i = 0; i < kjp1.GetLength(0); i++)
                {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < kjp1.GetLength(1) - 1; j++)
                    {
                        kariList[i].Add(kjp1[i, j]);
                    }
                }
            }
            else if (kyotu.MCount == 1)
            {
                for (int i = 0; i < kjp2.GetLength(0); i++)
                {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < kjp2.GetLength(1) - 1; j++)
                    {
                        kariList[i].Add(kjp2[i, j]);
                    }
                }
            }
            else if (kyotu.MCount == 2)
            {
                for (int i = 0; i < kjp3.GetLength(0); i++)
                {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < kjp3.GetLength(1) - 1; j++)
                    {
                        kariList[i].Add(kjp3[i, j]);
                    }
                }
            }

        }
        else if (kyotu.mojiSwitch == 2)
        {
            //koujunに対応 3tu
            if (kyotu.MCount == 0)
            {
                for (int i = 0; i < tdi1.GetLength(0); i++)
                {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < tdi1.GetLength(1) - 1; j++)
                    {
                        kariList[i].Add(tdi1[i, j]);
                    }
                }
            }
            else if (kyotu.MCount == 1)
            {
                for (int i = 0; i < tdi15.GetLength(0); i++)
                {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < tdi15.GetLength(1) - 1; j++)
                    {
                        kariList[i].Add(tdi15[i, j]);
                    }
                }
            }

        }
        //meidaiに対応
        else if (kyotu.mojiSwitch == 3)
        {
            //meidai1に対応
            if (kyotu.MCount == 0)
            {
                for (int i = 0; i < m1_1.GetLength(0); i++)
                {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < m1_1.GetLength(1) - 1; j++)
                    {
                        kariList[i].Add(m1_1[i, j]);
                    }
                }
            }
            //meidai2に対応
            else if (kyotu.MCount == 1)
            {
                for (int i = 0; i < m1_2.GetLength(0); i++)
                {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < m1_2.GetLength(1) - 1; j++)
                    {
                        kariList[i].Add(m1_2[i, j]);
                    }
                }
            }
            //meidai3に対応
            else if (kyotu.MCount == 2)
            {
                for (int i = 0; i < m1_3.GetLength(0); i++)
                {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < m1_3.GetLength(1) - 1; j++)
                    {
                        kariList[i].Add(m1_3[i, j]);
                    }
                }
            }
            //meidai4に対応
            else if (kyotu.MCount == 3)
            {
                for (int i = 0; i < m1_4.GetLength(0); i++)
                {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < m1_4.GetLength(1) - 1; j++)
                    {
                        kariList[i].Add(m1_4[i, j]);
                    }
                }
            }
            //meidai5に対応
            else if (kyotu.MCount == 4)
            {
                for (int i = 0; i < m1_5.GetLength(0); i++)
                {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < m1_5.GetLength(1) - 1; j++)
                    {
                        kariList[i].Add(m1_5[i, j]);
                    }
                }
            }
            //meidai6に対応
            else if (kyotu.MCount == 5)
            {
                for (int i = 0; i < m1_6.GetLength(0); i++)
                {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < m1_6.GetLength(1) - 1; j++)
                    {
                        kariList[i].Add(m1_6[i, j]);
                    }
                }
            }
        }
        //文章増えるたびに変更、ここまで
    }
    //Uitextの中身----------------------------------------------------------------------------------------------------
    //文章増えるたびに変更
    //3次元配列
    private string[,] m1_1 = new string[,]//m1_1w
    {
        //0
        {"命題I-1","","","","","","","","","","","","","","","","99","99","99"},
      {"与えられた直線", "を","一辺","とする","正三角形","を","作図する事","","","","","","","","","","0","99","99"},
        {"与えられた直線", "を","一辺","とする","正三角形","を","作図する事","","","","","","","","","","2","99","99"},
        {"与えられた直線", "を","一辺","とする","正三角形","を","作図する事","","","","","","","","","","4","99","99"},
        {"与えられた直線", "を","一辺","とする","正三角形","を","作図する事","","","","","","","","","","6","99","99"},
        //5
        {"証明スタート","","","","","","","","","","","","","","","","0","99","99"},
        //6
        {"AB","を","与えられた直線","とする","","","","","","","","","","","","","0","99","99"},
        {"AB","を","与えられた直線","とする","","","","","","","","","","","","","2","99","99"},
        {"AB","を","与えられた直線","とする","","","","","","","","","","","","","3","99","99"},
        //9
        {"このとき、", "AB","を","一辺とする","正三角形","を","作図すること","が","求められている","","","","","","","","1","99","99"},
        {"このとき、", "AB","を","一辺とする","正三角形","を","作図すること","が","求められている","","","","","","","","3","99","99"},
        {"このとき、", "AB","を","一辺とする","正三角形","を","作図すること","が","求められている","","","","","","","","4","99","99"},
        {"このとき、", "AB","を","一辺とする","正三角形","を","作図すること","が","求められている","","","","","","","","6","99","99"},
        {"このとき、", "AB","を","一辺とする","正三角形","を","作図すること","が","求められている","","","","","","","","8","99","99"},
        //14
        {"A", "を","中心とし","AB","を",
            "半径とする","円BCD","を","描く","　　　　　　　",
            "[公準P-3]","","任意の中心と半径の円を描く","","","","0","99","99"},
        {"A", "を","中心とし","AB","を",
            "半径とする","円BCD","を","描く","　　　　　　　",
            "[公準P-3]","","任意の中心と半径の円を描く","","","","2","99","99"},
        {"A", "を","中心とし","AB","を",
            "半径とする","円BCD","を","描く","　　　　　　　",
            "[公準P-3]","","任意の中心と半径の円を描く","","","","3","99","99"},
        {"A", "を","中心とし","AB","を",
            "半径とする","円BCD","を","描く","　　　　　　　",
            "[公準P-3]","","任意の中心と半径の円を描く","","","","5","99","99"},
        {"A", "を","中心とし","AB","を",
            "半径とする","円BCD","を","描く","　　　　　　　",
            "[公準P-3]","","任意の中心と半径の円を描く","","","","6","99","99"},
        {"A", "を","中心とし","AB","を",
            "半径とする","円BCD","を","描く","　　　　　　　",
            "[公準P-3]","","任意の中心と半径の円を描く","","","","8","99","99"},
        {"A", "を","中心とし","AB","を",
            "半径とする","円BCD","を","描く","　　　　　　　",
            "[公準P-3]","","任意の中心と半径の円を描く","","","","10","12","99"},
        //21
        {"BA", "を","半径とする","円ACE","を",
            "描く","","[公準P-3]","","任意の中心と半径の円を描く",
            "","","","","","","0","99","99"},
        {"BA", "を","半径とする","円ACE","を",
            "描く","","[公準P-3]","","任意の中心と半径の円を描く",
            "","","","","","","2","99","99"},
        {"BA", "を","半径とする","円ACE","を",
            "描く","","[公準P-3]","","任意の中心と半径の円を描く",
            "","","","","","","3","99","99"},
        {"BA", "を","半径とする","円ACE","を",
            "描く","","[公準P-3]","","任意の中心と半径の円を描く",
            "","","","","","","5","99","99"},
        {"BA", "を","半径とする","円ACE","を",
            "描く","","[公準P-3]","","任意の中心と半径の円を描く",
            "","","","","","","7","9","99"},
        //26
        {"そして","二つの円の交点C","と","A","と","B","を","結ぶ直線","CA","と","CB","を","描く","","","","1","99","99"},
        {"そして","二つの円の交点C","と","A","と","B","を","結ぶ直線","CA","と","CB","を","描く","","","","3","99","99"},
        {"そして","二つの円の交点C","と","A","と","B","を","結ぶ直線","CA","と","CB","を","描く","","","","5","99","99"},
        {"そして","二つの円の交点C","と","A","と","B","を","結ぶ直線","CA","と","CB","を","描く","","","","7","99","99"},
        {"そして","二つの円の交点C","と","A","と","B","を","結ぶ直線","CA","と","CB","を","描く","","","","8","99","99"},
        {"そして","二つの円の交点C","と","A","と","B","を","結ぶ直線","CA","と","CB","を","描く","","","","10","99","99"},
        {"そして","二つの円の交点C","と","A","と","B","を","結ぶ直線","CA","と","CB","を","描く","","","","12","99","99"},
        //33
        {"[公準P-1]","    ", "任意の点から任意の点へ","直線を引くこと","","","","","","","","","","","","","0","2","3"},
        //34
        {"点A","は","円CDB","の","中心であるから",
            "AC","は","AB","と","等しい",
            "　　　　","[定義DI-15]","","円はその中の一つの点から円周上","の点までの長さがすべて等しい","","0","99","99"},
        {"点A","は","円CDB","の","中心であるから",
            "AC","は","AB","と","等しい",
            "　　　　","[定義DI-15]","","円はその中の一つの点から円周上","の点までの長さがすべて等しい","","2","99","99"},
        {"点A","は","円CDB","の","中心であるから",
            "AC","は","AB","と","等しい",
            "　　　　","[定義DI-15]","","円はその中の一つの点から円周上","の点までの長さがすべて等しい","","4","99","99"},
        {"点A","は","円CDB","の","中心であるから",
            "AC","は","AB","と","等しい",
            "　　　　","[定義DI-15]","","円はその中の一つの点から円周上","の点までの長さがすべて等しい","","5","99","99"},
        {"点A","は","円CDB","の","中心であるから",
            "AC","は","AB","と","等しい",
            "　　　　","[定義DI-15]","","円はその中の一つの点から円周上","の点までの長さがすべて等しい","","7","99","99"},
        {"点A","は","円CDB","の","中心であるから",
            "AC","は","AB","と","等しい",
            "　　　　","[定義DI-15]","","円はその中の一つの点から円周上","の点までの長さがすべて等しい","","9","99","99"},
        {"点A","は","円CDB","の","中心であるから",
            "AC","は","AB","と","等しい",
            "　　　　","[定義DI-15]","","円はその中の一つの点から円周上","の点までの長さがすべて等しい","","11","13","14"},
        //41
        {"また","点B","は","円CAE","の",
            "中心なので","BC","と","BA","は",
            "等しい","　　　　","[定義DI-15]","円はその中の一つの点から円周上","の点までの長さがすべて等しい","","1","99","99"},
        {"また","点B","は","円CAE","の",
            "中心なので","BC","と","BA","は",
            "等しい","　　　　","[定義DI-15]","円はその中の一つの点から円周上","の点までの長さがすべて等しい","","3","99","99"},
        {"また","点B","は","円CAE","の",
            "中心なので","BC","と","BA","は",
            "等しい","　　　　","[定義DI-15]","円はその中の一つの点から円周上","の点までの長さがすべて等しい","","5","99","99"},
        {"また","点B","は","円CAE","の",
            "中心なので","BC","と","BA","は",
            "等しい","　　　　","[定義DI-15]","円はその中の一つの点から円周上","の点までの長さがすべて等しい","","6","99","99"},
        {"また","点B","は","円CAE","の",
            "中心なので","BC","と","BA","は",
            "等しい","　　　　","[定義DI-15]","円はその中の一つの点から円周上","の点までの長さがすべて等しい","","8","99","99"},
        {"また","点B","は","円CAE","の",
            "中心なので","BC","と","BA","は",
            "等しい","　　　　","[定義DI-15]","円はその中の一つの点から円周上","の点までの長さがすべて等しい","","10","99","99"},
        {"また","点B","は","円CAE","の",
            "中心なので","BC","と","BA","は",
            "等しい","　　　　","[定義DI-15]","円はその中の一つの点から円周上","の点までの長さがすべて等しい","","12","13","14"},
        //48
        {"AB", "と","AC","は","等しく、","AB","と","BC","は","等しい","ので、","AC","と","BC","は","等しい","0","99","99"},
        {"AB", "と","AC","は","等しく、","AB","と","BC","は","等しい","ので、","AC","と","BC","は","等しい","2","99","99"},
        {"AB", "と","AC","は","等しく、","AB","と","BC","は","等しい","ので、","AC","と","BC","は","等しい","4","99","99"},
        {"AB", "と","AC","は","等しく、","AB","と","BC","は","等しい","ので、","AC","と","BC","は","等しい","5","99","99"},
        {"AB", "と","AC","は","等しく、","AB","と","BC","は","等しい","ので、","AC","と","BC","は","等しい","7","99","99"},
        {"AB", "と","AC","は","等しく、","AB","と","BC","は","等しい","ので、","AC","と","BC","は","等しい","9","99","99"},
        {"AB", "と","AC","は","等しく、","AB","と","BC","は","等しい","ので、","AC","と","BC","は","等しい","11","99","99"},
        {"AB", "と","AC","は","等しく、","AB","と","BC","は","等しい","ので、","AC","と","BC","は","等しい","13","99","99"},
        {"AB", "と","AC","は","等しく、","AB","と","BC","は","等しい","ので、","AC","と","BC","は","等しい","15","99","99"},
        //57
        {"[公理A-1]", "　　","同じものに等しいものは","互いに等しい","","","","","","","","","","","","","0","2","3"},
        //58
        {"AB","、", "BC","、","CA","の","3辺","は","すべて","互いに等しい","","","","","","","0","99","99"},
        {"AB","、", "BC","、","CA","の","3辺","は","すべて","互いに等しい","","","","","","","2","99","99"},
        {"AB","、", "BC","、","CA","の","3辺","は","すべて","互いに等しい","","","","","","","4","99","99"},
        {"AB","、", "BC","、","CA","の","3辺","は","すべて","互いに等しい","","","","","","","6","99","99"},
        {"AB","、", "BC","、","CA","の","3辺","は","すべて","互いに等しい","","","","","","","9","99","99"},
        //63
        {"ゆえに、","三角形ABC","は","正三角形であり、","与えられた直線AB","から","作図されたものである","","","","","","","","","","1","99","99"},
        {"ゆえに、","三角形ABC","は","正三角形であり、","与えられた直線AB","から","作図されたものである","","","","","","","","","","3","99","99"},
        {"ゆえに、","三角形ABC","は","正三角形であり、","与えられた直線AB","から","作図されたものである","","","","","","","","","","4","99","99"},
        {"ゆえに、","三角形ABC","は","正三角形であり、","与えられた直線AB","から","作図されたものである","","","","","","","","","","6","99","99"},
        //67
        {"これが求められていた", "ことであった。","","","","","","","","","","","","","","","99","99","99"},

    };

    private string[,] m1_2 = new string[,]//m1_2w
    {
        {"命題I-2","","","","","","","","","","","","","","","","99","99","99"},
        {"与えられた直線", "と","同じ長さの直線","を","与えられた点","から","作図すること","","","","","","","","","","0","99","99"},
        {"与えられた直線", "と","同じ長さの直線","を","与えられた点","から","作図すること","","","","","","","","","","2","99","99"},
        {"与えられた直線", "と","同じ長さの直線","を","与えられた点","から","作図すること","","","","","","","","","","4","99","99"},
        {"与えられた直線", "と","同じ長さの直線","を","与えられた点","から","作図すること","","","","","","","","","","6","99","99"},
        
        //5
        {"", "証明スタート","　　　　　　　","","","","","","","","","","","","","","1","99","99"},
        //6
        {"Aを与えられた点", "BCを与えられた直線","とする","","","","","","","","","","","","","","0","99","99"},
        {"Aを与えられた点", "BCを与えられた直線","とする","","","","","","","","","","","","","","1","99","99"},
        {"Aを与えられた点", "BCを与えられた直線","とする","","","","","","","","","","","","","","2","99","99"},
        //9
        {"このとき、", "A","から","BC","と","同じ長さの直線","を","作図することが求められている","","","","","","","","","1","99","99"},
        {"このとき、", "A","から","BC","と","同じ長さの直線","を","作図することが求められている","","","","","","","","","3","99","99"},
        {"このとき、", "A","から","BC","と","同じ長さの直線","を","作図することが求められている","","","","","","","","","5","99","99"},
        {"このとき、", "A","から","BC","と","同じ長さの直線","を","作図することが求められている","","","","","","","","","7","99","99"},
        //13
        {"AB", "を","A","と","B",
            "を","結ぶ直線とする","","","[公準P-1]",
            "　　　","任意の点から任意の点へ","直線を引くこと","","","","0","99","99"},
        {"AB", "を","A","と","B",
            "を","結ぶ直線とする","","","[公準P-1]",
            "　　　","任意の点から任意の点へ","直線を引くこと","","","","2","99","99"},
        {"AB", "を","A","と","B",
            "を","結ぶ直線とする","","","[公準P-1]",
            "　　　","任意の点から任意の点へ","直線を引くこと","","","","4","99","99"},
        {"AB", "を","A","と","B",
            "を","結ぶ直線とする","","","[公準P-1]",
            "　　　","任意の点から任意の点へ","直線を引くこと","","","","6","99","99"},
        {"AB", "を","A","と","B",
            "を","結ぶ直線とする","","","[公準P-1]",
            "　　　","任意の点から任意の点へ","直線を引くこと","","","","9","11","12"},
        //18
        {"直線AB", "を","一辺とする","正三角形DAB","を",
            "作図することができる","　　　","[命題I-1]","","与えられた直線と同じ長さの直線を",
            "与えられた点から作図すること","","","","","","0","99","99"},
        {"直線AB", "を","一辺とする","正三角形DAB","を",
            "作図することができる","　　　","[命題I-1]","","与えられた直線と同じ長さの直線を",
            "与えられた点から作図すること","","","","","","2","99","99"},
        {"直線AB", "を","一辺とする","正三角形DAB","を",
            "作図することができる","　　　","[命題I-1]","","与えられた直線と同じ長さの直線を",
            "与えられた点から作図すること","","","","","","3","99","99"},
        {"直線AB", "を","一辺とする","正三角形DAB","を",
            "作図することができる","　　　","[命題I-1]","","与えられた直線と同じ長さの直線を",
            "与えられた点から作図すること","","","","","","5","99","99"},
        {"直線AB", "を","一辺とする","正三角形DAB","を",
            "作図することができる","　　　","[命題I-1]","","与えられた直線と同じ長さの直線を",
            "与えられた点から作図すること","","","","","","7","9","10"},
        //23
        {"DA", "と","DB","を","延長し",
            "　　　　　","直線AE","と","BF","を",
            "描く","　　　　　","[公準P-2]","　　","任意の直線を連続して延ばすこと","","0","99","99"},
        {"DA", "と","DB","を","延長し",
            "　　　　　","直線AE","と","BF","を",
            "描く","　　　　　","[公準P-2]","　　","任意の直線を連続して延ばすこと","","2","99","99"},
        {"DA", "と","DB","を","延長し",
            "　　　　　","直線AE","と","BF","を",
            "描く","　　　　　","[公準P-2]","　　","任意の直線を連続して延ばすこと","","4","99","99"},
        {"DA", "と","DB","を","延長し",
            "　　　　　","直線AE","と","BF","を",
            "描く","　　　　　","[公準P-2]","　　","任意の直線を連続して延ばすこと","","6","99","99"},
        {"DA", "と","DB","を","延長し",
            "　　　　　","直線AE","と","BF","を",
            "描く","　　　　　","[公準P-2]","　　","任意の直線を連続して延ばすこと","","8","99","99"},
        {"DA", "と","DB","を","延長し",
            "　　　　　","直線AE","と","BF","を",
            "描く","　　　　　","[公準P-2]","　　","任意の直線を連続して延ばすこと","","10","99","99"},
        {"DA", "と","DB","を","延長し",
            "　　　　　","直線AE","と","BF","を",
            "描く","　　　　　","[公準P-2]","　　","任意の直線を連続して延ばすこと","","12","14","99"},
        //30
        {"そして、", "B","を","中心とし","BC",
            "を","半径とする","円CGH","を","描き",
            "","[公準P-3]","","任意の中心と半径の円を描く","","","1","99","99"},
        {"そして、", "B","を","中心とし","BC",
            "を","半径とする","円CGH","を","描き",
            "","[公準P-3]","","任意の中心と半径の円を描く","","","3","99","99"},
        {"そして、", "B","を","中心とし","BC",
            "を","半径とする","円CGH","を","描き",
            "","[公準P-3]","","任意の中心と半径の円を描く","","","4","99","99"},
        {"そして、", "B","を","中心とし","BC",
            "を","半径とする","円CGH","を","描き",
            "","[公準P-3]","","任意の中心と半径の円を描く","","","6","99","99"},
        {"そして、", "B","を","中心とし","BC",
            "を","半径とする","円CGH","を","描き",
            "","[公準P-3]","","任意の中心と半径の円を描く","","","7","99","99"},
        {"そして、", "B","を","中心とし","BC",
            "を","半径とする","円CGH","を","描き",
            "","[公準P-3]","","任意の中心と半径の円を描く","","","9","99","99"},
        {"そして、", "B","を","中心とし","BC",
            "を","半径とする","円CGH","を","描き",
            "","[公準P-3]","","任意の中心と半径の円を描く","","","11","13","99"},
        //37
        {"D", "を","中心とし","DG","を",
            "半径とする","円GKL","を","描く","　　　　　",
            "[公準P-3]","","任意の中心と半径の円を描く","","","","0","99","99"},
        {"D", "を","中心とし","DG","を",
            "半径とする","円GKL","を","描く","　　　　　",
            "[公準P-3]","","任意の中心と半径の円を描く","","","","2","99","99"},
        {"D", "を","中心とし","DG","を",
            "半径とする","円GKL","を","描く","　　　　　",
            "[公準P-3]","","任意の中心と半径の円を描く","","","","3","99","99"},
        {"D", "を","中心とし","DG","を",
            "半径とする","円GKL","を","描く","　　　　　",
            "[公準P-3]","","任意の中心と半径の円を描く","","","","5","99","99"},
        {"D", "を","中心とし","DG","を",
            "半径とする","円GKL","を","描く","　　　　　",
            "[公準P-3]","","任意の中心と半径の円を描く","","","","6","99","99"},
        {"D", "を","中心とし","DG","を",
            "半径とする","円GKL","を","描く","　　　　　",
            "[公準P-3]","","任意の中心と半径の円を描く","","","","8","99","99"},
        {"D", "を","中心とし","DG","を",
            "半径とする","円GKL","を","描く","　　　　　",
            "[公準P-3]","","任意の中心と半径の円を描く","","","","10","12","99"},
        //44
        {"ここで、", "B","は","円CGH","の",
            "中心であるから","　　　　　　　　","BC","は","BG","と",
            "等しい","　　　　　","[定義DI-15]","円はその中の一つの点から円周上","の点までの長さがすべて等しい","1","99","99"},
        {"ここで、", "B","は","円CGH","の",
            "中心であるから","　　　　　　　　","BC","は","BG","と",
            "等しい","　　　　　","[定義DI-15]","円はその中の一つの点から円周上","の点までの長さがすべて等しい","3","99","99"},
        {"ここで、", "B","は","円CGH","の",
            "中心であるから","　　　　　　　　","BC","は","BG","と",
            "等しい","　　　　　","[定義DI-15]","円はその中の一つの点から円周上","の点までの長さがすべて等しい","5","99","99"},
        {"ここで、", "B","は","円CGH","の",
            "中心であるから","　　　　　　　　","BC","は","BG","と",
            "等しい","　　　　　","[定義DI-15]","円はその中の一つの点から円周上","の点までの長さがすべて等しい","7","99","99"},
        {"ここで、", "B","は","円CGH","の",
            "中心であるから","　　　　　　　　","BC","は","BG","と",
            "等しい","　　　　　","[定義DI-15]","円はその中の一つの点から円周上","の点までの長さがすべて等しい","9","99","99"},
        {"ここで、", "B","は","円CGH","の",
            "中心であるから","　　　　　　　　","BC","は","BG","と",
            "等しい","　　　　　","[定義DI-15]","円はその中の一つの点から円周上","の点までの長さがすべて等しい","11","99","99"},
        {"ここで、", "B","は","円CGH","の",
            "中心であるから","　　　　　　　　","BC","は","BG",
            "と","等しい","　　　　　","[定義DI-15]","円はその中の一つの点から円周上","の点までの長さがすべて等しい","13","14","15"},
        //51
        {"また、", "D","は","円GKL","の",
            "中心であるから","　　　　　　　　","DL","は","DG",
            "と","等しい","　　　　　　","[定義DI-15]","円はその中の一つの点から円周上","の点までの長さがすべて等しい","1","99","99"},
        {"また、", "D","は","円GKL","の",
            "中心であるから","　　　　　　　　","DL","は","DG",
            "と","等しい","　　　　　　","[定義DI-15]","円はその中の一つの点から円周上","の点までの長さがすべて等しい","3","99","99"},
        {"また、", "D","は","円GKL","の",
            "中心であるから","　　　　　　　　","DL","は","DG",
            "と","等しい","　　　　　　","[定義DI-15]","円はその中の一つの点から円周上","の点までの長さがすべて等しい","5","99","99"},
        {"また、", "D","は","円GKL","の",
            "中心であるから","　　　　　　　　","DL","は","DG",
            "と","等しい","　　　　　　","[定義DI-15]","円はその中の一つの点から円周上","の点までの長さがすべて等しい","7","99","99"},
        {"また、", "D","は","円GKL","の",
            "中心であるから","　　　　　　　　","DL","は","DG",
            "と","等しい","　　　　　　","[定義DI-15]","円はその中の一つの点から円周上","の点までの長さがすべて等しい","9","99","99"},
        {"また、", "D","は","円GKL","の",
            "中心であるから","　　　　　　　　","DL","は","DG",
            "と","等しい","　　　　　　","[定義DI-15]","円はその中の一つの点から円周上","の点までの長さがすべて等しい","11","99","99"},
        {"また、", "D","は","円GKL","の",
            "中心であるから","　　　　　　　　","DL","は","DG",
            "と","等しい","　　　　　　","[定義DI-15]","円はその中の一つの点から円周上","の点までの長さがすべて等しい","13","14","15"},
        //58
        {"これらの中にある", "DA","と","DB","は","等しい","から、","それら","を","引いた差のAL","は","BG","と","等しい","","","0","99","99"},
        {"これらの中にある", "DA","と","DB","は","等しい","から、","それら","を","引いた差のAL","は","BG","と","等しい","","","1","99","99"},
        {"これらの中にある", "DA","と","DB","は","等しい","から、","それら","を","引いた差のAL","は","BG","と","等しい","","","3","99","99"},
        {"これらの中にある", "DA","と","DB","は","等しい","から、","それら","を","引いた差のAL","は","BG","と","等しい","","","5","99","99"},
        {"これらの中にある", "DA","と","DB","は","等しい","から、","それら","を","引いた差のAL","は","BG","と","等しい","","","7","99","99"},
        {"これらの中にある", "DA","と","DB","は","等しい","から、","それら","を","引いた差のAL","は","BG","と","等しい","","","9","99","99"},
        {"これらの中にある", "DA","と","DB","は","等しい","から、","それら","を","引いた差のAL","は","BG","と","等しい","","","11","99","99"},
        {"これらの中にある", "DA","と","DB","は","等しい","から、","それら","を","引いた差のAL","は","BG","と","等しい","","","13","99","99"},
        //66
        {"[公理A-3]", "","等しいものから等しいものを引いた","差は互いに等しい","","","","","","","","","","","","","0","2","3"},
        //67
        {"BG", "と","AL","は","等しい",
            "　　　　　　","そして、","BG","と","BC",
            "は","等しい","","","","","0","99","99"},
        {"BG", "と","AL","は","等しい",
            "　　　　　　","そして、","BG","と","BC",
            "は","等しい","","","","","2","99","99"},
        {"BG", "と","AL","は","等しい",
            "　　　　　　","そして、","BG","と","BC",
            "は","等しい","","","","","4","99","99"},
        {"BG", "と","AL","は","等しい",
            "　　　　　　","そして、","BG","と","BC",
            "は","等しい","","","","","7","99","99"},
        {"BG", "と","AL","は","等しい",
            "　　　　　　","そして、","BG","と","BC",
            "は","等しい","","","","","9","99","99"},
        {"BG", "と","AL","は","等しい",
            "　　　　　　","そして、","BG","と","BC",
            "は","等しい","","","","","11","99","99"},
        //73
        {"よって、", "AL","と","BC","は",
            "等しい","","","","",
            "","","","","","","1","99","99"},
        {"よって、", "AL","と","BC","は",
            "等しい","","","","",
            "","","","","","","3","99","99"},
        {"よって、", "AL","と","BC","は",
            "等しい","","","","",
            "","","","","","","5","99","99"},
        //76
        {"[公理A-1]","　　","同じものに等しいものは","互いに等しい","","","","","","","","","","","","","0","2","3"},
        //77
        {"ゆえに、", "直線AL","は","与えられた直線BC","と","等しく","与えられた点A","から","引かれている","","","","","","","","1","99","99"},
        {"ゆえに、", "直線AL","は","与えられた直線BC","と","等しく","与えられた点A","から","引かれている","","","","","","","","3","99","99"},
        {"ゆえに、", "直線AL","は","与えられた直線BC","と","等しく","与えられた点A","から","引かれている","","","","","","","","5","99","99"},
        {"ゆえに、", "直線AL","は","与えられた直線BC","と","等しく","与えられた点A","から","引かれている","","","","","","","","6","99","99"},
        {"ゆえに、", "直線AL","は","与えられた直線BC","と","等しく","与えられた点A","から","引かれている","","","","","","","","8","99","99"},
        //82
        {"これが求められていた", "ことであった。","","","","","","","","","","","","","","","99","99","99"},
        //{"", "","","","","","","","","","","99"},

    };//private string[,] m1_4 = new string[,]
    private string[,] m1_3 = new string[,]//m1_3w
    {
        {"命題I-3","","","","","","","","","","","","","","","","99","99","99"},
        {"長さが異なる", "二つの直線","が","与えられたとき、","長い方","から","短い方","の","長さを切り取ること","","","","","","","","0","99","99"},
        {"長さが異なる", "二つの直線","が","与えられたとき、","長い方","から","短い方","の","長さを切り取ること","","","","","","","","1","99","99"},
        {"長さが異なる", "二つの直線","が","与えられたとき、","長い方","から","短い方","の","長さを切り取ること","","","","","","","","3","99","99"},
        {"長さが異なる", "二つの直線","が","与えられたとき、","長い方","から","短い方","の","長さを切り取ること","","","","","","","","4","99","99"},
        {"長さが異なる", "二つの直線","が","与えられたとき、","長い方","から","短い方","の","長さを切り取ること","","","","","","","","6","99","99"},
        {"長さが異なる", "二つの直線","が","与えられたとき、","長い方","から","短い方","の","長さを切り取ること","","","","","","","","8","99","99"},

        {"", "証明スタート","　　　　　　　","","","","","","","","","","","","","","1","99","99"},

        {"AB", "と","C","を","与えられた","長さが異なる二つの直線","とし、","ABの方が","長いものとする","","","","","","","","0","99","99"},
        {"AB", "と","C","を","与えられた","長さが異なる二つの直線","とし、","ABの方が","長いものとする","","","","","","","","2","99","99"},
        {"AB", "と","C","を","与えられた","長さが異なる二つの直線","とし、","ABの方が","長いものとする","","","","","","","","4","99","99"},
        {"AB", "と","C","を","与えられた","長さが異なる二つの直線","とし、","ABの方が","長いものとする","","","","","","","","5","99","99"},
        {"AB", "と","C","を","与えられた","長さが異なる二つの直線","とし、","ABの方が","長いものとする","","","","","","","","7","99","99"},
        {"AB", "と","C","を","与えられた","長さが異なる二つの直線","とし、","ABの方が","長いものとする","","","","","","","","8","99","99"},
        //13w
        {"このとき、", "AB","から","Cの長さ分","を","切り取ることが求められている","","","","","","","","","","","1","99","99"},
        {"このとき、", "AB","から","Cの長さ分","を","切り取ることが求められている","","","","","","","","","","","3","99","99"},
        {"このとき、", "AB","から","Cの長さ分","を","切り取ることが求められている","","","","","","","","","","","5","99","99"},
        //16w
        {"AD", "を","C","と","同じ長さ",
            "の","A","から","引かれた直線","とする",
            "　　　　　　","[命題I-2]","","与えられた直線と同じ長さの直線を","与えられた点から作図すること","","0","99","99"},
        {"AD", "を","C","と","同じ長さ",
            "の","A","から","引かれた直線","とする",
            "　　　　　　","[命題I-2]","","与えられた直線と同じ長さの直線を","与えられた点から作図すること","","2","99","99"},
        {"AD", "を","C","と","同じ長さ",
            "の","A","から","引かれた直線","とする",
            "　　　　　　","[命題I-2]","","与えられた直線と同じ長さの直線を","与えられた点から作図すること","","4","99","99"},
        {"AD", "を","C","と","同じ長さ",
            "の","A","から","引かれた直線","とする",
            "　　　　　　","[命題I-2]","","与えられた直線と同じ長さの直線を","与えられた点から作図すること","","6","99","99"},
        {"AD", "を","C","と","同じ長さ",
            "の","A","から","引かれた直線","とする",
            "　　　　　　","[命題I-2]","","与えられた直線と同じ長さの直線を","与えられた点から作図すること","","8","99","99"},
        {"AD", "を","C","と","同じ長さ",
            "の","A","から","引かれた直線","とする",
            "　　　　　　","[命題I-2]","","与えられた直線と同じ長さの直線を","与えられた点から作図すること","","11","13","14"},


        {"そして、", "Aを中心とし","半径AD","の","円DEF",
            "を","描く","　　　　　　　　　","[公準P-3]","",
            "任意の中心と半径の円を描く","","","","","","1","99","99"},
        {"そして、", "Aを中心とし","半径AD","の","円DEF",
            "を","描く","　　　　　　　　　","[公準P-3]","",
            "任意の中心と半径の円を描く","","","","","","2","99","99"},
        {"そして、", "Aを中心とし","半径AD","の","円DEF",
            "を","描く","　　　　　　　　　","[公準P-3]","",
            "任意の中心と半径の円を描く","","","","","","4","99","99"},
        {"そして、", "Aを中心とし","半径AD","の","円DEF",
            "を","描く","　　　　　　　　　","[公準P-3]","",
            "任意の中心と半径の円を描く","","","","","","6","99","99"},
        {"そして、", "Aを中心とし","半径AD","の","円DEF",
            "を","描く","　　　　　　　　　","[公準P-3]","",
            "任意の中心と半径の円を描く","","","","","","8","10","99"},
        //28
        {"A", "は","円DEF","の","中心であるから、",
            "AE","は","AD","と","等しい",
            "　　　　　　","[定義I-15]","","円はその中の一つの点から円周上","の点までの長さがすべて等しい","","0","99","99"},
        {"A", "は","円DEF","の","中心であるから、",
            "AE","は","AD","と","等しい",
            "　　　　　　","[定義I-15]","","円はその中の一つの点から円周上","の点までの長さがすべて等しい","","2","99","99"},
        {"A", "は","円DEF","の","中心であるから、",
            "AE","は","AD","と","等しい",
            "　　　　　　","[定義I-15]","","円はその中の一つの点から円周上","の点までの長さがすべて等しい","","4","99","99"},
        {"A", "は","円DEF","の","中心であるから、",
            "AE","は","AD","と","等しい",
            "　　　　　　","[定義I-15]","","円はその中の一つの点から円周上","の点までの長さがすべて等しい","","5","99","99"},
        {"A", "は","円DEF","の","中心であるから、",
            "AE","は","AD","と","等しい",
            "　　　　　　","[定義I-15]","","円はその中の一つの点から円周上","の点までの長さがすべて等しい","","7","99","99"},
        {"A", "は","円DEF","の","中心であるから、",
            "AE","は","AD","と","等しい",
            "　　　　　　","[定義I-15]","","円はその中の一つの点から円周上","の点までの長さがすべて等しい","","9","99","99"},
        {"A", "は","円DEF","の","中心であるから、",
            "AE","は","AD","と","等しい",
            "　　　　　　","[定義I-15]","","円はその中の一つの点から円周上","の点までの長さがすべて等しい","","11","13","14"},
        //35
        {"ここで", "C","は","AD","と","等しいから","　","AE","と","C","は","共に","AD","と","等しく","","1","99","99"},
        {"ここで", "C","は","AD","と","等しいから","　","AE","と","C","は","共に","AD","と","等しく","","3","99","99"},
        {"ここで", "C","は","AD","と","等しいから","　","AE","と","C","は","共に","AD","と","等しく","","5","99","99"},
        {"ここで", "C","は","AD","と","等しいから","　","AE","と","C","は","共に","AD","と","等しく","","7","99","99"},
        {"ここで", "C","は","AD","と","等しいから","　","AE","と","C","は","共に","AD","と","等しく","","9","99","99"},
        {"ここで", "C","は","AD","と","等しいから","　","AE","と","C","は","共に","AD","と","等しく","","11","99","99"},
        {"ここで", "C","は","AD","と","等しいから","　","AE","と","C","は","共に","AD","と","等しく","","12","99","99"},
        {"ここで", "C","は","AD","と","等しいから","　","AE","と","C","は","共に","AD","と","等しく","","14","99","99"},


        //43
        {"よって", "AE","は","C","と",
            "等しい","　　　　","[公理A-1]","　　　","同じものに等しいものは",
            "互いに等しい","","","","","","1","99","99"},
        {"よって", "AE","は","C","と",
            "等しい","　　　　","[公理A-1]","　　　","同じものに等しいものは",
            "互いに等しい","","","","","","3","99","99"},
        {"よって", "AE","は","C","と",
            "等しい","　　　　","[公理A-1]","　　　","同じものに等しいものは",
            "互いに等しい","","","","","","5","99","99"},
        {"よって", "AE","は","C","と",
            "等しい","　　　　","[公理A-1]","　　　","同じものに等しいものは",
            "互いに等しい","","","","","","7","9","10"},
        //47
        {"ゆえに、","与えられた二つの直線","　","AB","と","C","について、","AE","は","短い方の直線C","と","等しく","","","","","1","99","99"},
        {"ゆえに、","与えられた二つの直線","　","AB","と","C","について、","AE","は","短い方の直線C","と","等しく","","","","","3","99","99"},
        {"ゆえに、","与えられた二つの直線","　","AB","と","C","について、","AE","は","短い方の直線C","と","等しく","","","","","5","99","99"},
        {"ゆえに、","与えられた二つの直線","　","AB","と","C","について、","AE","は","短い方の直線C","と","等しく","","","","","7","99","99"},
        {"ゆえに、","与えられた二つの直線","　","AB","と","C","について、","AE","は","短い方の直線C","と","等しく","","","","","9","99","99"},
        {"ゆえに、","与えられた二つの直線","　","AB","と","C","について、","AE","は","短い方の直線C","と","等しく","","","","","11","99","99"},

        //52
        {"長い方の直線AB","を","切り取る","","","","","","","","","","","","","","0","99","99"},
        {"長い方の直線AB","を","切り取る","","","","","","","","","","","","","","2","99","99"},
        //54
        {"これが求められていた", "ことであった","","","","","","","","","","","","","","","99","99","99"},


    };
    private string[,] m1_4 = new string[,]//m1_4w
    {
        {"命題I-4","","","","","","","","","","","","","","","","99","99","99"},
        {"二つの三角形", "において、","二つの辺","が","それぞれ等しく","","","","","","","","","","","","0","99","99"},
        {"二つの三角形", "において、","二つの辺","が","それぞれ等しく","","","","","","","","","","","","2","99","99"},
        {"二つの三角形", "において、","二つの辺","が","それぞれ等しく","","","","","","","","","","","","4","99","99"},
        {"二つの三角形", "において、","二つの辺","が","それぞれ等しく","","","","","","","","","","","","4","99","99"},
        {"二つの三角形", "において、","二つの辺","が","それぞれ等しく","","","","","","","","","","","","4","99","99"},


        {"その二辺に挟まれる角", "も","等しい","ならば","","","","","","","","","","","","","0","99","99"},
        {"その二辺に挟まれる角", "も","等しい","ならば","","","","","","","","","","","","","2","99","99"},
        {"その二辺に挟まれる角", "も","等しい","ならば","","","","","","","","","","","","","3","99","99"},

        {"底辺", "も","等しく","、","二つの三角形","は","等しい","","","","","","","","","","0","99","99"},
        {"底辺", "も","等しく","、","二つの三角形","は","等しい","","","","","","","","","","2","99","99"},
        {"底辺", "も","等しく","、","二つの三角形","は","等しい","","","","","","","","","","4","99","99"},
        {"底辺", "も","等しく","、","二つの三角形","は","等しい","","","","","","","","","","6","99","99"},

        {"そして、", "等しい二辺","に","対する","残りの角","も","それぞれ等しい","","","","","","","","","","1","99","99"},
        {"そして、", "等しい二辺","に","対する","残りの角","も","それぞれ等しい","","","","","","","","","","3","99","99"},
        {"そして、", "等しい二辺","に","対する","残りの角","も","それぞれ等しい","","","","","","","","","","3","99","99"},
        {"そして、", "等しい二辺","に","対する","残りの角","も","それぞれ等しい","","","","","","","","","","4","99","99"},
        {"そして、", "等しい二辺","に","対する","残りの角","も","それぞれ等しい","","","","","","","","","","6","99","99"},

        {"", "証明スタート","　　　　　　　","","","","","","","","","","","","","","1","99","99"},

        {"二つの三角形", "ABC","と","DEF","において","","","","","","","","","","","","0","99","99"},
        {"二つの三角形", "ABC","と","DEF","において","","","","","","","","","","","","1","99","99"},
        {"二つの三角形", "ABC","と","DEF","において","","","","","","","","","","","","3","99","99"},

        {"二辺", "AB","と","AC","が二辺","DE","と","DF","に","それぞれ等しい","","","","","","","1","99","99"},
        {"二辺", "AB","と","AC","が二辺","DE","と","DF","に","それぞれ等しい","","","","","","","3","99","99"},
        {"二辺", "AB","と","AC","が二辺","DE","と","DF","に","それぞれ等しい","","","","","","","5","99","99"},
        {"二辺", "AB","と","AC","が二辺","DE","と","DF","に","それぞれ等しい","","","","","","","7","99","99"},
        {"二辺", "AB","と","AC","が二辺","DE","と","DF","に","それぞれ等しい","","","","","","","9","99","99"},


        {"そして", "角BAC","と","角EDF","が","等しい","ものとする","","","","","","","","","","1","99","99"},
        {"そして", "角BAC","と","角EDF","が","等しい","ものとする","","","","","","","","","","3","99","99"},
        {"そして", "角BAC","と","角EDF","が","等しい","ものとする","","","","","","","","","","5","99","99"},
        {"そして", "角BAC","と","角EDF","が","等しい","ものとする","","","","","","","","","","6","99","99"},

        {"このとき、", "底辺BC","と","底辺EF","が","等しく","","","","","","","","","","","1","99","99"},
        {"このとき、", "底辺BC","と","底辺EF","が","等しく","","","","","","","","","","","3","99","99"},
        {"このとき、", "底辺BC","と","底辺EF","が","等しく","","","","","","","","","","","5","99","99"},

        {"角ABC", "と","角DEF","、                  ","角ACB","と","角DFE","が","等しいと主張する","","","","","","","","0","99","99"},
        {"角ABC", "と","角DEF","、                  ","角ACB","と","角DFE","が","等しいと主張する","","","","","","","","2","99","99"},
        {"角ABC", "と","角DEF","、                  ","角ACB","と","角DFE","が","等しいと主張する","","","","","","","","4","99","99"},
        {"角ABC", "と","角DEF","、                  ","角ACB","と","角DFE","が","等しいと主張する","","","","","","","","6","99","99"},
        {"角ABC", "と","角DEF","、                  ","角ACB","と","角DFE","が","等しいと主張する","","","","","","","","8","99","99"},

        {"三角形ABC", "を","三角形DEF","に","重ね合わせ","","","","","","","","","","","","0","99","99"},
        {"三角形ABC", "を","三角形DEF","に","重ね合わせ","","","","","","","","","","","","2","99","99"},
        {"三角形ABC", "を","三角形DEF","に","重ね合わせ","","","","","","","","","","","","4","99","99"},


        {"点A", "は","点D","に、","直線AB","は","直線DE","と","一致するようにする","","","","","","","","0","99","99"},
        {"点A", "は","点D","に、","直線AB","は","直線DE","と","一致するようにする","","","","","","","","2","99","99"},
        {"点A", "は","点D","に、","直線AB","は","直線DE","と","一致するようにする","","","","","","","","4","99","99"},
        {"点A", "は","点D","に、","直線AB","は","直線DE","と","一致するようにする","","","","","","","","6","99","99"},
        {"点A", "は","点D","に、","直線AB","は","直線DE","と","一致するようにする","","","","","","","","8","99","99"},

        {"このとき", "AB","と","DE","の","長さ","が","等しい","ことから","点B","は","点E","に","一致する。","","","1","99","99"},
        {"このとき", "AB","と","DE","の","長さ","が","等しい","ことから","点B","は","点E","に","一致する。","","","3","99","99"},
        {"このとき", "AB","と","DE","の","長さ","が","等しい","ことから","点B","は","点E","に","一致する。","","","5","99","99"},
        {"このとき", "AB","と","DE","の","長さ","が","等しい","ことから","点B","は","点E","に","一致する。","","","7","99","99"},
        {"このとき", "AB","と","DE","の","長さ","が","等しい","ことから","点B","は","点E","に","一致する。","","","8","99","99"},

        {"このとき", "AB","と","DE","の","長さ","が","等しい","ことから","点B","は","点E","に","一致する。","","","9","99","99"},
        {"このとき", "AB","と","DE","の","長さ","が","等しい","ことから","点B","は","点E","に","一致する。","","","11","99","99"},
        {"このとき", "AB","と","DE","の","長さ","が","等しい","ことから","点B","は","点E","に","一致する。","","","13","99","99"},

        {"AB", "と","DE","が","一致している","ことと","角BAC","が","EDF","に","等しい","ことから、","","","","","0","99","99"},
        {"AB", "と","DE","が","一致している","ことと","角BAC","が","EDF","に","等しい","ことから、","","","","","2","99","99"},
        {"AB", "と","DE","が","一致している","ことと","角BAC","が","EDF","に","等しい","ことから、","","","","","4","99","99"},
        {"AB", "と","DE","が","一致している","ことと","角BAC","が","EDF","に","等しい","ことから、","","","","","6","99","99"},
        {"AB", "と","DE","が","一致している","ことと","角BAC","が","EDF","に","等しい","ことから、","","","","","8","99","99"},
        {"AB", "と","DE","が","一致している","ことと","角BAC","が","EDF","に","等しい","ことから、","","","","","10","99","99"},
        {"AB", "と","DE","が","一致している","ことと","角BAC","が","EDF","に","等しい","ことから、","","","","","11","99","99"},

        {"直線AC", "と","DF","は","重なる","","","","","","","","","","","","0","99","99"},
        {"直線AC", "と","DF","は","重なる","","","","","","","","","","","","2","99","99"},
        {"直線AC", "と","DF","は","重なる","","","","","","","","","","","","4","99","99"},

        {"このとき", "AC","と","DF","の","長さ","が","等しい","ことから","点C","は","点F","に","一致する。","","","1","99","99"},
        {"このとき", "AC","と","DF","の","長さ","が","等しい","ことから","点C","は","点F","に","一致する。","","","3","99","99"},
        {"このとき", "AC","と","DF","の","長さ","が","等しい","ことから","点C","は","点F","に","一致する。","","","5","99","99"},
        {"このとき", "AC","と","DF","の","長さ","が","等しい","ことから","点C","は","点F","に","一致する。","","","7","99","99"},
        {"このとき", "AC","と","DF","の","長さ","が","等しい","ことから","点C","は","点F","に","一致する。","","","9","99","99"},
        {"このとき", "AC","と","DF","の","長さ","が","等しい","ことから","点C","は","点F","に","一致する。","","","11","99","99"},
        {"このとき", "AC","と","DF","の","長さ","が","等しい","ことから","点C","は","点F","に","一致する。","","","13","99","99"},


        {"点B", "は","点E","と","一致している","から","底辺BC","は","底辺EF","と","一致する","","","","","","0","99","99"},
        {"点B", "は","点E","と","一致している","から","底辺BC","は","底辺EF","と","一致する","","","","","","2","99","99"},
        {"点B", "は","点E","と","一致している","から","底辺BC","は","底辺EF","と","一致する","","","","","","4","99","99"},
        {"点B", "は","点E","と","一致している","から","底辺BC","は","底辺EF","と","一致する","","","","","","6","99","99"},
        {"点B", "は","点E","と","一致している","から","底辺BC","は","底辺EF","と","一致する","","","","","","8","99","99"},
        {"点B", "は","点E","と","一致している","から","底辺BC","は","底辺EF","と","一致する","","","","","","10","99","99"},

        {"なぜならば、", "もし一致しないとすれば","同じ点","を","結ぶ直線","は","唯一つであること",
            "に","反するからである","","　　　　　","[公準P-1]","　　　　　",
            "任意の点から任意の点","へ直線を引くこと","","1","99","99"},
        {"なぜならば、", "もし一致しないとすれば","同じ点","を","結ぶ直線","は","唯一つであること",
            "に","反するからである","","　　　　　","[公準P-1]","　　　　　",
            "任意の点から任意の点","へ直線を引くこと","","2","99","99"},
        {"なぜならば、", "もし一致しないとすれば","同じ点","を","結ぶ直線","は","唯一つであること",
            "に","反するからである","","　　　　　","[公準P-1]","　　　　　",
            "任意の点から任意の点","へ直線を引くこと","","4","99","99"},
        {"なぜならば、", "もし一致しないとすれば","同じ点","を","結ぶ直線","は","唯一つであること",
            "に","反するからである","","　　　　　","[公準P-1]","　　　　　",
            "任意の点から任意の点","へ直線を引くこと","","6","99","99"},
        {"なぜならば、", "もし一致しないとすれば","同じ点","を","結ぶ直線","は","唯一つであること",
            "に","反するからである","","　　　　　","[公準P-1]","　　　　　",
            "任意の点から任意の点","へ直線を引くこと","","8","99","99"},
        {"なぜならば、", "もし一致しないとすれば","同じ点","を","結ぶ直線","は","唯一つであること",
            "に","反するからである","","　　　　　","[公準P-1]","　　　　　",
            "任意の点から任意の点","へ直線を引くこと","","11","13","14"},

        {"したがって、", "底辺BC","と","底辺EF","は","一致し、互いに等しい",
            "　　","[公理A-4]","　　　　　　　　　　　","互いに重なり合うもの","は互いに等しい",
            "","","","","","1","99","99"},
        {"したがって、", "底辺BC","と","底辺EF","は","一致し、互いに等しい",
            "　　","[公理A-4]","　　　　　　　　　　　","互いに重なり合うもの","は互いに等しい",
            "","","","","","3","99","99"},
        {"したがって、", "底辺BC","と","底辺EF","は","一致し、互いに等しい",
            "　　","[公理A-4]","　　　　　　　　　　　","互いに重なり合うもの","は互いに等しい",
            "","","","","","5","99","99"},
        {"したがって、", "底辺BC","と","底辺EF","は","一致し、互いに等しい",
            "　　","[公理A-4]","　　　　　　　　　　　","互いに重なり合うもの","は互いに等しい",
            "","","","","","7","9","10"},

        {"したがって、", "三角形ABC","と","三角形DEF","は","完全に一致し、互いに等しい",
            "　　","[公理A-4]","　　　　　　　　　　　","互いに重なり合うもの","は互いに等しい",
            "","","","","","1","99","99"},
        {"したがって、", "三角形ABC","と","三角形DEF","は","完全に一致し、互いに等しい",
            "　　","[公理A-4]","　　　　　　　　　　　","互いに重なり合うもの","は互いに等しい",
            "","","","","","3","99","99"},
        {"したがって、", "三角形ABC","と","三角形DEF","は","完全に一致し、互いに等しい",
            "　　","[公理A-4]","　　　　　　　　　　　","互いに重なり合うもの","は互いに等しい",
            "","","","","","5","99","99"},
        {"したがって、", "三角形ABC","と","三角形DEF","は","完全に一致し、互いに等しい",
            "　　","[公理A-4]","　　　　　　　　　　　","互いに重なり合うもの","は互いに等しい",
            "","","","","","7","9","10"},

        {"したがって、","残りの角", "も","それぞれ一致し、","互いに等しい",
            "","[公理A-4]","　　　　　　　","互いに重なり合うもの","は互いに等しい",
            "","","","","","","1","99","99"},
       {"したがって、","残りの角", "も","それぞれ一致し、","互いに等しい",
            "","[公理A-4]","　　　　　　　","互いに重なり合うもの","は互いに等しい",
            "","","","","","","3","4","99"},
       {"したがって、","残りの角", "も","それぞれ一致し、","互いに等しい",
            "","[公理A-4]","　　　　　　　","互いに重なり合うもの","は互いに等しい",
            "","","","","","","6","8","9"},

        {"ゆえに、", "二つの三角形","において、","二つの辺","が","それぞれ等しく","","","","","","","","","","","1","99","99"},
        {"ゆえに、", "二つの三角形","において、","二つの辺","が","それぞれ等しく","","","","","","","","","","","3","99","99"},
        {"ゆえに、", "二つの三角形","において、","二つの辺","が","それぞれ等しく","","","","","","","","","","","5","99","99"},
        {"ゆえに、", "二つの三角形","において、","二つの辺","が","それぞれ等しく","","","","","","","","","","","5","99","99"},
        {"ゆえに、", "二つの三角形","において、","二つの辺","が","それぞれ等しく","","","","","","","","","","","5","99","99"},

        {"その二辺に挟まれる角", "も","等しい","ならば","","","","","","","","","","","","","0","99","99"},
        {"その二辺に挟まれる角", "も","等しい","ならば","","","","","","","","","","","","","2","99","99"},
        {"その二辺に挟まれる角", "も","等しい","ならば","","","","","","","","","","","","","3","99","99"},

        {"底辺", "も","等しく","、","二つの三角形","は","等しい","","","","","","","","","","0","99","99"},
        {"底辺", "も","等しく","、","二つの三角形","は","等しい","","","","","","","","","","2","99","99"},
        {"底辺", "も","等しく","、","二つの三角形","は","等しい","","","","","","","","","","4","99","99"},
        {"底辺", "も","等しく","、","二つの三角形","は","等しい","","","","","","","","","","6","99","99"},

        {"そして、", "等しい二辺","に","対する","残りの角","も","それぞれ等しい","","","","","","","","","","1","99","99"},
        {"そして、", "等しい二辺","に","対する","残りの角","も","それぞれ等しい","","","","","","","","","","3","99","99"},
        {"そして、", "等しい二辺","に","対する","残りの角","も","それぞれ等しい","","","","","","","","","","3","99","99"},
        {"そして、", "等しい二辺","に","対する","残りの角","も","それぞれ等しい","","","","","","","","","","4","99","99"},
        {"そして、", "等しい二辺","に","対する","残りの角","も","それぞれ等しい","","","","","","","","","","6","99","99"},

        { "これが証明すべきことであった。","","","","","","","","","","","","","","","","99","99","99"},



    };
    //m1_5w
    private string[,] m1_5 = new string[,]
    {
        {"命題I-5","","","","","","","","","","","","","","","","99","99","99"},
        {"二等辺三角形", "の","底辺上","の","二つの角","は互いに等しい","","","","","","","","","","","0","99","99"},
        {"二等辺三角形", "の","底辺上","の","二つの角","は互いに等しい","","","","","","","","","","","2","99","99"},
        {"二等辺三角形", "の","底辺上","の","二つの角","は互いに等しい","","","","","","","","","","","4","99","99"},
        {"二等辺三角形", "の","底辺上","の","二つの角","は互いに等しい","","","","","","","","","","","5","99","99"},


        {"そして、", "等辺","を延長してできる","底辺下の","二つの角","も互いに等しい。","","","","","","","","","","","1","99","99"},
        {"そして、", "等辺","を延長してできる","底辺下の","二つの角","も互いに等しい。","","","","","","","","","","","2","99","99"},
        {"そして、", "等辺","を延長してできる","底辺下の","二つの角","も互いに等しい。","","","","","","","","","","","3","99","99"},

        {"そして、", "等辺","を延長してできる","底辺下の","二つの角","も互いに等しい。","","","","","","","","","","","4","99","99"},
        {"そして、", "等辺","を延長してできる","底辺下の","二つの角","も互いに等しい。","","","","","","","","","","","5","99","99"},

        {"", "証明スタート","　　　　　　　","","","","","","","","","","","","","","1","99","99"},

        //{"　　　　　　   ", "証明","　　　　　　　","","","","","","","","","","","","","","1","99","99"},
        //shoumei
        {"ABC", "を","辺AB","と","辺AC","が等しい","二等辺三角形","とし、","","","","","","","","","0","99","99"},
        {"ABC", "を","辺AB","と","辺AC","が等しい","二等辺三角形","とし、","","","","","","","","","2","99","99"},
        {"ABC", "を","辺AB","と","辺AC","が等しい","二等辺三角形","とし、","","","","","","","","","4","99","99"},
        {"ABC", "を","辺AB","と","辺AC","が等しい","二等辺三角形","とし、","","","","","","","","","5","99","99"},

        {"ABC", "を","辺AB","と","辺AC","が等しい","二等辺三角形","とし、","","","","","","","","","6","99","99"},

        {"BD", "と","CE","を","AB","と",
            "AC","のそれぞれ","延長した","直線とする","           ","[公準P-2]","   　　　　　","任意の直線を連続して延ばすこと。","","","0","99","99"},
        {"BD", "と","CE","を","AB","と",
            "AC","のそれぞれ","延長した","直線とする","           ","[公準P-2]","   　　　　　","任意の直線を連続して延ばすこと。","","","2","99","99"},
        {"BD", "と","CE","を","AB","と",
            "AC","のそれぞれ","延長した","直線とする","           ","[公準P-2]","   　　　　　","任意の直線を連続して延ばすこと。","","","4","99","99"},
        {"BD", "と","CE","を","AB","と",
            "AC","のそれぞれ","延長した","直線とする","           ","[公準P-2]","   　　　　　","任意の直線を連続して延ばすこと。","","","6","99","99"},

        {"BD", "と","CE","を","AB","と",
            "AC","のそれぞれ","延長した","直線とする","           ","[公準P-2]","   　　　　　","任意の直線を連続して延ばすこと。","","","8","9","99"},
        {"BD", "と","CE","を","AB","と",
            "AC","のそれぞれ","延長した","直線とする","           ","[公準P-2]","   　　　　　","任意の直線を連続して延ばすこと。","","","11","13","99"},

        {"このとき、", "角ABC","と","ACB","が等しいと主張する。","さらに","角CBD","と","BCE","が等しいと主張する。","","","","","","","1","99","99"},
        {"このとき、", "角ABC","と","ACB","が等しいと主張する。","さらに","角CBD","と","BCE","が等しいと主張する。","","","","","","","3","99","99"},
        {"このとき、", "角ABC","と","ACB","が等しいと主張する。","さらに","角CBD","と","BCE","が等しいと主張する。","","","","","","","4","99","99"},
        {"このとき、", "角ABC","と","ACB","が等しいと主張する。","さらに","角CBD","と","BCE","が等しいと主張する。","","","","","","","6","99","99"},
        {"このとき、", "角ABC","と","ACB","が等しいと主張する。","さらに","角CBD","と","BCE","が等しいと主張する。","","","","","","","8","99","99"},
        {"このとき、", "角ABC","と","ACB","が等しいと主張する。","さらに","角CBD","と","BCE","が等しいと主張する。","","","","","","","9","99","99"},



        {"点F", "を","BD","上にとる","　　　　　　　",
            "AE","から","点A","を始点として",
            "AFの長さ","を切り取る","　　　　　",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","0","99","99"},
        {"点F", "を","BD","上にとる","　　　　　　　",
            "AE","から","点A","を始点として",
            "AFの長さ","を切り取る","　　　　　",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","2","99","99"},
        {"点F", "を","BD","上にとる","　　　　　　　",
            "AE","から","点A","を始点として",
            "AFの長さ","を切り取る","　　　　　",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","5","99","99"},
        {"点F", "を","BD","上にとる","　　　　　　　",
            "AE","から","点A","を始点として",
            "AFの長さ","を切り取る","　　　　　",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","7","99","99"},
        {"点F", "を","BD","上にとる","　　　　　　　",
            "AE","から","点A","を始点として",
            "AFの長さ","を切り取る","　　　　　",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","8","99","99"},
        {"点F", "を","BD","上にとる","　　　　　　　",
            "AE","から","点A","を始点として",
            "AFの長さ","を切り取る","　　　　　",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","9","99","99"},
        {"点F", "を","BD","上にとる","　　　　　　　",
            "AE","から","点A","を始点として",
            "AFの長さ","を切り取る","　　　　　",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","10","99","99"},
        {"点F", "を","BD","上にとる","　　　　　　　",
            "AE","から","点A","を始点として",
            "AFの長さ","を切り取る","　　　　　",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","12","13","14"},

        {"切り取った直線", "の","終点","を","G","とする","","","","","","","","","","","0","99","99"},
        {"切り取った直線", "の","終点","を","G","とする","","","","","","","","","","","2","99","99"},
        {"切り取った直線", "の","終点","を","G","とする","","","","","","","","","","","4","99","99"},


        {"そして、", "直線FC","を描く","さらに","直線GB","を描く",
            "                  ","[公準P-1]","         ","任意の点から任意の点へ","直線を引くこと。","","","","","","1","2","99"},
        {"そして、", "直線FC","を描く","さらに","直線GB","を描く",
            "                  ","[公準P-1]","         ","任意の点から任意の点へ","直線を引くこと。","","","","","","4","5","99"},

        {"そして、", "直線FC","を描く","さらに","直線GB","を描く",
            "                  ","[公準P-1]","         ","任意の点から任意の点へ","直線を引くこと。","","","","","","7","9","10"},


        {"三角形AFC", "と","三角形AGB","は","",
            "","","","","",
            "","","","","",
            "","0","99","99"},
        {"三角形AFC", "と","三角形AGB","は","",
            "","","","","",
            "","","","","",
            "","2","99","99"},

        {"AF", "と","AG","が","等しく","　　　　　",
            "AC","と","AB","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "0","99","99"},
        {"AF", "と","AG","が","等しく","　　　　　",
            "AC","と","AB","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "2","99","99"},
        {"AF", "と","AG","が","等しく","　　　　　",
            "AC","と","AB","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "4","99","99"},
        {"AF", "と","AG","が","等しく","　　　　　",
            "AC","と","AB","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "6","99","99"},
        {"AF", "と","AG","が","等しく","　　　　　",
            "AC","と","AB","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "8","99","99"},
        {"AF", "と","AG","が","等しく","　　　　　",
            "AC","と","AB","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "10","99","99"},
        {"AF", "と","AG","が","等しく","　　　　　",
            "AC","と","AB","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "12","99","99"},
        {"AF", "と","AG","が","等しく","　　　　　",
            "AC","と","AB","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "12","99","99"},
        {"AF", "と","AG","が","等しく","　　　　　",
            "AC","と","AB","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "14","99","99"},

        {"なので","三角形AFC", "と","三角形AGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","1","99","99"},
        {"なので","三角形AFC", "と","三角形AGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","3","99","99"},
        {"なので","三角形AFC", "と","三角形AGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","5","99","99"},
        {"なので","三角形AFC", "と","三角形AGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","5","99","99"},
        {"なので","三角形AFC", "と","三角形AGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","7","99","99"},
        {"なので","三角形AFC", "と","三角形AGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","7","99","99"},
        {"なので","三角形AFC", "と","三角形AGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","9","99","99"},
        {"なので","三角形AFC", "と","三角形AGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","9","99","99"},
        {"なので","三角形AFC", "と","三角形AGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","9","99","99"},
        {"なので","三角形AFC", "と","三角形AGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","9","99","99"},
        {"なので","三角形AFC", "と","三角形AGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","9","99","99"},





        {"命題I-4", "","","","",
            "二辺とその間の角が等しい三角形は","","","","",
            "残りの辺と角も互いに等しい。","","","","",
            "","0","5","10"},
        {"命題I-4", "","","","",
            "二辺とその間の角が等しい三角形は","","","","",
            "残りの辺と角も互いに等しい。","","","","",
            "","0","5","10"},

        {"AF", "と","AG","は等しいから、","","","","","","","","","","","","","0","99","99"},
        {"AF", "と","AG","は等しいから、","","","","","","","","","","","","","2","99","99"},
        {"AF", "と","AG","は等しいから、","","","","","","","","","","","","","3","99","99"},

        {"そこから相等しい", "AB","と","AC","を引いた差の","BF",
            "と","CG","は等しい","[公理A-3]","　　　　　　　　　　　","等しいものから等しいものを引いた","差は互いに等しい。","","","","1","99","99"},
        {"そこから相等しい", "AB","と","AC","を引いた差の","BF",
            "と","CG","は等しい","[公理A-3]","　　　　　　　　　　　","等しいものから等しいものを引いた","差は互いに等しい。","","","","3","99","99"},
        {"そこから相等しい", "AB","と","AC","を引いた差の","BF",
            "と","CG","は等しい","[公理A-3]","　　　　　　　　　　　","等しいものから等しいものを引いた","差は互いに等しい。","","","","4","99","99"},
        {"そこから相等しい", "AB","と","AC","を引いた差の","BF",
            "と","CG","は等しい","[公理A-3]","　　　　　　　　　　　","等しいものから等しいものを引いた","差は互いに等しい。","","","","5","99","99"},
        {"そこから相等しい", "AB","と","AC","を引いた差の","BF",
            "と","CG","は等しい","[公理A-3]","　　　　　　　　　　　","等しいものから等しいものを引いた","差は互いに等しい。","","","","7","99","99"},
        {"そこから相等しい", "AB","と","AC","を引いた差の","BF",
            "と","CG","は等しい","[公理A-3]","　　　　　　　　　　　","等しいものから等しいものを引いた","差は互いに等しい。","","","","8","99","99"},
        {"そこから相等しい", "AB","と","AC","を引いた差の","BF",
            "と","CG","は等しい","[公理A-3]","　　　　　　　　　　　","等しいものから等しいものを引いた","差は互いに等しい。","","","","9","11","12"},
        {"そこから相等しい", "AB","と","AC","を引いた差の","BF",
            "と","CG","は等しい","[公理A-3]","　　　　　　　　　　　","等しいものから等しいものを引いた","差は互いに等しい。","","","","9","11","12"},
        {"そこから相等しい", "AB","と","AC","を引いた差の","BF",
            "と","CG","は等しい","[公理A-3]","　　　　　　　　　　　","等しいものから等しいものを引いた","差は互いに等しい。","","","","9","11","12"},

        {"三角形BFC", "と","三角形CBG","は","",
            "","","","","",
            "","","","","",
            "","0","99","99"},
        {"三角形BFC", "と","三角形CBG","は","",
            "","","","","",
            "","","","","",
            "","2","99","99"},

        {"BF", "と","CG","が","等しく","　　　　　　",
            "CF","と","BG","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "0","99","99"},
        {"BF", "と","CG","が","等しく","　　　　　　",
            "CF","と","BG","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "2","99","99"},
        {"BF", "と","CG","が","等しく","　　　　　　",
            "CF","と","BG","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "4","99","99"},
        {"BF", "と","CG","が","等しく","　　　　　　",
            "CF","と","BG","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "6","99","99"},
        {"BF", "と","CG","が","等しく","　　　　　　",
            "CF","と","BG","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "8","99","99"},
        {"BF", "と","CG","が","等しく","　　　　　　",
            "CF","と","BG","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "10","99","99"},
        {"BF", "と","CG","が","等しく","　　　　　　",
            "CF","と","BG","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "12","99","99"},
        {"BF", "と","CG","が","等しく","　　　　　　",
            "CF","と","BG","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "12","99","99"},
        {"BF", "と","CG","が","等しく","　　　　　　",
            "CF","と","BG","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "14","99","99"},

        {"なので","三角形BFC", "と","三角形CGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","1","99","99"},
        {"なので","三角形BFC", "と","三角形CGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","3","99","99"},
        {"なので","三角形BFC", "と","三角形CGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","5","99","99"},
        {"なので","三角形BFC", "と","三角形CGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","5","99","99"},
        {"なので","三角形BFC", "と","三角形CGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","7","99","99"},
        {"なので","三角形BFC", "と","三角形CGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","7","99","99"},
        {"なので","三角形BFC", "と","三角形CGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","9","99","99"},
        {"なので","三角形BFC", "と","三角形CGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","9","99","99"},
        {"なので","三角形BFC", "と","三角形CGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","9","99","99"},
        {"なので","三角形BFC", "と","三角形CGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","9","99","99"},
        {"なので","三角形BFC", "と","三角形CGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","9","99","99"},


        {"命題I-4", "","","","",
            "二辺とその間の角が等しい三角形は","","","","",
            "残りの辺と角も互いに等しい。","","","","",
            "","0","5","10"},
        {"命題I-4", "","","","",
            "二辺とその間の角が等しい三角形は","","","","",
            "残りの辺と角も互いに等しい。","","","","",
            "","0","5","10"},



        {"よって,", "角FBC","と","角GCB","は","等しい","また,","角BCF","と","角CBG","は","等しい","","","","","1","99","99"},
        {"よって,", "角FBC","と","角GCB","は","等しい","また,","角BCF","と","角CBG","は","等しい","","","","","3","99","99"},
        {"よって,", "角FBC","と","角GCB","は","等しい","また,","角BCF","と","角CBG","は","等しい","","","","","5","99","99"},
        {"よって,", "角FBC","と","角GCB","は","等しい","また,","角BCF","と","角CBG","は","等しい","","","","","7","99","99"},
        {"よって,", "角FBC","と","角GCB","は","等しい","また,","角BCF","と","角CBG","は","等しい","","","","","9","99","99"},
        {"よって,", "角FBC","と","角GCB","は","等しい","また,","角BCF","と","角CBG","は","等しい","","","","","11","99","99"},




        {"角ABG", "と","角ACF","は","等しい","が、","","","","","","","","","","","0","99","99"},
        {"角ABG", "と","角ACF","は","等しい","が、","","","","","","","","","","","2","99","99"},
        {"角ABG", "と","角ACF","は","等しい","が、","","","","","","","","","","","4","99","99"},


        {"これらから", "CBG","と","BCF","を引いた残りの","ABC",
            "と","ACB","は","等しい","　　　　　　　　　　　","[公理A-3]","等しいものから等しいものを引いた","差は互いに等しい。","","","0","99","99"},
        {"これらから", "CBG","と","BCF","を引いた残りの","ABC",
            "と","ACB","は","等しい","　　　　　　　　　　　","[公理A-3]","等しいものから等しいものを引いた","差は互いに等しい。","","","1","99","99"},
        {"これらから", "CBG","と","BCF","を引いた残りの","ABC",
            "と","ACB","は","等しい","　　　　　　　　　　　","[公理A-3]","等しいものから等しいものを引いた","差は互いに等しい。","","","3","99","99"},
        {"これらから", "CBG","と","BCF","を引いた残りの","ABC",
            "と","ACB","は","等しい","　　　　　　　　　　　","[公理A-3]","等しいものから等しいものを引いた","差は互いに等しい。","","","4","99","99"},
        {"これらから", "CBG","と","BCF","を引いた残りの","ABC",
            "と","ACB","は","等しい","　　　　　　　　　　　","[公理A-3]","等しいものから等しいものを引いた","差は互いに等しい。","","","5","99","99"},
        {"これらから", "CBG","と","BCF","を引いた残りの","ABC",
            "と","ACB","は","等しい","　　　　　　　　　　　","[公理A-3]","等しいものから等しいものを引いた","差は互いに等しい。","","","7","99","99"},
        {"これらから", "CBG","と","BCF","を引いた残りの","ABC",
            "と","ACB","は","等しい","　　　　　　　　　　　","[公理A-3]","等しいものから等しいものを引いた","差は互いに等しい。","","","9","99","99"},
        {"これらから", "CBG","と","BCF","を引いた残りの","ABC",
            "と","ACB","は","等しい","　　　　　　　　　　　","[公理A-3]","等しいものから等しいものを引いた","差は互いに等しい。","","","11","12","13"},
        {"これらから", "CBG","と","BCF","を引いた残りの","ABC",
            "と","ACB","は","等しい","　　　　　　　　　　　","[公理A-3]","等しいものから等しいものを引いた","差は互いに等しい。","","","11","12","13"},
        {"これらから", "CBG","と","BCF","を引いた残りの","ABC",
            "と","ACB","は","等しい","　　　　　　　　　　　","[公理A-3]","等しいものから等しいものを引いた","差は互いに等しい。","","","11","12","13"},

        {"これら","は", "三角形ABC","の","底辺上にある。","また","FBC","と","GCB","も","等しく、","これら","は","底辺下にある","","","0","99","99"},
        {"これら","は", "三角形ABC","の","底辺上にある。","また","FBC","と","GCB","も","等しく、","これら","は","底辺下にある","","","2","99","99"},
        {"これら","は", "三角形ABC","の","底辺上にある。","また","FBC","と","GCB","も","等しく、","これら","は","底辺下にある","","","4","99","99"},
        {"これら","は", "三角形ABC","の","底辺上にある。","また","FBC","と","GCB","も","等しく、","これら","は","底辺下にある","","","6","99","99"},
        {"これら","は", "三角形ABC","の","底辺上にある。","また","FBC","と","GCB","も","等しく、","これら","は","底辺下にある","","","8","99","99"},
        {"これら","は", "三角形ABC","の","底辺上にある。","また","FBC","と","GCB","も","等しく、","これら","は","底辺下にある","","","10","99","99"},
        {"これら","は", "三角形ABC","の","底辺上にある。","また","FBC","と","GCB","も","等しく、","これら","は","底辺下にある","","","11","99","99"},
        {"これら","は", "三角形ABC","の","底辺上にある。","また","FBC","と","GCB","も","等しく、","これら","は","底辺下にある","","","13","99","99"},


        {"ゆえに、", "二等辺三角形","の","底辺上","の","二つの角","は","互いに等しい、","","","","","","","","","1","99","99"},
        {"ゆえに、", "二等辺三角形","の","底辺上","の","二つの角","は","互いに等しい、","","","","","","","","","3","99","99"},
        {"ゆえに、", "二等辺三角形","の","底辺上","の","二つの角","は","互いに等しい、","","","","","","","","","5","99","99"},
        {"ゆえに、", "二等辺三角形","の","底辺上","の","二つの角","は","互いに等しい、","","","","","","","","","7","99","99"},


        {"そして、", "等辺","を","延長してできる","底辺下","の","二つの角","も","互いに等しい。","","","","","","","","1","99","99"},
        {"そして、", "等辺","を","延長してできる","底辺下","の","二つの角","も","互いに等しい。","","","","","","","","3","99","99"},
        {"そして、", "等辺","を","延長してできる","底辺下","の","二つの角","も","互いに等しい。","","","","","","","","4","99","99"},
        {"そして、", "等辺","を","延長してできる","底辺下","の","二つの角","も","互いに等しい。","","","","","","","","6","99","99"},
        {"そして、", "等辺","を","延長してできる","底辺下","の","二つの角","も","互いに等しい。","","","","","","","","8","99","99"},



        {"これが証明すべきことであった。", "","","","","","","","","","","","","","","","99","99","99"},
        //{"", "","","","","","","","","","","99"},
    };
    private string[,] m1_6 = new string[,]//m1_6w
    {
        {"命題I-6","","","","","","","","","","","","","","","","99","99","99"},
        {"三角形", "の","二つの角","が","等しい","ならば、","それら","に","対する","二つの辺","も","互いに等しい","","","","","0","99","99"},
        {"三角形", "の","二つの角","が","等しい","ならば、","それら","に","対する","二つの辺","も","互いに等しい","","","","","2","99","99"},
        {"三角形", "の","二つの角","が","等しい","ならば、","それら","に","対する","二つの辺","も","互いに等しい","","","","","4","99","99"},
        {"三角形", "の","二つの角","が","等しい","ならば、","それら","に","対する","二つの辺","も","互いに等しい","","","","","6","99","99"},
        {"三角形", "の","二つの角","が","等しい","ならば、","それら","に","対する","二つの辺","も","互いに等しい","","","","","8","99","99"},
        {"三角形", "の","二つの角","が","等しい","ならば、","それら","に","対する","二つの辺","も","互いに等しい","","","","","8","99","99"},
        {"三角形", "の","二つの角","が","等しい","ならば、","それら","に","対する","二つの辺","も","互いに等しい","","","","","9","99","99"},
        {"三角形", "の","二つの角","が","等しい","ならば、","それら","に","対する","二つの辺","も","互いに等しい","","","","","11","99","99"},

        {"", "証明スタート","　　　　　　　","","","","","","","","","","","","","","1","99","99"},

        {"三角形ABC", "において","角ABC","と","角ACB","が","等しいものとする","","","","","","","","","","0","99","99"},
        {"三角形ABC", "において","角ABC","と","角ACB","が","等しいものとする","","","","","","","","","","2","99","99"},
        {"三角形ABC", "において","角ABC","と","角ACB","が","等しいものとする","","","","","","","","","","4","99","99"},
        {"三角形ABC", "において","角ABC","と","角ACB","が","等しいものとする","","","","","","","","","","6","99","99"},

        {"このとき、", "辺AB","が","辺AC","に","等しいと主張する","","","","","","","","","","","1","99","99"},
        {"このとき、", "辺AB","が","辺AC","に","等しいと主張する","","","","","","","","","","","3","99","99"},
        {"このとき、", "辺AB","が","辺AC","に","等しいと主張する","","","","","","","","","","","5","99","99"},

        {"もし", "AB","が","AC","と","等しくなければ","どちらかが","長いことになる","","","","","","","","","1","99","99"},
        {"もし", "AB","が","AC","と","等しくなければ","どちらかが","長いことになる","","","","","","","","","3","99","99"},
        {"もし", "AB","が","AC","と","等しくなければ","どちらかが","長いことになる","","","","","","","","","5","99","99"},
        {"もし", "AB","が","AC","と","等しくなければ","どちらかが","長いことになる","","","","","","","","","6","99","99"},
        {"もし", "AB","が","AC","と","等しくなければ","どちらかが","長いことになる","","","","","","","","","7","99","99"},


        {"AB", "が","AC","より","長いとすれば、","AC","と","同じ長さの","直線DB","を","切り取ることができる",
            "         ",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","0","99","99"},
        {"AB", "が","AC","より","長いとすれば、","AC","と","同じ長さの","直線DB","を","切り取ることができる",
            "         ",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","2","99","99"},
        {"AB", "が","AC","より","長いとすれば、","AC","と","同じ長さの","直線DB","を","切り取ることができる",
            "         ",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","4","99","99"},
        {"AB", "が","AC","より","長いとすれば、","AC","と","同じ長さの","直線DB","を","切り取ることができる",
            "         ",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","5","99","99"},
        {"AB", "が","AC","より","長いとすれば、","AC","と","同じ長さの","直線DB","を","切り取ることができる",
            "         ",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","7","99","99"},
        {"AB", "が","AC","より","長いとすれば、","AC","と","同じ長さの","直線DB","を","切り取ることができる",
            "         ",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","8","99","99"},
        {"AB", "が","AC","より","長いとすれば、","AC","と","同じ長さの","直線DB","を","切り取ることができる",
            "         ",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","10","99","99"},
        {"AB", "が","AC","より","長いとすれば、","AC","と","同じ長さの","直線DB","を","切り取ることができる",
            "         ",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","12","13","14"},

        {"このとき、", "直線DC","を","引く","         ","[公準P-1]",
            "                 ","任意の点から任意の点へ","直線を引くこと。","","",
            "","","","","",
            "1","99","99"},
        {"このとき、", "直線DC","を","引く","         ","[公準P-1]",
            "                 ","任意の点から任意の点へ","直線を引くこと。","","",
            "","","","","",
            "3","99","99"},
        {"このとき、", "直線DC","を","引く","         ","[公準P-1]",
            "                 ","任意の点から任意の点へ","直線を引くこと。","","",
            "","","","","",
            "5","7","8"},

        {"三角形ABC", "と","三角形DCB","は","",
            "","","","","",
            "","","","","",
            "","0","99","99"},
        {"三角形ABC", "と","三角形DCB","は","",
            "","","","","",
            "","","","","",
            "","2","99","99"},

        {"AC", "と","DB","が","ひとしく","　　　　　",
            "BC","","","が","ひとしく","　　　　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "0","99","99"},
        {"AC", "と","DB","が","ひとしく","　　　　　",
            "BC","","","が","ひとしく","　　　　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "2","99","99"},
        {"AC", "と","DB","が","ひとしく","　　　　　",
            "BC","","","が","ひとしく","　　　　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "4","99","99"},
        {"AC", "と","DB","が","ひとしく","　　　　　",
            "BC","","","が","ひとしく","　　　　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "6","99","99"},
        {"AC", "と","DB","が","ひとしく","　　　　　",
            "BC","","","が","ひとしく","　　　　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "6","99","99"},
        {"AC", "と","DB","が","ひとしく","　　　　　",
            "BC","","","が","ひとしく","　　　　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "10","99","99"},
        {"AC", "と","DB","が","ひとしく","　　　　　",
            "BC","","","が","ひとしく","　　　　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "12","99","99"},
        {"AC", "と","DB","が","ひとしく","　　　　　",
            "BC","","","が","ひとしく","　　　　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "12","99","99"},
        {"AC", "と","DB","が","ひとしく","　　　　　",
            "BC","","","が","ひとしく","　　　　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "14","99","99"},

        {"なので","三角形ABC", "と","三角形DCB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","1","99","99"},
        {"なので","三角形ABC", "と","三角形DCB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","3","99","99"},
        {"なので","三角形ABC", "と","三角形DCB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","5","99","99"},
        {"なので","三角形ABC", "と","三角形DCB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","5","99","99"},
        {"なので","三角形ABC", "と","三角形DCB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","7","99","99"},
        {"なので","三角形ABC", "と","三角形DCB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","7","99","99"},
        {"なので","三角形ABC", "と","三角形DCB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","9","99","99"},

        {"命題I-4", "","","","",
            "二辺とその間の角が等しい三角形は","","","","",
            "残りの辺と角も互いに等しい。","","","","",
            "","0","5","10"},
        


        
        //{"よって、", "底辺DC","は","AB","と等しく、","三角形DBC","と","三角形ACB","は等しい","[命題I-4]","","","","","","","1","99","99"},
        //{"よって、", "底辺DC","は","AB","と等しく、","三角形DBC","と","三角形ACB","は等しい","[命題I-4]","","","","","","","3","99","99"},
        //{"よって、", "底辺DC","は","AB","と等しく、","三角形DBC","と","三角形ACB","は等しい","[命題I-4]","","","","","","","5","99","99"},
        //{"よって、", "底辺DC","は","AB","と等しく、","三角形DBC","と","三角形ACB","は等しい","[命題I-4]","","","","","","","7","99","99"},

        //{"よって、", "底辺DC","は","AB","と等しく、","三角形DBC","と","三角形ACB","は等しい","[命題I-4]","","","","","","","1","99","99"},
        //{"よって、", "三角形ABC","は","三角形DBC","と","等しい","","","","","","","","","","","1","99","99"},
        {"よって、", "角DCB","は","角ABC","と",
            "等しい","","","","",
            "","","","","","","1","99","99"},
        {"よって、", "角DCB","は","角ABC","と",
            "等しい","","","","",
            "","","","","","","3","99","99"},
        {"よって、", "角DCB","は","角ABC","と",
            "等しい","","","","",
            "","","","","","","5","99","99"},


        {"また", "角ABC","は","角ACB","と",
            "等しい","","","","",
            "","","","","","","1","99","99"},
        {"また", "角ABC","は","角ACB","と",
            "等しい","","","","",
            "","","","","","","3","99","99"},
        {"また", "角ABC","は","角ACB","と",
            "等しい","","","","",
            "","","","","","","5","99","99"},

        {"よって", "角DCB","は","角ACB","と",
            "等しい","","","","",
            "","","","","","","1","99","99"},
        {"よって", "角DCB","は","角ACB","と",
            "等しい","","","","",
            "","","","","","","3","99","99"},
        {"よって", "角DCB","は","角ACB","と",
            "等しい","","","","",
            "","","","","","","5","99","99"},

        {"公理A-1", "　　　　　","","","",
            "同じものに等しいものは","","","","",
            "互いに等しい","","","","",
            "","0","5","10"},


        {"しかし、","これは", "小さいもの","と","   ",
            "大きいもの","が","等しいことになり","矛盾である","","",
            "","","","","","1","99","99"},
        {"しかし、","これは", "小さいもの","と","   ",
            "大きいもの","が","等しいことになり","矛盾である","","",
            "","","","","","2","99","99"},
        {"しかし、","これは", "小さいもの","と","   ",
            "大きいもの","が","等しいことになり","矛盾である","","",
            "","","","","","5","99","99"},
        {"しかし、","これは", "小さいもの","と","   ",
            "大きいもの","が","等しいことになり","矛盾である","","",
            "","","","","","7","99","99"},
        {"しかし、","これは", "小さいもの","と","   ",
            "大きいもの","が","等しいことになり","矛盾である","","",
            "","","","","","8","99","99"},

        {"公理A-5","　　　　　　　　　　　　","","","",
            "全体は部分より大きい","","","","",
            "","","","","","","0","5","99"},
        
        
        
        //{"これは", "小さいもの","と","大きいもの","が等しいことになり矛盾である","[公理A-5]","","","","","","","","","","","3","99","99"},
        
        {"したがって、", "AB","と","AC","は","等しい","","","","","","","","","","","1","99","99"},
        {"したがって、", "AB","と","AC","は","等しい","","","","","","","","","","","3","99","99"},
        {"したがって、", "AB","と","AC","は","等しい","","","","","","","","","","","5","99","99"},

        {"ゆえに、", "三角形","の","二つの角","が",
            "等しいならば、","それら","に","対する","二つの辺",
            "も","互いに等しい。","","","","","1","99","99"},
        {"ゆえに、", "三角形","の","二つの角","が",
            "等しいならば、","それら","に","対する","二つの辺",
            "も","互いに等しい。","","","","","3","99","99"},
        {"ゆえに、", "三角形","の","二つの角","が",
            "等しいならば、","それら","に","対する","二つの辺",
            "も","互いに等しい。","","","","","5","99","99"},
        {"ゆえに、", "三角形","の","二つの角","が",
            "等しいならば、","それら","に","対する","二つの辺",
            "も","互いに等しい。","","","","","6","99","99"},
        {"ゆえに、", "三角形","の","二つの角","が",
            "等しいならば、","それら","に","対する","二つの辺",
            "も","互いに等しい。","","","","","8","99","99"},
        {"ゆえに、", "三角形","の","二つの角","が",
            "等しいならば、","それら","に","対する","二つの辺",
            "も","互いに等しい。","","","","","8","99","99"},

        {"ゆえに、", "三角形","の","二つの角","が",
            "等しいならば、","それら","に","対する","二つの辺",
            "も","互いに等しい。","","","","","9","99","99"},
        {"ゆえに、", "三角形","の","二つの角","が",
            "等しいならば、","それら","に","対する","二つの辺",
            "も","互いに等しい。","","","","","11","99","99"},

        {"これが証明すべきことであった。", "","","","","","","","","","","","","","","","99","99","99"},

        //{"", "","","","","","","","","","","","","","","","99","99","99"},
    };

    //kourinaiyou---------------------------------------------------------------
    private string[,] ka1 = new string[,]//ka1w
    {
        {"公理a1","","","","","","","","","","","","","","","","99","99","99"},
        {"同じもの","に","等しいもの","は","互いに等しい","","","","","","","","","","","","0","99","99"},
        {"同じもの","に","等しいもの","は","互いに等しい","","","","","","","","","","","","2","99","99"},
        {"同じもの","に","等しいもの","は","互いに等しい","","","","","","","","","","","","4","99","99"},
        {"同じもの","に","等しいもの","は","互いに等しい","","","","","","","","","","","","99","99","99"},
    };
    private string[,] ka3 = new string[,]//ka3w
    {
        {"公理a3","","","","","","","","","","","","","","","","99","99","99"},
        {"等しいもの","から","等しいもの","を","引いた差","は","互いに等しい","","","","","","","","","","0","99","99"},
        {"等しいもの","から","等しいもの","を","引いた差","は","互いに等しい","","","","","","","","","","2","99","99"},
        {"等しいもの","から","等しいもの","を","引いた差","は","互いに等しい","","","","","","","","","","4","99","99"},
        {"等しいもの","から","等しいもの","を","引いた差","は","互いに等しい","","","","","","","","","","6","99","99"},
        {"等しいもの","から","等しいもの","を","引いた差","は","互いに等しい","","","","","","","","","","99","99","99"},

    };
    private string[,] ka4 = new string[,]//ka4w
    {
        {"公理a4","","","","","","","","","","","","","","","","99","99","99"},
        {"互いに重なり合うもの","は","互いに等しい","","","","","","","","","","","","","","0","99","99"},
        {"互いに重なり合うもの","は","互いに等しい","","","","","","","","","","","","","","0","99","99"},
        {"互いに重なり合うもの","は","互いに等しい","","","","","","","","","","","","","","2","99","99"},
        {"互いに重なり合うもの","は","互いに等しい","","","","","","","","","","","","","","99","99","99"},
    };
    private string[,] ka5 = new string[,]//ka5w
    {
        {"公理a5","","","","","","","","","","","","","","","","99","99","99"},
        {"全体","は","部分","より","大きい","","","","","","","","","","","","0","99","99"},
        {"全体","は","部分","より","大きい","","","","","","","","","","","","2","99","99"},
        {"全体","は","部分","より","大きい","","","","","","","","","","","","4","99","99"},
        {"全体","は","部分","より","大きい","","","","","","","","","","","","99","99","99"},

    };
    //koujun------------------------------------------------------------------
    private string[,] kjp1 = new string[,]//kjp1w
    {
        {"公準p1","","","","","","","","","","","","","","","","99","99","99"},
        {"任意の点","から","任意の点","へ","直線","を","引くこと","","","","","","","","","","0","99","99"},
        {"任意の点","から","任意の点","へ","直線","を","引くこと","","","","","","","","","","2","99","99"},
        {"任意の点","から","任意の点","へ","直線","を","引くこと","","","","","","","","","","4","99","99"},
        {"任意の点","から","任意の点","へ","直線","を","引くこと","","","","","","","","","","6","99","99"},
        {"任意の点","から","任意の点","へ","直線","を","引くこと","","","","","","","","","","99","99","99"},

    };
    private string[,] kjp2 = new string[,]//kjp2w
    {
        {"公準p2","","","","","","","","","","","","","","","","99","99","99"},
        {"任意の直線","を","連続して延ばすこと","","","","","","","","","","","","","","0","99","99"},
        {"任意の直線","を","連続して延ばすこと","","","","","","","","","","","","","","2","99","99"},
        {"任意の直線","を","連続して延ばすこと","","","","","","","","","","","","","","99","99","99"},

    };
    private string[,] kjp3 = new string[,]//kjp3w
    {
        {"公準p3","","","","","","","","","","","","","","","","99","99","99"},
        {"任意の中心","と","任意の半径","の","円","を描くこと。","","","","","","","","","","","0","99","99"},
        {"任意の中心","と","任意の半径","の","円","を描くこと。","","","","","","","","","","","2","99","99"},
        {"任意の中心","と","任意の半径","の","円","を描くこと。","","","","","","","","","","","4","99","99"},
        {"任意の中心","と","任意の半径","の","円","を描くこと。","","","","","","","","","","","5","99","99"},
        {"任意の中心","と","任意の半径","の","円","を描くこと。","","","","","","","","","","","99","99","99"},

    };
    //teigimoji 2tu
    private string[,] tdi1 = new string[,]//tdi1w
    {
        {"定義di1","","","","","","","","","","","","","","","","99","99","99"},
        {"点","は","部分","をもたないものである。","","","","","","","","","","","","","0","2","99"},
        {"点","は","部分","をもたないものである。","","","","","","","","","","","","","99","99","99"},
    };
    private string[,] tdi15 = new string[,]//tdi5w
   {
        //kaizou
        //{"", "","","","",
        //    "","","","","",
        //    "","","","","",
        //    "","99","99","99"}, 
       {"定義di15","","","","","","","","","","","","","","","","99","99","99"},
        {"円","とは","周と呼ばれる一つの線","の","境界で囲まれた平面図形","であって","","","","","","","","","","","0","99","99"},
        {"円","とは","周と呼ばれる一つの線","の","境界で囲まれた平面図形","であって","","","","","","","","","","","2","99","99"},
        {"円","とは","周と呼ばれる一つの線","の","境界で囲まれた平面図形","であって","","","","","","","","","","","4","99","99"},

        {"その中にある一つの点","から","円周上の点","に","引かれた直線","の","長さ","が","すべて等しいもの","である","","","","","","","0","99","99"},
        {"その中にある一つの点","から","円周上の点","に","引かれた直線","の","長さ","が","すべて等しいもの","である","","","","","","","2","99","99"},
        {"その中にある一つの点","から","円周上の点","に","引かれた直線","の","長さ","が","すべて等しいもの","である","","","","","","","4","99","99"},
        {"その中にある一つの点","から","円周上の点","に","引かれた直線","の","長さ","が","すべて等しいもの","である","","","","","","","6","99","99"},
        {"その中にある一つの点","から","円周上の点","に","引かれた直線","の","長さ","が","すべて等しいもの","である","","","","","","","8","99","99"},
        {"その中にある一つの点","から","円周上の点","に","引かれた直線","の","長さ","が","すべて等しいもの","である","","","","","","","9","99","99"},
        {"その中にある一つの点","から","円周上の点","に","引かれた直線","の","長さ","が","すべて等しいもの","である","","","","","","","99","99","99"},


   };


    //kyochouPanel(int count) ------------------------------------------------------------------------------
    void kyochouPanel(int count1, int count2, int count3)
    {

        for (int i = 0; i < kodomoTextText.Count; i++)
        {
            mojiPanel[i].GetComponent<Image>().enabled = false;
        }

        if (count1 != 99)
        {
            //k7_1_2:オブジェを見えるようにするよ。
            //共通変数の kyotuEla.tenmetuOnOffで点滅処理
            mojiPanel[count1].GetComponent<Image>().enabled = kyotuEla.tenmetuOnOff;///
        }
        if (count2 != 99)
        {
            //k7_1_2:オブジェを見えるようにするよ。
            //共通変数の kyotuEla.tenmetuOnOffで点滅処理
            mojiPanel[count2].GetComponent<Image>().enabled = kyotuEla.tenmetuOnOff;///
        }
        if (count3 != 99)
        {
            //k7_1_2:オブジェを見えるようにするよ。
            //共通変数の kyotuEla.tenmetuOnOffで点滅処理
            mojiPanel[count3].GetComponent<Image>().enabled = kyotuEla.tenmetuOnOff;///
        }

    }
    //Uitextの中身----------------------------------------------------------------------------------------------------
    //3次元配列

}

