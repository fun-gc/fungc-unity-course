// アイテム1個分のデータ(名前と価格)。オブジェクトには付けない。
// [System.Serializable] を付けると、ShopManager の Inspector で中身を入力できる。
[System.Serializable]
public class Item
{
    public string name;
    public int price;
}
