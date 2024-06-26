using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PipesHolder;
    public GameObject[] Pipes;
    public bool IsPuzzleDone;

    [SerializeField]
    int totalPipes = 0;

    int correctedPipes = 0;

    // Start is called before the first frame update
    void Start()
    {
        IsPuzzleDone = false;

        totalPipes = PipesHolder.transform.childCount;

        Pipes = new GameObject[totalPipes];

        for (int i = 0; i < Pipes.Length; i++) 
        {
            Pipes[i] = PipesHolder.transform.GetChild(i).gameObject;
        }
    }

    public void correctMove()
    {
        correctedPipes += 1;

        Debug.Log("correct move");

        if(correctedPipes == totalPipes)
        {
            IsPuzzleDone = true;
            Debug.Log("You Win!");
        }
    }

    public void wrongMove()
    {
        correctedPipes -= 1;
    }


}
