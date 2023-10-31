using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score=0;
    public GameObject result_canvas;
    public GameObject main_canvas;
    public TextMeshProUGUI score_text;
    public TextMeshProUGUI result_rating_text;
    public TextMeshProUGUI result_score_text;

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
        main_canvas.SetActive(false);
        result_rating_text.text = result_rating;
        result_score_text.text = "SCORE " + score;
        result_canvas.SetActive(true);
        yield return null;
    }
    IEnumerator Rating(int Score)// �÷��� ��� ��� �ڷ�ƾ
    {

        if (Score >= 10000)
            result_rating = "Bad";
        else if (Score >= 50000)
            result_rating = "Not Bad";
        else if (Score >= 100000)
            result_rating = "Good";
        else if (Score >= 150000)
            result_rating = "Great";
        else if (Score >= 200000)
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
