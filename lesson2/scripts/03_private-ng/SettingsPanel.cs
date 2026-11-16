using UnityEngine;
using TMPro;

// わざと失敗する版: OnResetClicked に public を付けていない。
// エラーは出ないが、Button の On Click の関数の一覧に OnResetClicked が出てこない
// (登録済みだった人は、欄が Missing の表示になる)。
// 直し方: 02_reset-message の SettingsPanel.cs に置き換える(先にこのファイルを削除する)。
// 見るスライド: 「よくあるつまずき：関数が一覧に出ない」
public class SettingsPanel : MonoBehaviour
{
    public TMP_Text messageText;

    void OnResetClicked()
    {
        messageText.text = "リセットしました";
    }
}
