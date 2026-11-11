using UnityEngine;
using UnityEngine.UI;
using TMPro;

// ステータス画面の文字とHPバーを、コードから書き換える部品。
// Canvas に付ける。nameText に Text (TMP)、hpFill に HPバーの Image をドラッグする。
public class StatusView : MonoBehaviour
{
    public TMP_Text nameText;
    public Image hpFill;

    void Start()
    {
        // 名前の文字を書き換える
        nameText.text = "ゆうしゃ";
        // バーの長さを 0〜1 で決める(0.7 = 7割)
        hpFill.fillAmount = 0.7f;
    }
}
