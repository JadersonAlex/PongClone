using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int playerScore { get; private set; }
    public int computerScore { get; private set; }

    [SerializeField] private Ball ball;
    [SerializeField] private Paddle playerPaddle;
    [SerializeField] private Paddle computerPaddle;
    [SerializeField] private Text playerScoreText;
    [SerializeField] private Text computerScoreText;


     public AudioClip PointSound;
    private AudioSource audioSource;

    private void Start()
    {
        NewGame();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            NewGame();
        }
    }

    public void NewGame()
    {
        SetPlayerScore(0);
        SetComputerScore(0);
        NewRound();
    }

    public void NewRound()
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.ResetPosition();

        CancelInvoke();
        Invoke(nameof(StartRound), 1f);
    }

    private void StartRound()
    {
        ball.AddStartingForce();
    }

    public void OnPlayerScored()
    {
        SetPlayerScore(playerScore + 1);
        audioSource.PlayOneShot(PointSound); // toca o som do ponto
        NewRound();
    }

    public void OnComputerScored()
    {
        SetComputerScore(computerScore + 1);
        audioSource.PlayOneShot(PointSound); // toca o som do ponto
        NewRound();
    }

    private void SetPlayerScore(int score)
    {
        playerScore = score;
        playerScoreText.text = score.ToString();
    }

    private void SetComputerScore(int score)
    {
        computerScore = score;
        computerScoreText.text = score.ToString();
    }

}
