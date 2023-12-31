
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;

    public bool isGameover = false;
    public Text scoreText;
    public GameObject gameoverUI;

    private int score = 0;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("씬에 두개 이상의 게임 매니저가 존재합니다.");
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameover && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void AddScore(int newScore)
    {
        if(!isGameover)
        {
            score += newScore;
            scoreText.text = "Score : " + score;

        }
    }
    public void OnplayerDead()
    {
        isGameover = true;
        gameoverUI.SetActive(true);
    }
}
