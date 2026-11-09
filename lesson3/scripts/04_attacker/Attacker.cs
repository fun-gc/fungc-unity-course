using UnityEngine;

// Player に付ける。ぶつかった相手の Health を取り出して、ダメージを与える。
// 注意: この版は「取れなかったとき」を考えていない。
//       Health が付いていない床や壁にぶつかると、Console に NullReferenceException が出る(06・07 で直す)。
public class Attacker : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // ぶつかった相手の GameObject から、Health という部品を探して取り出す
        Health h = collision.gameObject.GetComponent<Health>();
        h.TakeDamage(1);
    }
}
