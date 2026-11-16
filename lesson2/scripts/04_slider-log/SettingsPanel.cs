using UnityEngine;
using TMPro;

// 02 に、スライダーから呼ぶ関数を足した版。
// Slider の On Value Changed (Single) の「＋」から、一覧の上のほう
// 「Dynamic float」の OnVolumeChanged を選ぶ(Static Parameters の欄は選ばない)。
public class SettingsPanel : MonoBehaviour
{
    public TMP_Text messageText;

    public void OnResetClicked()
    {
        messageText.text = "リセットしました";
    }

    // つまみを動かすたびに呼ばれる。v には今の値(0〜1)が入る
    public void OnVolumeChanged(float v)
    {
        Debug.Log("音量: " + v);
    }
}
