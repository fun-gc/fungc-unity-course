using UnityEngine;

// わざと失敗する版: using TMPro; を書いていない。
// Unity に戻ると Console に赤い文字 error CS0246
// (The type or namespace name 'TMP_Text' could not be found)が出て、再生できない。
// 直し方: 01_status-view の StatusView.cs に置き換える(先にこのファイルを削除する)。
// 見るスライド: 「よくあるつまずき：TMP_Text が見つからない」
public class StatusView : MonoBehaviour
{
    public TMP_Text nameText;

    void Start()
    {
        nameText.text = "ゆうしゃ";
    }
}
