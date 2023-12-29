using UnityEngine;

public class Movement2D : MonoBehaviour
{
    private float moveSpeed = 5.0f;
    private Vector3 moveDirection = Vector3.zero;

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vectical");

        // �̵����� ����
        moveDirection = new Vector3(x, y, 0);

        // ���ο� ��ġ = ���� ��ġ + (���� * �ӵ�)
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
