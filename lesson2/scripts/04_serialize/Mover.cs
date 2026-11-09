using UnityEngine;

// 04 Unityでのカプセル化: [SerializeField] private にすると、
// Inspector には出るのに、ほかのスクリプトからは書き換えられない。
public class Mover : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    void Update()
    {
        float x = 0f;
        float z = 0f;

        if (Input.GetKey(KeyCode.RightArrow)) x = 1f;
        if (Input.GetKey(KeyCode.LeftArrow)) x = -1f;
        if (Input.GetKey(KeyCode.UpArrow)) z = 1f;
        if (Input.GetKey(KeyCode.DownArrow)) z = -1f;

        Vector3 move = new Vector3(x, 0f, z);
        transform.position += move * speed * Time.deltaTime;
    }
}
