using UnityEngine;

// 設定画面のボタンから呼ぶ関数をまとめる部品。
// 空のオブジェクト(名前は SettingsPanel など)に付ける。
// Button の On Click の「＋」から、このオブジェクトをドラッグして OnResetClicked を選ぶ。
public class SettingsPanel : MonoBehaviour
{
    // ボタンから呼ぶ関数
    public void OnResetClicked()
    {
        Debug.Log("リセットが押された！");
    }
}
