using UnityEngine;
using UnityEngine.UI;
using TMPro;

// 演習: ステータス画面を完成させよう
// ゴール: 名前・レベル・HPバーが出て、HP 70 / 100 がバーの7割になる
// 準備: Canvas に付けて、nameText・levelText に Text (TMP)、hpFill にHPバーの Image をドラッグする。
//       (Image Type = Filled、Fill Method = Horizontal、Fill Origin = Left にしておく)
// TODO 1 と TODO 2 を自分で書こう(答えは講座の最後に見る)
public class StatusView : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text levelText;
    public Image hpFill;

    // インスペクターから変えて、バーの長さを試せる
    public int level = 5;
    public int hp = 70;
    public int maxHp = 100;

    void Start()
    {
        nameText.text = "ゆうしゃ";

        // TODO 1: levelText に「Lv. 5」と出そう(level の数を使う)
        //   ヒント1: 文字と数は + でつなげる
        //   ヒント2: 書き換えるのは levelText.text


        // TODO 2: HPバーに、hp / maxHp の割合を出そう
        //   ヒント1: バーの長さは hpFill.fillAmount(0〜1)
        //   ヒント2: int 同士で割ると 0 になる。片方に (float) を付ける
        //   ヒント3: スライド「コードから文字とバーを書き換えよう」を見ながら書いてよい

    }

    // ★早く終わった人へ
    //   ・HP が 3割以下のとき、バーの色を赤にしよう
    //     (ヒント: if で hpFill.fillAmount が 0.3f 以下かを調べ、hpFill.color = Color.red; を書く)
    //   ・背景のウィンドウ枠を、Sliced の Image で作ろう(コードは不要)
}
