using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword_st : MonoBehaviour
{
    public string sword_color;


    private void OnTriggerEnter(Collider other)
    {
        if(sword_color==other.tag)//칼의 색깔과 노트의 tag가 서로 같다면
        {
            StartCoroutine(GameManager.Game_Mg.Score_input(true, other.GetComponent<note_st>().input_score));
            Destroy(other);
            other.GetComponent<note_st>().broken_obj.SetActive(true);
        }
    }
}
