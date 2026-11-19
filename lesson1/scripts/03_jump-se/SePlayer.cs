using UnityEngine;
using UnityEngine.InputSystem;

// SePlayer に付ける。スペースキーでジャンプ音を鳴らす(重ねて鳴らせる PlayOneShot)。
// 02 から変わる所: clip → jumpClip。Clip は引数で渡すので、
// Audio Source 側の Audio Clip 欄は空でもよい。
public class SePlayer : MonoBehaviour
{
    public AudioSource source;
    public AudioClip jumpClip;

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // 今鳴っている音を止めずに、重ねて鳴らす
            source.PlayOneShot(jumpClip);
        }
    }
}
