using UnityEngine;

// 取れなかったとき(null)に備えた版。床や壁にぶつかってもエラーにならない。
public class Attacker : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Health h = collision.gameObject.GetComponent<Health>();
        // 付いていなければ h は null(何もない)。取れたときだけ呼ぶ
        if (h != null)
        {
            h.TakeDamage(1);
        }
    }
}
