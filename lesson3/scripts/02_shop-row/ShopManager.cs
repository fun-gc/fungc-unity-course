using System.Collections.Generic;
using UnityEngine;

// 01 に、一覧から行を作る処理を足した版。
// rowPrefab に ShopRow の Prefab、content に ScrollView の Content をドラッグする。
public class ShopManager : MonoBehaviour
{
    public ShopRow rowPrefab;   // 行の Prefab
    public Transform content;   // 行を入れる場所
    public List<Item> items;

    void Start()
    {
        // items の中身を1個ずつ取り出して、行を1つずつ作る
        foreach (Item item in items)
        {
            // 第2引数に content を渡すと、Content の中に行が増える
            ShopRow row = Instantiate(rowPrefab, content);
            // 生成した行に、アイテムと自分(ShopManager)を渡す
            row.Setup(item, this);
        }
    }
}
