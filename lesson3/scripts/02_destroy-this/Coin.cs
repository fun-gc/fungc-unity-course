using UnityEngine;

// わざと間違えた版(よくあるつまずき)。エラーは出ないが、コインは消えない。
// 再生中に Inspector を見ると、Coin (Script) だけが消えている。
public class Coin : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // this は Coin スクリプト(部品)自身。消えるのは部品だけ
            Destroy(this);
        }
    }
}
