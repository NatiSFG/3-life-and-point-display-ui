using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour {

    public static ScoreManager instance;
    public int livesLost;
    [SerializeField] private TextMeshProUGUI pointText;
    [SerializeField] private Image[] lives;

    private int pointScore;

    private void Awake() {
        instance = this;
    }

    private void Start() {
        pointText.text = pointScore.ToString();
        lives[0].enabled = true;
        lives[1].enabled = true;
        lives[2].enabled = true;
        lives[3].enabled = true;
        lives[4].enabled = true;
    }

    public void AddPoint() {
        pointScore++;
        pointText.text = pointScore.ToString();
    }

    public void SubtractLife() {
        int i = 4;
        i -= livesLost;
            switch (i) {
                case 4:
                    lives[0].enabled = true;
                    lives[1].enabled = true;
                    lives[2].enabled = true;
                    lives[3].enabled = true;
                    lives[4].enabled = false;
                    livesLost = 1;
                    i -= livesLost;
                    break;

                case 3:
                    lives[0].enabled = true;
                    lives[1].enabled = true;
                    lives[2].enabled = true;
                    lives[3].enabled = false;
                    lives[4].enabled = false;
                    livesLost = 2;
                    i -= livesLost;
                    break;

                case 2:
                    lives[0].enabled = true;
                    lives[1].enabled = true;
                    lives[2].enabled = false;
                    lives[3].enabled = false;
                    lives[4].enabled = false;
                    livesLost = 3;
                    i -= livesLost;
                    break;

                case 1:
                    lives[0].enabled = true;
                    lives[1].enabled = false;
                    lives[2].enabled = false;
                    lives[3].enabled = false;
                    lives[4].enabled = false;
                    livesLost = 4;
                    i -= livesLost;
                    break;

                case 0:
                    lives[0].enabled = false;
                    lives[1].enabled = false;
                    lives[2].enabled = false;
                    lives[3].enabled = false;
                    lives[4].enabled = false;
                    break;
            }
    }
}
