using System.Collections.Generic;
using UnityEngine;
using TMPro;

// 演習: ショップ画面を完成させよう
// ゴール: 3つの画面が1つのメニューにつながり、ショップで買い物ができる
// 準備: 03 の ShopManager.cs と ShopRow.cs を削除してから、このフォルダの2つを入れる(Item.cs は同じ)。
//       ショップパネルに所持金の Text (TMP) を置き、moneyText にドラッグする。
//       MenuManager は 05 か 06 のものをそのまま使う。
// TODO 1(このファイル)と TODO 2(ShopRow.cs)を自分で書こう(答えは講座の最後に見る)
public class ShopManager : MonoBehaviour
{
    public ShopRow rowPrefab;   // 行の Prefab
    public Transform content;   // 行を入れる場所
    public List<Item> items;
    public int money = 300;
    public TMP_Text moneyText;

    // 生成した行を覚えておく箱
    List<ShopRow> rows = new List<ShopRow>();

    void Start()
    {
        foreach (Item item in items)
        {
            ShopRow row = Instantiate(rowPrefab, content);
            row.Setup(item, this);
            rows.Add(row);
        }
        Refresh();
    }

    public void Buy(Item item)
    {
        if (money < item.price) return;
        money -= item.price;
        Refresh();
    }

    // 所持金の表示と、全部の行の「押せる/押せない」をまとめて直す
    void Refresh()
    {
        // TODO 1: moneyText に「250G」のように所持金を出し、rows の全部の行に今の所持金を教えよう
        //   ヒント1: 数と文字は + でつなげる(money + "G")
        //   ヒント2: foreach (ShopRow row in rows) で1行ずつ取り出し、row.Refresh(money) を呼ぶ
        //   ヒント3: スライド「行を生成する：Instantiate」の foreach を見ながら書いてよい

    }

    // ★早く終わった人へ
    //   ・購入したアイテムの行を一覧から消そう
    //     (ヒント: ShopRow の OnBuyClicked で、買えたときだけ Destroy(gameObject) する。
    //      Buy が「買えたかどうか」を bool で返すようにすると分かりやすい。消した行は rows.Remove(行) で箱からも外す)
    //   ・CanvasGroup の alpha を少しずつ変えて、パネルをフェードで切り替えよう
    //     (ヒント: Update で alpha に Time.deltaTime を足していく。スライド「CanvasGroup でまとめて制御」)
}
