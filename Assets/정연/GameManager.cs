using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score=0;
    public GameObject result_canvas;
    public TextMeshProUGUI score_text;
    public TextMeshProUGUI result_rating_text;

    string result_rating;

    private static GameManager game_mg = null;

    private void Awake()
    {
        if (game_mg == null)
        {
            game_mg = this;

        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public static GameManager Game_Mg
    {
        get
        {
            if (game_mg == null)
            {
                return null;
            }
            return game_mg;
        }
    }

    private void Update()
    {
        score_text.text = "SCORE: " + score;
    }

    IEnumerator Result()//��� ȭ�� �ڷ�ƾ
    {
        StartCoroutine(Rating(score));
        result_rating_text.text = result_rating;
        result_canvas.SetActive(true);
        yield return null;
    }
    IEnumerator Rating(int Score)// �÷��� ��� ��� �ڷ�ƾ
    {

        if (Score >= 10000)
            result_rating = "Bad";
        else if (Score >= 20000)
            result_rating = "Not Bad";
        else if (Score >= 30000)
            result_rating = "Good";
        else if (Score >= 40000)
            result_rating = "Great";
        else if (Score >= 50000)
            result_rating = "Perfect";

        yield return null;
    }

     public IEnumerator Score_input(bool minus_or_plus,int score_index)//���ھ ���ų� ���ϴ� �ڷ�ƾ. bool�� ���̸� ���ϱ� �����̸� ����.
    {
        if (minus_or_plus)
            score += score_index;
        else
            score -= score_index;

        yield return null;
    }
}
