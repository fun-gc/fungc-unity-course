using UnityEngine;

// 補足: 関数の引数と戻り値
public class Hello : MonoBehaviour
{
    void Start()
    {
        // 渡す: 呼ぶたびに出る言葉が変わる
        Greet("スライム");
        Greet("勇者");

        // 答えをもらう: Add(3, 4) の結果 7 が answer に入る
        int answer = Add(3, 4);
        Debug.Log(answer);

        // 材料を渡して、結果を受け取る(ダメージ計算)
        int dmg = CalcDamage(30, 12);
        Debug.Log(dmg);  // 18
    }

    void Greet(string name)
    {
        Debug.Log(name + "、こんにちは！");
    }

    int Add(int a, int b)
    {
        return a + b;
    }

    int CalcDamage(int attack, int defense)
    {
        int result = attack - defense;
        return result;
    }
}
