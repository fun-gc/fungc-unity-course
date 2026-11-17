using TMPro;
using UnityEngine;

// 1行分の表示を受け持つ部品。行の Prefab(ShopRow)に付ける。
// nameText に NameText、priceText に PriceText をドラッグする(Prefab を開いて行う)。
public class ShopRow : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text priceText;

    // この行のアイテムと、ShopManager を覚えておく
    Item item;
    ShopManager shop;

    // ShopManager から呼ばれて、データを受け取る
    public void Setup(Item data, ShopManager manager)
    {
        item = data;
        shop = manager;
        nameText.text = data.name;
        priceText.text = data.price + "G";
    }
}
