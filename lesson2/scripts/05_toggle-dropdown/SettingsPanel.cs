using UnityEngine;
using UnityEngine.UI;
using TMPro;

// 04 に、トグルとドロップダウンから呼ぶ関数を足した版。
// volumeSlider に Slider をドラッグする。
// Toggle は「Dynamic bool」の OnSeToggled、Dropdown は「Dynamic int」の OnDifficultyChanged を選ぶ。
public class SettingsPanel : MonoBehaviour
{
    public TMP_Text messageText;
    // Slider には using UnityEngine.UI; が必要
    public Slider volumeSlider;
    public int difficulty;

    public void OnResetClicked()
    {
        messageText.text = "リセットしました";
    }

    public void OnVolumeChanged(float v)
    {
        Debug.Log("音量: " + v);
    }

    // オンなら true、オフなら false が届く
    public void OnSeToggled(bool isOn)
    {
        // false にすると灰色になり、操作できなくなる
        volumeSlider.interactable = isOn;
    }

    // 選んだ項目の番号(0から数える)が届く
    public void OnDifficultyChanged(int index)
    {
        // 0:かんたん 1:ふつう 2:むずかしい
        difficulty = index;
    }
}
