using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class MoveForward : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    void Update()
    {
        // Z 축으로 이동할 벡터 생성
        Vector3 moveDirection = transform.forward;

        // 이동 벡터에 이동 속도를 곱하여 실제 이동 벡터를 만듭니다.
        Vector3 movement = moveDirection * moveSpeed * Time.deltaTime;

        // 오브젝트를 움직입니다.
        transform.Translate(movement);
    }

}
