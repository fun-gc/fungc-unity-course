using UnityEngine;

// 02 private とメソッドで守る: hp を private にして、入口の TakeDamage を作る。
public class Enemy
{
    private int hp = 100;

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp < 0)
        {
            hp = 0; // 0より下げない
        }

        // 確認用の表示(スライドにはない行)。private の hp は外から読めないので、中で表示している
        Debug.Log("ダメージ " + damage + "、残りHP: " + hp);
    }
}
