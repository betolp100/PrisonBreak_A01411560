using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    public Text guessT;
    public Text counterT;
    int maxNum;
    int minNum;
    int guess;
    int counter;
    int level;
    int easy = 0;
    int hard = 0;

    string guessString;

    private SceneManager gamestate;
    void Start() { StartGame(); }

    void StartGame()
    {
        maxNum = 1000;
        minNum = 1;
        counter = 8;
        guess = 500;
        counterT.text="8";
    }

    public void NextGuessEasy()
    {
        guess = Random.Range(minNum, maxNum + 1);
        
        guessT.text = guess.ToString();
        counter--;
        counterT.text = counter.ToString();
        if (counter < 0) { SceneManager.LoadScene("Lose2"); }
    }
    public void NextGuessHard()
    {
        guess = ((maxNum + 1) + minNum) / 2;
        guessT.text = guess.ToString();
        counter--;
        counterT.text = counter.ToString();
        if (counter < 0) { SceneManager.LoadScene("Lose2"); }
    }

    public void GuessHigherEasy()
    {
        minNum = guess;
        NextGuessEasy();
    }

    public void GuessLowerEasy()
    {
        maxNum = guess;
        NextGuessEasy();
    }
    public void GuessHigherHard()
    {
        minNum = guess;
        NextGuessHard();
    }

    public void GuessLowerHard()
    {
        maxNum = guess;
        NextGuessHard();
    }

}
