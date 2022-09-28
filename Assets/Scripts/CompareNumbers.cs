using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CompareNumbers : MonoBehaviour
{
    public TextMeshProUGUI textA, textB, textC, score;
    public int[] randomNum;
    public static int totalscore; //Utilizamos Static para poder usarla directamente en otro scene

    [SerializeField] private int points;

    // Start is called before the first frame update
    void Start()
    {
        newValues();
    }

    public void esMenor() //Lógica si es menor A < B
    {
        if (randomNum[0] < randomNum[1]) {
            points++; 
            score.text = "Score: " + points.ToString(); 
            newValues();
            if (textB.enabled)
            {
                textB.enabled = false;
                textC.enabled = true;
            }
        } else { totalscore = points; SceneManager.LoadScene("Final Score"); };
    }

    public void esMayor() //Lógica si es mayor A > B
    {
        if (randomNum[0] > randomNum[1]) {
            points++;
            score.text = "Score: " + points.ToString();
            newValues();
            if (textB.enabled)
            {
                textB.enabled = false;
                textC.enabled = true;
            }
        } else { totalscore = points; SceneManager.LoadScene("Final Score"); };
    }

    void newValues()
    {
        //Guardamos dos valores al azar en un listado de tipo int
        for (int i = 0; i < 2; i++) randomNum[i] = Random.Range(0, 1000);
        
        //Le asignamos a cada texto uno de los valores obtenidos
        textA.text = randomNum[0].ToString();
        textB.text = randomNum[1].ToString();
    }

    public void hint()
    {
        if (points > 0 && points - 3 >= 0){
            points -= 3;
            score.text = "Score: " + points.ToString();
            textB.enabled = true;
            textC.enabled = false;
        }
    }
}
