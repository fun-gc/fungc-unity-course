using UnityEngine;
using UnityEngine.InputSystem;

// 演習: キューブを矢印キーで動かそう
// ゴール: 矢印キーでキューブが動き、その速さをインスペクターから変えられる
// 枠(using・speed・kb・x と z)は用意済み。TODO 1 と TODO 2 を自分で書こう(答えは講座の最後に見る)
public class Mover : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        var kb = Keyboard.current;
        float x = 0f, z = 0f;

        // TODO 1: 矢印キーを読んで、x と z に入れよう
        //   ヒント1: kb.rightArrowKey.isPressed は、右キーを押している間 true
        //   ヒント2: 右なら x += 1f、左なら x -= 1f、上なら z += 1f、下なら z -= 1f
        //   ヒント3: スライド「矢印キーの入力を読む」を見ながら書いてよい


        // TODO 2: x と z を使って、キューブを動かそう
        //   ヒント1: transform.position += new Vector3(x, 0, z) ... の形
        //   ヒント2: 速さは speed、どのPCでも同じ速さにするには Time.deltaTime をかける
        //   ヒント3: スライド「Time.deltaTime をかける」を見ながら書いてよい


        // ★早く終わった人へ
        //   ・斜めに動くと速くなる問題を直そう(ヒント: .normalized)
        //   ・Shift を押している間だけ速さを2倍にしよう(ヒント: kb.leftShiftKey.isPressed)
    }
}
