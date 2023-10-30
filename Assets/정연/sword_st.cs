using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword_st : MonoBehaviour
{
    public string sword_color;


    private void OnTriggerEnter(Collider other)
    {
        if(sword_color==other.tag)
        {
            StartCoroutine(GameManager.Game_Mg.Score_input(true, other.GetComponent<note_st>().input_score));
            Destroy(other);
            other.GetComponent<note_st>().broken_obj.SetActive(true);
        }
    }
}
