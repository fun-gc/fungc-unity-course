using UnityEngine;

public class HelloIf : MonoBehaviour
{
    void Start()
    {
        int hp = 0;

        // 「もし hp が 0 以下なら」で処理を分ける
        // hp の値を 50 に変えて、表示が変わるか試そう
        if (hp <= 0)
        {
            Debug.Log("ゲームオーバー");
        }
        else
        {
            Debug.Log("まだ戦える！");
        }
    }
}
