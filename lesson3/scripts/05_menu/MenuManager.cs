using UnityEngine;

// 3つのパネル(ステータス・設定・ショップ)を切り替える部品。Canvas に付ける。
// 3つのパネルを欄にドラッグし、タブボタン3つの On Click に ShowStatus・ShowSettings・ShowShop を登録する。
public class MenuManager : MonoBehaviour
{
    public GameObject statusPanel;
    public GameObject settingsPanel;
    public GameObject shopPanel;

    // true で表示、false で非表示。1つだけ表示する
    public void ShowStatus()
    {
        statusPanel.SetActive(true);
        settingsPanel.SetActive(false);
        shopPanel.SetActive(false);
    }

    public void ShowSettings()
    {
        statusPanel.SetActive(false);
        settingsPanel.SetActive(true);
        shopPanel.SetActive(false);
    }

    public void ShowShop()
    {
        statusPanel.SetActive(false);
        settingsPanel.SetActive(false);
        shopPanel.SetActive(true);
    }
}
