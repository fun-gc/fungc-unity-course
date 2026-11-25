using UnityEngine;
using UnityEngine.InputSystem;

// 演習(SePlayer.cs の TODO 3・4): スペースキーでジャンプ音を鳴らそう
// SePlayer に付ける。欄を作ったら、同じ SePlayer の Audio Source とジャンプ音をドラッグ。
public class SePlayer : MonoBehaviour
{
    // TODO 3: 鳴らす Audio Source と、ジャンプ音の Clip を入れる欄を作ろう
    //   ヒント1: Coin.cs の TODO 1 と同じ形(public、型は AudioSource と AudioClip)
    //   ヒント2: 名前は source・jumpClip にすると TODO 4 のヒントと合う


    void Update()
    {
        // TODO 4: スペースキーを押した瞬間に、ジャンプ音を鳴らそう
        //   ヒント1: 押した瞬間だけ true になるのは wasPressedThisFrame
        //   ヒント2: 重ねて鳴らすのは source.PlayOneShot(jumpClip)
        //   ヒント3: スライド「スペースキーで鳴らす」を見ながら書いてよい(Keyboard.current は入力・動作・衝突と同じ)


    }
}
