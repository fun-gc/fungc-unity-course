using UnityEngine;

// わざと間違えた版(よくあるつまずき)。エラーは出ないが、音が途中で切れる。
// コインに付いた Audio Source で鳴らしてすぐ Destroy するので、
// 鳴らしている Audio Source ごとコインが消えて、音も止まる。
// 直し方はスライドの OK 側(鳴らす係を別の GameObject に置く)。演習で自分で書く。
// コインに Audio Source を付けて、Audio Clip を入れておくと確かめられる(Play On Awake は OFF)。
public class Coin : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // コインの中の AudioSource で鳴らす
        GetComponent<AudioSource>().Play();
        // コインごと消える。音も一緒に止まる
        Destroy(gameObject);
    }
}
