using TMPro;
using UnityEngine;
using UnityEngine.UI;

// 演習のひな型(ShopManager.cs と組み合わせて使う)。行の Prefab に付ける。
// 準備: Prefab を開き、buyButton に BuyButton をドラッグする。On Click の OnBuyClicked は 03 と同じ。
public class ShopRow : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text priceText;
    public Button buyButton;

    Item item;
    ShopManager shop;

    public void Setup(Item data, ShopManager manager)
    {
        item = data;
        shop = manager;
        nameText.text = data.name;
        priceText.text = data.price + "G";
    }

    public void OnBuyClicked()
    {
        shop.Buy(item);
    }

    // ShopManager から、今の所持金を教えてもらう
    public void Refresh(int money)
    {
        // TODO 2: 所持金が足りないときは、購入ボタンを押せなくしよう
        //   ヒント1: buyButton.interactable に true か false を入れる
        //   ヒント2: 足りるかどうかは money >= item.price で分かる(これ自体が true か false)
        //   ヒント3: 第2回の演習で、トグルがオフのとき volumeSlider.interactable を false にしたのと同じ

    }
}
