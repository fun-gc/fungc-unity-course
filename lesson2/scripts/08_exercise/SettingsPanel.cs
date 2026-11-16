using UnityEngine;
using UnityEngine.UI;
using TMPro;

// 演習: 設定画面を完成させよう
// ゴール: 音量・効果音・難易度・名前が動き、リセットで元に戻る設定画面
// 準備: 新しいパネルに Slider・Text (TMP)・Toggle・Dropdown・Input Field (TMP)・Button 2つ(決定・リセット)を置く。
//       空のオブジェクトにこのスクリプトを付けて、欄を4つつなぐ。
//       Slider は Min Value 0、Max Value 1、Value 1。Dropdown の Options に「かんたん/ふつう/むずかしい」を足す。
//       各部品の On Click や On Value Changed に、下の関数を登録する(値を受け取る関数は Dynamic の欄から)。
// TODO 1 と TODO 2 を自分で書こう(答えは講座の最後に見る)
public class SettingsPanel : MonoBehaviour
{
    public Slider volumeSlider;
    public TMP_Text volumeText;
    public TMP_InputField nameInput;
    public TMP_Text warningText;
    public int difficulty;

    // Slider の On Value Changed に「Dynamic float」で登録する
    public void OnVolumeChanged(float v)
    {
        // TODO 1: volumeText に「42%」のように、音量を % で出そう
        //   ヒント1: v は 0〜1。100 をかけると 0〜100 になる
        //   ヒント2: Mathf.RoundToInt(〜) で小数を整数にできる。文字とは + でつなげる
        //   ヒント3: スライド「完成した設定画面を動かしてみよう」を見ながら書いてよい

    }

    // Toggle の On Value Changed に「Dynamic bool」で登録する
    public void OnSeToggled(bool isOn)
    {
        volumeSlider.interactable = isOn;
    }

    // Dropdown の On Value Changed に「Dynamic int」で登録する
    public void OnDifficultyChanged(int index)
    {
        // 0:かんたん 1:ふつう 2:むずかしい
        difficulty = index;
    }

    // 決定ボタンの On Click に登録する
    public void OnDecideClicked()
    {
        // TODO 2: 名前の入力欄が空なら、warningText に「名前を入力してね」と出そう
        //   ヒント1: 入力欄の文字は nameInput.text で読める
        //   ヒント2: 空かどうかは if (〜 == "") で調べる
        //   ヒント3: スライド「入力された文字を受け取ろう」を見ながら書いてよい

    }

    // リセットボタンの On Click に登録する
    public void OnResetClicked()
    {
        // value を書き換えると、OnVolumeChanged も呼ばれて数字が戻る
        volumeSlider.value = 1f;
        nameInput.text = "";
    }

    // ★早く終わった人へ
    //   ・PlayerPrefs で音量を保存して、起動時に戻そう
    //     (ヒント: 保存は PlayerPrefs.SetFloat("volume", v)、読み出しは Start で PlayerPrefs.GetFloat("volume", 1f))
    //   ・名前が空のとき、警告文を赤くしよう(ヒント: warningText.color = Color.red;)
}
