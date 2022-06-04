using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private static GameManager s_instance;
    public static GameManager Instance
    {
        get { return s_instance; }
    }

    
    [SerializeField] private TextMeshProUGUI m_scoreText;
    [SerializeField] private TextMeshProUGUI m_highScoreText;
    [SerializeField] private TextMeshProUGUI m_messageText;
    [SerializeField] private GameObject m_ballPrefab;

    [SerializeField] private float m_ballStartXmin = -7.0f;
    [SerializeField] private float m_ballStartXmax = 10.0f;
    [SerializeField] private float m_ballStartY = 5.0f;
    [SerializeField] private float m_ballStartZ = 4.25f;

    private int m_currentScore = 0;
    private int m_highScore = 0;
    private bool m_ballInPlay = false;

    private void Awake()
    {
        if(s_instance != null && s_instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        s_instance = this;
        DontDestroyOnLoad(this.gameObject);

    }

    private void Start()
    {
        ResetGame();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !m_ballInPlay)
        {
            ThrowBall();
        }

    }

    public void PegHit(int score)
    {
        m_currentScore += score;
        m_scoreText.text = "Score: " + m_currentScore;
    }

    public void RoundComplete()
    {
        m_ballInPlay = false;

        if(m_currentScore > m_highScore)
        {
            m_messageText.text = "New high score!";
            m_highScore = m_currentScore;
            m_highScoreText.text = "High Score: " + m_highScore;
        }
        else
        {
            m_messageText.text = "Good try!";
        }

        StartCoroutine(MessageTimer(3));

    }

    public void ResetGame()
    {
        // reset the current score to 0
        m_currentScore = 0;

        // Update the score displays
        m_scoreText.text = "Score: " + m_currentScore;
        m_highScoreText.text = "High Score: " + m_highScore;

        // Display the starting message 
        m_messageText.text = "Click anywhere to throw the ball";
    }

    private void ThrowBall()
    {
        float m_ballStartX = Random.Range(m_ballStartXmin, m_ballStartXmax);
        Vector3 ballPosition = new Vector3(m_ballStartX, m_ballStartY, m_ballStartZ);

        Instantiate(m_ballPrefab, ballPosition, Quaternion.identity);
        m_ballInPlay = true;

    }

    IEnumerator MessageTimer(int waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        ResetGame();
    }

}
