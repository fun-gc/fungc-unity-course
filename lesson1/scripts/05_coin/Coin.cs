using UnityEngine;

// コインに付ける。ぶつかったら効果音を鳴らして、コイン自身を消す。
// seSource 欄: SePlayer の Audio Source をドラッグ(コインとは別の GameObject)。
// coinClip 欄: コインの音のファイルをドラッグ。
// 鳴らす係がコインの外にあるので、コインが消えても音は最後まで鳴る。
// 注: このコードは相手を選ばない(Player 以外にぶつかっても消える)。
//     コインは宙に置いておく。「入力・動作・衝突」第3回の CompareTag("Player") を足してもよい。
public class Coin : MonoBehaviour
{
    public AudioSource seSource;
    public AudioClip coinClip;

    void OnCollisionEnter(Collision collision)
    {
        // 音を重ねて鳴らす(コインが消えても続く)
        seSource.PlayOneShot(coinClip);
        // 鳴らしてから消す
        Destroy(gameObject);
    }
}
