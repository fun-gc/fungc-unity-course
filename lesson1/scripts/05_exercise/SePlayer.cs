using UnityEngine;
using UnityEngine.InputSystem;

// 演習(SePlayer.cs の TODO 2): スペースキーでジャンプ音を鳴らそう
// SePlayer に付ける。source 欄に同じ SePlayer の Audio Source、jumpClip 欄にジャンプ音をドラッグ。
public class SePlayer : MonoBehaviour
{
    public AudioSource source;
    public AudioClip jumpClip;

    void Update()
    {
        // TODO 2: スペースキーを押した瞬間に、ジャンプ音を鳴らそう
        //   ヒント1: 押した瞬間だけ true になるのは wasPressedThisFrame
        //   ヒント2: 重ねて鳴らすのは source.PlayOneShot(jumpClip)
        //   ヒント3: スライド「スペースキーで鳴らす」を見ながら書いてよい(Keyboard.current は入力・動作・衝突と同じ)


    }
}
