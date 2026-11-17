using System.Collections.Generic;
using UnityEngine;

// 02 に、所持金と購入の処理を足した版。
// この段階では、所持金の表示は変わらない(Console に出るだけ)。表示の更新は演習で書く。
public class ShopManager : MonoBehaviour
{
    public ShopRow rowPrefab;   // 行の Prefab
    public Transform content;   // 行を入れる場所
    public List<Item> items;
    public int money = 300;

    void Start()
    {
        foreach (Item item in items)
        {
            ShopRow row = Instantiate(rowPrefab, content);
            row.Setup(item, this);
        }
    }

    // 行の購入ボタンから呼ばれる
    public void Buy(Item item)
    {
        // 所持金が足りないときは、何もしないで終わる
        if (money < item.price) return;
        money -= item.price;
        Debug.Log(item.name + " を買った！");
    }
}
