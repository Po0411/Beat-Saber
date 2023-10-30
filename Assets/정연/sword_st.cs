using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword_st : MonoBehaviour
{
    public string sword_color;

    private void OnTriggerEnter(Collider other)
    {
        switch (sword_color)
        {
            case "red":
                {
                    Debug.Log("»¡°­");
                    if (other.CompareTag("red"))//Ä®ÀÇ »ö±ò°ú ³ëÆ®ÀÇ tag°¡ ¼­·Î °°´Ù¸é
                    {
                        Debug.Log("´ê¾Ò´Ù");
                        //StartCoroutine(GameManager.Game_Mg.Score_input(true, other.GetComponent<note_st>().input_score));
                        Destroy(other.gameObject);
                        other.GetComponent<note_st>().broken_obj.SetActive(true);
                    }
                }
                break;
            case "blue":
                {
                    Debug.Log("ÆÄ¶û");
                    if (other.CompareTag("blue"))//Ä®ÀÇ »ö±ò°ú ³ëÆ®ÀÇ tag°¡ ¼­·Î °°´Ù¸é
                    {
                        Debug.Log("´ê¾Ò´Ù");
                        //StartCoroutine(GameManager.Game_Mg.Score_input(true, other.GetComponent<note_st>().input_score));
                        Destroy(other.gameObject);
                        other.GetComponent<note_st>().broken_obj.SetActive(true);
                    }
                }
                break;
        }
       
    }
}
