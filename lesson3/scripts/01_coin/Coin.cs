using UnityEngine;

// コインに付ける。Player がぶつかったら、コイン(自分)を消す。
public class Coin : MonoBehaviour
{
    // ぶつかった瞬間に、Unity が1回だけ呼んでくれる
    void OnCollisionEnter(Collision collision)
    {
        // 相手の名札(Tag)が Player のときだけ
        if (collision.gameObject.CompareTag("Player"))
        {
            // gameObject = このスクリプトを付けた GameObject(コイン自身)
            Destroy(gameObject);
        }
    }
}
