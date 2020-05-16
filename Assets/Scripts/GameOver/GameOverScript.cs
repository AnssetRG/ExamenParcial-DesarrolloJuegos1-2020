using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    [SerializeField]
    private Button btnMenu;
    // Start is called before the first frame update
    void Start()
    {
        btnMenu.onClick.AddListener(() => GoMenu());
    }

    void GoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
