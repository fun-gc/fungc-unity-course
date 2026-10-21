using UnityEngine;

// base.Attack() で親の処理も呼ぶ。親の処理 → 子の処理の順に動く。
public class Boss : Enemy
{
    public override void Attack()
    {
        base.Attack(); // 親の Attack() も実行
        Debug.Log("ファイアを放つ！");
    }
}
