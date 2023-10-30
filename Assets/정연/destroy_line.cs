using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_line : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("broken"))//통과한 오브젝트의 태그가 broken이면
            Destroy(other.gameObject);
    }
}
