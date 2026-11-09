using UnityEngine;

// TryGetComponent で、取ると確認を1行にまとめた版(06 と同じ働き)。
public class Attacker : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // 取れたら true(h に部品が入る)、取れなければ false
        if (collision.gameObject.TryGetComponent<Health>(out Health h))
        {
            h.TakeDamage(1); // if の中なら h は必ずある
        }
    }
}
