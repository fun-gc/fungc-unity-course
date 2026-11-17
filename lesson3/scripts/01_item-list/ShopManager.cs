using System.Collections.Generic;
using UnityEngine;

// ショップに並べるアイテムの一覧を持つ部品。
// Canvas に付けて、Inspector の Items に名前と価格を入力する(README の例を使ってよい)。
public class ShopManager : MonoBehaviour
{
    // Item を何個でも並べられる箱
    public List<Item> items;
}
