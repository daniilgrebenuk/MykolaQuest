using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TikTakToe : MonoBehaviour
{
    public Cell[] cells;
    public bool isWinner;
    public Win win;
    public Lose lose;
    public Draw draw;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickNol()
    {
        var freeCells = cells.ToList().Where(cell => !cell.krest.activeSelf && !cell.nol.activeSelf).ToArray();
        if(freeCells.Length == 0)
        {
            if(!CheckCombination())
                draw.picture.SetActive(true);
            return;
        }

        var randomIndex = Random.Range(0, freeCells.Length);
        freeCells[randomIndex].nol.SetActive(true);
        CheckCombination();
    }

    public bool CheckCombination()
    {
        bool wasCombination = false;
        if(isWin())
        {
            win.picture.SetActive(true);
            win.code.SetActive(true);
            wasCombination = true;
        } else if(isOver())
        {
            lose.picture.SetActive(true);
            Debug.Log("lose");
            wasCombination = true;
        }
        
        return wasCombination;
    }

    bool isWin()
    {
        if (cells[0].krest.activeSelf 
            && cells[1].krest.activeSelf
            && cells[2].krest.activeSelf)
        {
            return true;
        }

        if (cells[3].krest.activeSelf
            && cells[4].krest.activeSelf
            && cells[5].krest.activeSelf)
        {
            return true;
        }

        if (cells[6].krest.activeSelf
            && cells[7].krest.activeSelf
            && cells[8].krest.activeSelf)
        {
            return true;
        }



        if (cells[0].krest.activeSelf
            && cells[3].krest.activeSelf
            && cells[6].krest.activeSelf)
        {
            return true;
        }

        if (cells[1].krest.activeSelf
            && cells[4].krest.activeSelf
            && cells[7].krest.activeSelf)
        {
            return true;
        }

        if (cells[2].krest.activeSelf
            && cells[5].krest.activeSelf
            && cells[8].krest.activeSelf)
        {
            return true;
        }



        if (cells[0].krest.activeSelf
            && cells[4].krest.activeSelf
            && cells[8].krest.activeSelf)
        {
            return true;
        }

        if (cells[2].krest.activeSelf
            && cells[4].krest.activeSelf
            && cells[6].krest.activeSelf)
        {
            return true;
        }

        return false;
    }

    bool isOver()
    {
        if (cells[0].nol.activeSelf
            && cells[1].nol.activeSelf
            && cells[2].nol.activeSelf)
        {
            return true;
        }

        if (cells[3].nol.activeSelf
            && cells[4].nol.activeSelf
            && cells[5].nol.activeSelf)
        {
            return true;
        }

        if (cells[6].nol.activeSelf
            && cells[7].nol.activeSelf
            && cells[8].nol.activeSelf)
        {
            return true;
        }



        if (cells[0].nol.activeSelf
            && cells[3].nol.activeSelf
            && cells[6].nol.activeSelf)
        {
            return true;
        }

        if (cells[1].nol.activeSelf
            && cells[4].nol.activeSelf
            && cells[7].nol.activeSelf)
        {
            return true;
        }

        if (cells[2].nol.activeSelf
            && cells[5].nol.activeSelf
            && cells[8].nol.activeSelf)
        {
            return true;
        }



        if (cells[0].nol.activeSelf
            && cells[4].nol.activeSelf
            && cells[8].nol.activeSelf)
        {
            return true;
        }

        if (cells[2].nol.activeSelf
            && cells[4].nol.activeSelf
            && cells[6].nol.activeSelf)
        {
            return true;
        }

        return false;
    }
}
