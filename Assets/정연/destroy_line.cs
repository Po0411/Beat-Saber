using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_line : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("broken"))//����� ������Ʈ�� �±װ� broken�̸�
            Destroy(other.gameObject);
    }
}
