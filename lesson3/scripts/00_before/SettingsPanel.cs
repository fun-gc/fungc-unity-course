using UnityEngine;
using UnityEngine.UI;
using TMPro;

// 06 に、コードからボタンへ登録する書き方を足した版。
// startButton に新しく置いた Button をドラッグする。この Button の On Click は空のままでよい。
public class SettingsPanel : MonoBehaviour
{
    public TMP_Text messageText;
    public Slider volumeSlider;
    public int difficulty;
    public TMP_InputField nameInput;
    public TMP_Text warningText;
    public Button startButton;

    // オブジェクトが有効になるたびに呼ばれる。ここで登録する
    void OnEnable()
    {
        // 関数名だけ書く(( ) は付けない)
        startButton.onClick.AddListener(OnStartClicked);
    }

    // オブジェクトが無効になるときに呼ばれる。ここで登録を外す
    void OnDisable()
    {
        startButton.onClick.RemoveListener(OnStartClicked);
    }

    // コードから登録するので、public でなくてもよい
    void OnStartClicked()
    {
        Debug.Log("スタート！");
    }

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

    public void OnNameEndEdit(string text)
    {
        if (text == "")
            warningText.text = "名前を入力してね";
        else
            warningText.text = "";
    }
}
