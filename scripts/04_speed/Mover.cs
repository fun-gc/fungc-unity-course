using UnityEngine;
using UnityEngine.InputSystem;

// 矢印キーで動く。speed × Time.deltaTime で、どのPCでも1秒に speed だけ進む。
// speed はインスペクターで変えられる。
public class Mover : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        var kb = Keyboard.current;
        float x = 0f, z = 0f;
        if (kb.rightArrowKey.isPressed) x += 1f;
        if (kb.leftArrowKey.isPressed) x -= 1f;
        if (kb.upArrowKey.isPressed) z += 1f;
        if (kb.downArrowKey.isPressed) z -= 1f;

        transform.position += new Vector3(x, 0, z) * speed * Time.deltaTime;
    }
}
