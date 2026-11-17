using TMPro;
using UnityEngine;

// 02 に、購入ボタンから呼ぶ関数を足した版。
// Prefab を開き、BuyButton の On Click に ShopRow の OnBuyClicked を登録する(シーン上の行ではなく Prefab 側で)。
public class ShopRow : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text priceText;

    Item item;
    ShopManager shop;

    public void Setup(Item data, ShopManager manager)
    {
        item = data;
        shop = manager;
        nameText.text = data.name;
        priceText.text = data.price + "G";
    }

    // 購入ボタンの On Click に登録する。どのアイテムかは、この行が覚えている
    public void OnBuyClicked()
    {
        shop.Buy(item);   // 自分のアイテムを渡す
    }
}
