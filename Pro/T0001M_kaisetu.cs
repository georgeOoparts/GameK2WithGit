using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T0001M_kaisetu : MonoBehaviour
{
    /*
    命名規則
    k0001_99_1_hoge>k0001_99_2_hoge
    前の記述を前提にしている物
    k0001_1_99_1>k0002_1_99_1_2

    //説明　今回の定理名　公理名
    ////引用元
    /
     *unityで作ったgameを携帯に移す手順
     * 
     *20200408時点で使っているunityのversion　2019.2.14f1
     *
     * 
     * 
     * 
     * 
    /
    //-----------------------------------------------------------
    //AC_a1:アンドロイド端末でステータスバーとナビゲーションバーを常に表示 
    //オブジェにApplicationChrome.csをアタッチ。
    //同じオブジェにスクリプトをアタッチ。
    //スクリプトのスタートに下の文字列を書く。
    ApplicationChrome.statusBarState=ApplicationChrome.State.Visible;

    //AC_a2:ステータスバーだけを表示
    ApplicationChrome.statusBarState=ApplicationChrome.State.Visible;
    ApplicationChrome.navigationBarState=ApplicationChrome.State.Hidden;

    //AC_a3:ナビゲーションバーだけを表示
    ApplicationChrome.navigationBarState=ApplicationChrome.State.Visible;

    //AC_b1:ステータスバー、ナビゲーションバーの状態を変える
    //通常　ApplicationChrome.statusBarState=ApplicationChrome.State.Visible;
    //画面に映る物の上にかぶせる
    ApplicationChrome.statusBarState=
                ApplicationChrome.State.VisiblOverContent;
    //透明になりながら画面に映るもののうえにかぶさる
    ApplicationChrome.statusBarState=
                ApplicationChrome.State.TranslucentOverContent;
    //隠す
    ApplicationChrome.statusBarState=ApplicationChrome.State.Hidden;
    ------------------------------------------------------------------------------

    //g1 最新のコミットメッセージを変更
    //g1 ６下ファイルステータス＞８オブションのコミット＞最後のコミットを上書き
    //g2 無駄に進んだ（枝別れでも良し）したブランチを戻す
    //g2 無駄に進んだブランチを選択＞無駄に進んだブランチを右クリっク
    　＞このコミットを打ち消す＞枝分かれの根元を右クリック
     ＞このコミットまでリセット＞hard
    ------------------------------------------------------------------------------
    
    //u1 呼び込まれるプログラムの順番　１上側＞edit>projectseting>scriptexecutionOrder  
    //u1>数字が低いほうから読み込まれる。
    
    //u2 uguiでcameraの位置と関係なく、UIを置く
    //u2まずcanvas＞screenspace＞maincameraにして　mainncameraを選択
    //u2＞カメラをuiを置きたい場所まで持っていく。＞その上でcanvas＞screenspace＞worldspace
    //u2にする。これで、カメラの位置に関係なくCANVASを固定できる＞この子供にUIを設置

    //u3 シーンを丸まるコピー＞edit＞copy＞duplicate
    
    ------------------------------------------------------------------------------

    //k1　デバックログの使い方
    
    //k1_1 デバッグログ表示
    Debug.Log("デバックログはこうやるぜee");
    
    //k1_2 デバッグログ　変数　表示----ー----------------
    ////?
    int hensu = 9999;
    Debug.Log(hensu);
    
    //k1_3 デバッグログ　変数＋　表示----ー----------------
    ////?
    int hensu = 9999;
    Debug.Log("wowow"+hensu);

    ----------------------------------------------------------
    k2::Text回り

    //k2_1:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text text;
    -----------------
    //k2_1_1:Textをこのオブジェクトで使うためのおまじない
    text = this.gameObject.GetComponent<Text>();
    -----------------
    //k2_1_1_1:text.text = "・・・ "でTEXTのないよう変更。
    text.text = "k2_1_TextContentChange";
    ------------------
    //k2_1_1_2:スクリーン座標のテキスト幅   
    text.preferredWidth
    
    //k2_1_1_3:スクリーン座標のテキスト高さ 
    text.preferredHeight
    ---------------------------------------------------------------------------------------
    mouseposition回り
   
    //k0003_1:Input.mousePositionでマウスのスクリーンポイントを
    //V3形式で代入
    ////?
    Vector3 position=Input.mousePosition;

    //k0003_2:Input.mousePosition.ToString()でマウスのスクリーンポイントを
    //string形式で代入
    ////?
    string position=Input.mousePosition.ToString();
    
    >>具体例：：Debug.Log(Input.mousePosition.ToString());
    ---------------------------------------------------------------------------------------
    //k0003_3:一瞬左クリックダウン入力されたか出力０１
    Input.GetMouseButtonDown(0)
    
    >>具体例：：if (Input.GetMouseButtonDown(0)){・・・}

    //k0003_4:一瞬左クリックアップ入力されたか出力０１
    Input.GetMouseButtonUp(0)
    
    >>具体例：：if (Input.GetMouseButtonDown(0)){・・・}

    //k0003_5:左クリック押されてる間入力されたか出力０１
    Input.GetMouseButtonDown(0)
    
    >>具体例：：if (Input.GetMouseButton(0)){スライドするとか・・・}
    ---------------------------------------------------------------------------------------
    ////k0003_1:Input.mousePositionでマウスのスクリーンポイントを
    ////V3形式で代入
    ////?
    Vector3 position=Input.mousePosition;
    
    //k0003_6:スクリーン座標＞ワールド座標
    position = Camera.main.ScreenToWorldPoint(position);
    
    >>具体例：：ワールドに変換されたposition.zはＵＩに貼り付けたカメラの位置となる。
    >>具体例：：Debug.Log(position);
    
//-------------------------------------------------------------

    //k4_1:どこかに書いてあるRectTransformの変数を作る
    RectTransform rt;

    //k4_1_1:このオブジェクトにＵＩ専門であるRectTransformをアタッチ
    rt = this.gameObject.GetComponent<RectTransform>();

    //k4_1_1_1:uiオブジェクトのスクリーン座標幅を得る
    rt.sizeDelta.x
    //k4_1_1_2:uiオブジェクトのスクリーン座標高さを得る
    rt.sizeDelta.y

    //k4_1_1_3:uiの幅、高さをスクリーン値で変形させる
    rt.sizeDelta = new Vector2(100,100);

    //k4_1_1_4:uiをスクリーン値で移動（左上にアンカーセット、下方向は-の値)
    rt.anchoredPosition = new Vector2(190, -145);
    //k4_1_1_5:uiをワールド値で移動
    rt.position = new Vector2(0,0);
//----------------------------------------------------------------------------
    //k5 メソッド　変数　外部から呼び出す。//kyoutu 共通
    
    //k5_1_atStatic:静的変数を外のクラスから（クラス名）.(変数名)で呼び出す。
    public static int c = 200;

    //k5_1_1:atStatic:静的変数を外のクラスから（クラス名）.(変数名)で呼び出す。
    クラス名.c = 200;
    
    //k5_2_atStatic:静的メソッドを外のクラスから（クラス名）.(メソッド名)で呼び出す。
    public static int plus(int A, int B) {
        return (A * B);
    }

    //k5_3_1: gameobject(メソッド、変数)を外部から呼び出す。
    //ヒエでアタッチ
    yomareruScript{
        public Gameobject cube1;//ヒエでセットする
    }
    yobidasiScript{
        //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
        //このスクリプトをアタッチしたオブジェクトにいちいちこのオブジェクトをアタッチ
        public yomareruScript yos;
        //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす
    　　yosu.cube1で普通に使える
    }
//-------------------------------------------------------------------------------------
    //k6_stopwatch:
    
    //k6_1:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();
    
    //k6_1_1:何秒たったかを変数elapseに入れる：update内に入れる-------
    ////?
    private float elapse;
    
    elapse = (float)stopwatch.Elapsed.TotalSeconds;
    -------------------------------------------------

    //k6_1_1_1:ストップウォッチスタート
    stopwatch.Start();
    
    //k6_1_1_2:ストップウォッチの時間をリセット
    stopwatch.Reset();
    
    具体例＞＞Debug.Log(elapse);//何秒たったかを表示させたいときはこれを使う
----------------------------------------------------------------------------------
    //k7オブジェクトを見えたり見えなくしたりする(オブジェがUIの時)---

    //k7_1:Imageコンポーネントを使う
    using UnityEngine.UI;

    //k7_1_1:オブジェを存在するけど見えなくする。
    this.gameObject.GetComponent<Image>().enabled = false;

    //k7_1_2:オブジェを見えるようにするよ。
    this.gameObject.GetComponent<Image>().enabled = true;

    //k7Bオブジェクトを見えたり見えなくしたりする(uiじゃないオブジェの時)---
    //スプライトの場合もspriterendererじゃなくこれ。
    //しかし、スプライトの場合Rederer変数が作れないので注意

    //k7B_1_1:オブジェを存在するけど見えなくする。
    //this.gameObject.GetComponent<Renderer>().enabled = false; 

    //k7B_1_2:オブジェを見えるようにするよ。
    //this.gameObject.GetComponent<Renderer>().enabled = true;



----------------------------------------------------------------------------------
    //shape2dの使い方
    shape2d使い方（スプライトで円周の一部を作れる）

    hierarchy右クリック＞shapes2d>sprites>ellipse
    で円を作れる

    作った円のinspecter＞shape＞innerCutout x=0.9,y=0.9
    位で円周を表せる

    円周のinspecter＞shape＞startAngle、endAngleを調整する事で
    円周の一部のみを表示できる

----------------------------------------------------------------------------------
    k8：：親、子供　オブジェ呼び出し

    //k8_1:子(孫、ひ孫　無限にＯＫ)になっているＯＢＪを得る。
    //自分の直下の子供を得る。(数字は子供オブジェのヒエラルキー：一番上0)
    kodomoObj1 = this.gameObject.transform.GetChild(0).gameObject;
    
    具体例：：応用。自分の直下の子供（ヒエラルキー並び一番上)になっているＯＢＪを得る。
    kodomoObj2 = this.gameObject.transform.GetChild(1).gameObject;

    //k8_2:応用。親になっているＯＢＪを得る。
    oyaPanel = this.gameObject.transform.parent.gameObject;

    //k8_3:応用。孫になっているＯＢＪを得る。 (数字は子供,孫オブジェのヒエラルキー：一番上0)
    magoPanel = this.gameObject.transform.GetChild(0).GetChild(0).gameObject;

    //k8_4:応用。子、孫になっているＯＢＪを全て得る。
    //foreach (Transform unko in this.gameObject.transform) 
    //{
    //    Debug.Log(unko.gameObject.name); // 子オブジェクト名を出力
    //    foreach (Transform kuso in unko) 
    //    {
    //        Debug.Log(kuso.gameObject.name); // 孫オブジェクト名を出力
    //    }
    //}
------------------------------------------------------------------------------
    //k10 float>int変換 
    ////?
    float fKazu=10.0f;
    
    //k10_1:float>int に小数点以下切り上げで変換。
    int kazu=(int)fKazu
    
    //k10_2:strin>int変換
    //string kazumoji="999";
    //int intHenkan=int.Parse(kauMoji);

     ---------------------------------------------------------------------
    k0011:textのぼやけを直す
    k0011:ヒエラルキー＞transform>scale x,yを小さくして(0.01暗い)＞textMesh＞fontsizeサイズ調整（500位）*charactorSizeじゃない事に注意
    ----------------------------------------------------------------------
    k0012:3dtextをuitextの後ろに表示しようとする。
    k0012:uitextをカメラに固定カメラのｚポジション０
    ＞3dtextのｚポジション９０にするとなぜかuitextの後ろに3dtext表示される
    ----------------------------------------------------------------------
    //k0013:３ｄオブジェtransfome回り
    
    //k0013_1: 宣言 
    Transform page;
    
    //k0013_1_1;オブジェに当てはめる；
    page = this.gameObject.GetComponent<Transform>();
    
    //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
    page.position = new Vector3((float)-2.8, -5, page.position.z);

    //k0013_1_1_2 オブジェのx,y,z幅　取得　；変化させる；
    page.localScale = new Vector3((float)-2.8, -5, page.position.z);

    ----------------------------------------------------------------------
    //k0014_1 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject page;
    
    //k0014_1_1 :プレハブを使う
    Instantiate(page);
    
    //k0014_1_2 :プレハブを使う 角度　位置を設定
    

    //配置する回転角を設定
    ////？
    Quaternion q = new Quaternion();
    q = Quaternion.identity;
    
    //位置を決定
    ////？
    Vector3 placePosition= new Vector3((float)-2.8, 5 - 10 * (i - 1), 0);
    
    GameObject obj =Instantiate(page, placePosition, q);

    //k0014_1_2_1 :プレハブを使う 位置、角度、さらに内容変更
    ////?
    obj.GetComponent<TextMesh>().text ="wowwow";
    ----------------------------------------------------------------------
    //uitext のプレハブ //canvasはプレハブ化せずにおく、publicにはしておく
    //k0014_2 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject page;

    //k0014_2_1 :プレハブを使う
    GameObject ptp = Instantiate(preTextPanel) as GameObject;
    
    //k0014_2_1_1 :プレハブをキャンバスの子供にする()
    ptp.transform.SetParent(canvas.transform, false);

    //k0014_2_1_1: オブジェの名前を変化させる
    ptp.name = "ptp0";

    ----------------------------------------------------------------------
 
    //k0015_99_1 :線を引くline回り　オブジェにラインをくっつける
     LineRenderer renderer = gameObject.GetComponent<LineRenderer>();
    
    //k0015_99_1_1 :線の幅
    renderer.startWidth = 0.05f;
    renderer.endWidth = 0.05f;
    
    //k0015_99_1_2 :頂点の数（この場合２つ）
    renderer.positionCount = 2;
    
    //k0015_99_1_3 :頂点を設定（どこからどこまで線を伸ばすか）
    renderer.SetPosition(0, Vector3.zero);
    renderer.SetPosition(1, new Vector3(1f, 1f, 0f));
    ----------------------------------------------------------------------
    //k0016_99_1 :listを使う
    //using System.Collections.Generic;が入ってなきゃ駄目

    //k0016_99_1_1：listの宣言
    //private List<Transform> trMeidai1 = new List<Transform>();
     
    //k0016_99_1_1_1：list新しい値を入れる
    //trMeidai1.Add(kyotu.meidai1_1.GetComponent<Transform>());
     
    //k0016_99_1_1_2：Listの要素を使用、変数に代入、配列と同じように使用出来る
    //trMeidai1[0].position =
    //            new Vector3(trMeidai1[0].position.x, mokujiP, trMeidai1[0].position.z);
    
    ///k0016_99_1_1_3　：Listの0番目の要素を消す
    //myList.RemoveAt(0); 

    ///k0016_99_1_1_4　：Listすべての要素を削除
    //myList.Clear();
    
     ///k0016_99_1_1_5　：Listの要素数を得る
    //myList.Count;

    ///k0016_99_1_1_6　：List 直接値をいれて定義する。
    //private List<float> meidaiSita = new List<float> { 8.05f, 15.2f,8.9f,4.9f,12.3f,10.0f };

    //k0016_99_2 :2次元listを使う---------------------------------------------------------
    //using System.Collections.Generic;が入ってなきゃ駄目

    //k0016_99_2_1：2次元listの宣言
    //private List<List<int>> kariList = new List<List<int>>();

    //k0016_99_2_1_1：2次元list [0][0],[0][1]をつくる
    //kariList.Add(new List<int>());
    //kariList.Add(new List<int>());

    //k0016_99_2_1_1_1：Listの要素を使用、変数に代入、配列と同じように使用出来る
    //debug.log(kariList[0][0]);

    //k0016_99_1 :4次元listを使う--------------------------------------
    //using System.Collections.Generic;が入ってなきゃ駄目

    //k0016_99_2_1：4次元listの宣言
    //List<List<List<List<string>>>> kariList = new List<List<List<List<string>>>>();
    
    //k0016_99_2_1_1：4次元listに3次元listを当てはめる [0][0],[0][1]をつくる
    //kariList[0][][][]を作る
    //kariList.Add(new List<List<List<string>>>());
    //kariList[1][][][]を作る
    //kariList.Add(new List<List<List<string>>>());

    //k0016_99_2_1_1_1：3次元listに2次元listを当てはめる [0][0][0],[0][0][1]をつくる
    //kariList[0][0][][]を作る
    //kariList[0].Add(new List<List<string>>());
    //kariList[0][1][][]を作る
    //kariList[0].Add(new List<List<string>>());

    //k0016_99_2_1_1_1_1：2次元listに1次元listを当てはめる [0][0][0],[0][0][1]をつくる
    //kariList[0][0][0][]を作る
    //kariList[0][0].Add(new List<string>());
    //kariList[0][0][1][]を作る
    //kariList[0][0].Add(new List<string>());

    //k0016_99_2_1_1_1_1_1：2次元listに1次元listを当てはめる [0][0][0][0],[0][0][0][1]をつくる
    //kariList[0][0][0][0]を作る
    //kariList[0][0][0].Add("w0000");
    //kariList[0][0][0][1]を作る
    //kariList[0][0][0].Add("w0001");


    
    //k0016_99_2_1_1_1：Listの要素を使用、変数に代入、配列と同じように使用出来る
    //debug.log(kariList[0][0]);


    ーーーーーーーーーーー－－－－－－－－－－－－－－－－－－
    //k0017_99_1：配列使い方
    //Transform[] trMeidai1=new Transform[6];

    //k0017_99_1_1:配列　要素の数を得る。
    //trMeidai1.Length

    //k0017_99_2:2次元配列　宣言
    //string[,] intValues=new string[6,8];
    
    //k0017_99_2_1:2次元配列　最初の要素の個数を得る
     intValues.GetLength(0)
     */
    /*
    



            */
    //k0018_99_1:マテリアルの変更
    //public GameObject obj;//オブジェをセット
    //k0018_99_1_1://マテリアルをセット//public Material ColorPink;
    //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
    //k0018_99_1_1_2://色を数値で指定する//obj.GetComponent<Renderer>().material.color = new Color32(248, 168, 133, 1);

    //0019_99_1：shape2dで色をスクリプトから変更する
    //using Shapes2D;
    //var shape = GetComponent<Shape>();
    //shape.settings.fillColor = Color.white;
    //shape.settings.fillColor = new Color32(109,200,45,255);

    //0020_99_1:マテリアルのエミッションの色を得る//Material.GetColor("_EmissionColor")
    //Material.GetColor("_EmissionColor")

    //マテリアルの通常の色をえる
    //Material.GetColor("_EmissionColor")
    //Material.Color

    //0019_99_1：shape2dで色をスクリプトから変更する
    // 0020_99_1:マテリアルのエミッションの色を得る
    //M1_5KakuABC.GetComponent<Shape>().settings.fillColor = MColor6Pink_same2.GetColor("_EmissionColor");

    //0021_99_1:uiボタンを使う

    //uiボタンを押したときの操作publicメソッドを作る（update、starat以外)
    //＞uiにアタッチ>
    //ui＞インスペ＞button（script）＞onclick　＋＞ボタンを押したときの処理を描いたスクリプトがアタッチされたオブジェを選択
    //＞→選んだオブジェのアタッチプログラムのメソッドを選択
}
