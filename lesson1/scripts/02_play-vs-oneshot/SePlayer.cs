using UnityEngine;
using UnityEngine.InputSystem;

// 体験用。A(Play)と B(PlayOneShot)を入れ替えて、スペースキーを連打して違いを聞く。
// 今は A が有効。B を試すときは、A の行を // で消して、B の行の // を外す。
// A: Audio Source の Audio Clip 欄に Clip が入っていること。
// B: この clip 欄に Clip をドラッグしておくこと(空だと鳴らない)。
public class SePlayer : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // A
            source.Play();

            // B
            // source.PlayOneShot(clip);
        }
    }
}
