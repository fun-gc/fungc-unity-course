using UnityEngine;

// ふつうの C# のクラス(設計図)。「: MonoBehaviour」は書かない。
// GameObject にアタッチはしない(できない)。次の 02_new の GameManager から使う。
public class Enemy
{
    // フィールド = データ(実物ごとに値を持つ)
    public string name;
    public int hp;

    // メソッド = 動き(前回の「関数」と同じもの)
    public void Attack()
    {
        Debug.Log(name + "の攻撃！");
    }
}
