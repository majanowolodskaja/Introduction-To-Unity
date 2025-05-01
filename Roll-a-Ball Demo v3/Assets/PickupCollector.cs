using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PickupCollector : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject gameOverText;
    private int score = 0;
    private int totalPickups;

    void Start()
    {
        totalPickups = GameObject.FindGameObjectsWithTag("Pickup").Length;
        UpdateScoreUI();
    }

    void Update()
    {
        if (transform.position.y < -5f)
        {
            GameOver();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            Destroy(other.gameObject);
            score++;
            UpdateScoreUI();

            if (score >= totalPickups)
            {
                Win();
            }
        }
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
    }

    void GameOver()
    {
        gameOverText.SetActive(true);
        Time.timeScale = 0f;
    }

    void Win()
    {
        scoreText.text = "YOU WIN!";
        Time.timeScale = 0f;
    }
}