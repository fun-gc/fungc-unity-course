using System.Collections.Generic;
using UnityEngine;

// わざと Instantiate の第2引数(置き場所)を書かない版。
// エラーは出ないが、行が ScrollView の中に出てこない。Hierarchy を見ると、行がいちばん外(Canvas の外)にできている。
// 03 の ShopManager.cs に戻すと直る。
public class ShopManager : MonoBehaviour
{
    public ShopRow rowPrefab;   // 行の Prefab
    public Transform content;   // 行を入れる場所(この版では使っていない)
    public List<Item> items;
    public int money = 300;

    void Start()
    {
        foreach (Item item in items)
        {
            // 置き場所を指定していない
            ShopRow row = Instantiate(rowPrefab);
            row.Setup(item, this);
        }
    }

    public void Buy(Item item)
    {
        if (money < item.price) return;
        money -= item.price;
        Debug.Log(item.name + " を買った！");
    }
}
