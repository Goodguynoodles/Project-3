using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    [SerializeField] private List<Text> buttonList;

    private string playerSide;

    [SerializeField] private GameObject gameOverPaneel;

    [SerializeField] private GameObject restartButton;

    [SerializeField] private Text gameOverText;

    private int moveCount;

    void SetGameControllerReferenceOnButtons()
    {
        for (int i = 0; i < buttonList.Count; i++)
        {
            buttonList[i].GetComponentInParent<GridSpace>().SetGameControllerReference(this);
        }
    }

    public string GetPlayerSide()
    {
        return playerSide;
    }

    public void EndTurn()
    {
        //rij 1
        moveCount++;
        if (buttonList[0].text == playerSide && buttonList[1].text == playerSide && buttonList[2].text == playerSide)
        {
            GameOver(playerSide);
        }
        //rij 2
        if (buttonList[3].text == playerSide && buttonList[4].text == playerSide && buttonList[5].text == playerSide)
        {
            GameOver(playerSide);
        }
        // rij 3
        if (buttonList[6].text == playerSide && buttonList[7].text == playerSide && buttonList[8].text == playerSide)
        {
            GameOver(playerSide);
        }
        // kolom 1
        if (buttonList[0].text == playerSide && buttonList[3].text == playerSide && buttonList[6].text == playerSide)
        {
            GameOver(playerSide);
        }
        // kolom 2
        if (buttonList[1].text == playerSide && buttonList[4].text == playerSide && buttonList[7].text == playerSide)
        {
            GameOver(playerSide);
        }
        // kolom 3
        if (buttonList[2].text == playerSide && buttonList[5].text == playerSide && buttonList[8].text == playerSide)
        {
            GameOver(playerSide);
        }
        // kruijs rechtsboven
        if (buttonList[0].text == playerSide && buttonList[4].text == playerSide && buttonList[8].text == playerSide)
        {
            GameOver(playerSide);
        }
        // kruis linksboven
        if (buttonList[2].text == playerSide && buttonList[4].text == playerSide && buttonList[6].text == playerSide)
        {
            GameOver(playerSide);
        }

        if (moveCount >= 9)
        {
            GameOver("gelijk");
        }
    }

    void GameOver(string winner)
    {
        
    }

    void SetGameOverText()
    {
        
    }

    void ChangeSide()
    {
        if (playerSide == "X")
        {
            playerSide = "O";
        }
        else
        {
            playerSide = "X";
        }

        playerSide = (playerSide == "X" ? "O" : "X");
    }

    void SetBoardInteractable()
    {
        
    }

    void RestartGame()
    {
        
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
