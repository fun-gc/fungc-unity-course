using UnityEngine;

// Animator と同じ GameObject(Body)に付ける。Animation Event の Function 欄から呼ばれる。
// source ← SePlayer の Audio Source、stepClip ← 足音のファイル。
public class Footsteps : MonoBehaviour
{
    public AudioSource source;
    public AudioClip stepClip;

    // Animation Event から呼ばれるメソッド。public で、引数なし。
    // 名前を変えたら、Event の Function 欄も同じ名前に選び直す。
    public void FootStep()
    {
        // 足音が重なっても途切れないように PlayOneShot(第1回と同じ)
        source.PlayOneShot(stepClip);
    }
}
