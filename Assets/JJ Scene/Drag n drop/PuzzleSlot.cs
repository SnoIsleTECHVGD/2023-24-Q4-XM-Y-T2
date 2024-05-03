using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSlot : MonoBehaviour
{
    public SpriteRenderer Renderer;
    public static int SolveNumber;
    public int pubnumber;
    public DoorCode doorscript;
    public bool win,winonce;
    public int wincount;
    public ErrorsForRooms errorcheck;
    //[SerializeField] private AudioSource _source;
    //[SerializeField] private AudioClip _completeClip;

    private void Start()
    {

        SolveNumber = 4;
        doorscript = GameObject.Find("MainOffice").GetComponent<DoorCode>();

    }
    private void Update()
    {
        errorcheck = GameObject.Find("Main Camera").GetComponent<ErrorsForRooms>();
        pubnumber = SolveNumber;

        if (doorscript.GLitchedOutUp) //Opens the vent
        {
            SolveNumber = 0;
            


        }

        //if(SolveNumber == 4)
        //{

        //    //win = true;
        //    doorscript.GLitchedOutUp = false;
        //}

        if (SolveNumber == 0)
        {

            doorscript.upclosed = false;
            
        }
       

        if(SolveNumber == 0 && !doorscript.upclosed)
        {
            doorscript.GLitchedOutUp = false;
           
           
        }


        if(SolveNumber == 4) //Closes the vent
        {
            doorscript.upclosed = true;
            //errorcheck.IsThereError = false;

            
        }

        if (SolveNumber == 4 && errorcheck.RoomError == "HallwayRoom (UnityEngine.GameObject)")
        {

            errorcheck.RoomNumber = 0;

        }
        //if(win)
        // {

        //     WinOnce();
        //     CancelInvoke(nameof(WinOnce));

        // }

        //if(winonce == true)
        // {

        //     winonce = false;

        // }

    }


    //void WinOnce()
    //{

    //    winonce = true;


    //}
    public void Placed()
    {
        SolveNumber++;
        Debug.Log(SolveNumber);
        //return;
        //_source.PlayOneShot(_completeClip);
    }

  

}
