using UnityEngine;
using UnityEngine.InputSystem;

// 空の GameObject「SePlayer」に付ける。スペースキーを押した瞬間に、音を鳴らす。
// source 欄に、同じ SePlayer の Audio Source をドラッグして入れる。
// Audio Source の Audio Clip 欄には、音のファイルを入れておく。
public class SePlayer : MonoBehaviour
{
    public AudioSource source;

    void Update()
    {
        // 押した瞬間の1フレームだけ true(押している間ずっとは isPressed)
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // 入っている Clip を最初から鳴らす
            source.Play();
        }
    }
}
