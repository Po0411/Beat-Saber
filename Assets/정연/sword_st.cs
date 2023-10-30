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
                    Debug.Log("����");
                    if (other.CompareTag("red"))//Į�� ����� ��Ʈ�� tag�� ���� ���ٸ�
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
                    Debug.Log("�Ķ�");
                    if (other.CompareTag("blue"))//Į�� ����� ��Ʈ�� tag�� ���� ���ٸ�
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
