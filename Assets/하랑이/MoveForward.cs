using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class MoveForward : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    void Update()
    {
        // Z ������ �̵��� ���� ����
        Vector3 moveDirection = transform.forward;

        // �̵� ���Ϳ� �̵� �ӵ��� ���Ͽ� ���� �̵� ���͸� ����ϴ�.
        Vector3 movement = moveDirection * moveSpeed * Time.deltaTime;

        // ������Ʈ�� �����Դϴ�.
        transform.Translate(movement);
    }

}
