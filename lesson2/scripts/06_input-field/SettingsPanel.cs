using UnityEngine;
using UnityEngine.UI;
using TMPro;

// 05 に、名前の入力欄から呼ぶ関数を足した版。
// nameInput に Input Field (TMP)、warningText に警告用の Text (TMP) をドラッグする。
// Input Field の On End Edit (String) で「Dynamic string」の OnNameEndEdit を選ぶ。
public class SettingsPanel : MonoBehaviour
{
    public TMP_Text messageText;
    public Slider volumeSlider;
    public int difficulty;
    public TMP_InputField nameInput;
    public TMP_Text warningText;

    public void OnResetClicked()
    {
        messageText.text = "リセットしました";
    }

    public void OnVolumeChanged(float v)
    {
        Debug.Log("音量: " + v);
    }

    public void OnSeToggled(bool isOn)
    {
        volumeSlider.interactable = isOn;
    }

    public void OnDifficultyChanged(int index)
    {
        // 0:かんたん 1:ふつう 2:むずかしい
        difficulty = index;
    }

    // Enter を押すか、別の場所をクリックして確定したときに呼ばれる
    public void OnNameEndEdit(string text)
    {
        if (text == "")
            warningText.text = "名前を入力してね";
        else
            warningText.text = "";
    }
}
