using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword_st : MonoBehaviour
{
    public string sword_color;
    AudioSource audio;

    private void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        switch (sword_color)
        {
            case "red":
                {
                    Debug.Log("빨강");
                    if (other.CompareTag("red"))//칼의 색깔과 노트의 tag가 서로 같다면
                    {
                        audio.Play();
                        StartCoroutine(GameManager.Game_Mg.Score_input(true, other.GetComponent<note_st>().input_score));
                        Destroy(other.gameObject);
                        other.GetComponent<note_st>().broken_obj.SetActive(true);
                    }
                }
                break;
            case "blue":
                {
                    Debug.Log("파랑");
                    if (other.CompareTag("blue"))//칼의 색깔과 노트의 tag가 서로 같다면
                    {
                        audio.Play();
                        StartCoroutine(GameManager.Game_Mg.Score_input(true, other.GetComponent<note_st>().input_score));
                        Destroy(other.gameObject);
                        other.GetComponent<note_st>().broken_obj.SetActive(true);
                    }
                }
                break;
        }
       
    }
}
