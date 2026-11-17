using UnityEngine;

// 05 に、CanvasGroup でショップパネルをまとめて薄く・押せなくする関数を足した版。
// ショップパネルに Add Component で Canvas Group を付け、shopGroup にドラッグする。
public class MenuManager : MonoBehaviour
{
    public GameObject statusPanel;
    public GameObject settingsPanel;
    public GameObject shopPanel;
    public CanvasGroup shopGroup;

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

    // on が false なら、ショップの中の部品をまとめて薄く・押せなくする
    // (試すときは、Toggle の On Value Changed に Dynamic bool で登録する)
    public void SetShopEnabled(bool on)
    {
        shopGroup.interactable = on;     // 中のボタンなどを押せるか
        shopGroup.blocksRaycasts = on;   // クリックを受け止めるか
        if (on) shopGroup.alpha = 1f;    // 0(透明)〜1(不透明)
        else    shopGroup.alpha = 0.4f;
    }
}
