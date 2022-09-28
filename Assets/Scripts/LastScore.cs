using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LastScore : MonoBehaviour
{
    public TextMeshProUGUI finalScoreText;
    public string[] phrases;

    private void Awake()
    {
        phrases[0] = "Has perdido... mejor intentalo de nuevo!";
        phrases[1] = "Has perdido... pero no te desanimes, pudiste hacer " + CompareNumbers.totalscore + " puntos!";
        phrases[2] = "Has perdido... pero ya con " + CompareNumbers.totalscore + " puntos, sos mejor que la mayoría!";
    }

    // Start is called before the first frame update
    void Start()
    {
        if (CompareNumbers.totalscore == 0) { finalScoreText.text = phrases[0]; }
        else if (CompareNumbers.totalscore <= 5) { finalScoreText.text = phrases[1]; }
        else if (CompareNumbers.totalscore > 5) { finalScoreText.text = phrases[2]; }

    }

    public void playAgain()
    {
        //Opcion 1 Buscar por su nombre
        SceneManager.LoadScene("Game");

        //Opcion 2 Buscar por orden en Build Settings
        //SceneManager.LoadScene(0);
    }
}
