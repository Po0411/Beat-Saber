using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class secne_move : MonoBehaviour
{
    public string scene_name;
    public void onclick()
    {
        SceneManager.LoadScene(scene_name);
    }
}
