using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    [SerializeField]
    private Text txtPoints;
    private int points = 0;
    [SerializeField]
    private Text txtLives;
    private int lives = 2;
    public float limitDerecha;
    public float limitIzquierda;

    void Awake()
    {
        if (instance != this)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        SetMinMax();
        txtPoints.text = "Puntos: " + this.points.ToString();
        txtLives.text = "VIdas: " + lives.ToString();
    }

    public void GainPoints(int points)
    {
        this.points += points;
        txtPoints.text = "Puntos: " + this.points.ToString();
    }

    public void LoseLife()
    {
        lives--;
        if (lives == 0)
        {
            SceneManager.LoadScene("Game Over");
        }
        txtLives.text = "VIdas: " + lives.ToString();
    }

    void SetMinMax()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        limitDerecha = (bounds.x * 0.75f);
        limitIzquierda = -(bounds.x * 0.75f);
    }
}
