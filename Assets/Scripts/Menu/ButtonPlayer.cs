using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonPlayer : MonoBehaviour
{
    private Button button;
    private string player;
    void Start()
    {
        button = GetComponent<Button>();
        player = gameObject.name[gameObject.name.Length - 1].ToString();
        button.onClick.AddListener(() => GoGame());
    }
    void GoGame()
    {
        PlayerPrefs.SetString("player", player);
        SceneManager.LoadScene("Game");
    }
}
