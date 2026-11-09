using UnityEngine;

// HP を持つ部品。Enemy にも Player にも付けられる(演習では Player に付ける)。
public class Health : MonoBehaviour
{
    // 外から直接は変えられない(OOP編のカプセル化と同じ)
    private int hp = 3;

    // 外から呼べる窓口。ダメージを受ける
    public void TakeDamage(int amount)
    {
        hp -= amount;
        Debug.Log("HP: " + hp); // hp は private なので Inspector に出ない。Console で確認する
        if (hp <= 0)
        {
            Destroy(gameObject); // HP が尽きたら、自分を消す
        }
    }
}
