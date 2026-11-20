using UnityEngine;
using UnityEngine.InputSystem;

// 第1回の SePlayer(ジャンプ音)の完成形。SePlayer(空の GameObject + Audio Source)に付ける。
// スペースキーでジャンプ音が鳴る。第3回ではこのまま使う(中身は変えない)。
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
