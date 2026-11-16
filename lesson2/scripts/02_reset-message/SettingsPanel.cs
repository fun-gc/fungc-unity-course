using UnityEngine;
using TMPro;

// 設定画面のボタンから呼ぶ関数をまとめる部品。
// 空のオブジェクトに付ける。messageText に Text (TMP) をドラッグする。
public class SettingsPanel : MonoBehaviour
{
    public TMP_Text messageText;

    // onClick に登録する関数
    public void OnResetClicked()
    {
        messageText.text = "リセットしました";
    }
}
