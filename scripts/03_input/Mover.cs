using UnityEngine;
using UnityEngine.InputSystem;

// 矢印キーの入力を x(左右)と z(奥手前)に読み取る。
// この段階では、読み取った x と z をまだ位置に足していないので、キューブは動かない。
public class Mover : MonoBehaviour
{
    void Update()
    {
        var kb = Keyboard.current;
        float x = 0f, z = 0f;
        if (kb.rightArrowKey.isPressed) x += 1f;
        if (kb.leftArrowKey.isPressed) x -= 1f;
        if (kb.upArrowKey.isPressed) z += 1f;
        if (kb.downArrowKey.isPressed) z -= 1f;
    }
}
