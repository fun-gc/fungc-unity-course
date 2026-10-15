using UnityEngine;

// 第1回の Enemy クラス(フィールドは public のまま)。今日はこれを少しずつ「守る」形に変えていく。
// GameObject にアタッチはしない。
public class Enemy
{
    public string name;
    public int hp;

    public void Attack()
    {
        Debug.Log(name + "の攻撃！");
    }
}
