//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class GameManager : MonoBehaviour
//{

//    public GameObject CurrentCall;
//    public GameObject Board;

//    public int good_call_count;
//    public int bad_call_count;

//    private Call _callScript;
//    private Board _boardScript;

//    void Start()
//    {
//        _callScript = CurrentCall.GetComponent<Call>();
//        _boardScript = Board.GetComponent<Board>();
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.DownArrow))
//        {

//        }
//    }

//    public Scenario CheckNextCallScenario()
//    {
//        var plugs = _boardScript.GetPluggedJacks();

//        if (plugs.Count == 2)
//        {
//            return _callScript.Check(plugs[0], plugs[1]);
//        }

//        return Scenario.Incomplete;

//    }

//    public void SetCurrentCall(GameObject call)
//    {
//        if (CurrentCall == null)
//        {
//            //what do we do if the call failed?
//        }
//        else
//        {
//            CurrentCall = call;
//            _callScript = CurrentCall.GetComponent<Call>();

//        }
//    }

//    public void count_callScenarios()
//    {
//        /* This function will count the amount of evesdrop or normal calls, and 
//         * so we can determine the ending if it's good, average, or bad */

//        Scenario scenario = CheckNextCallScenario();
//        //int bad_count = 0;
//        //int good_count = 0;
//        if (scenario == Scenario.Eavesdrop){
//            bad_call_count++;
//        }
//        else{
//            if (scenario == Scenario.Normal)
//            {
//                good_call_count++;
//            }
//            else
//            {
//                /* The failed call */
//            }
//        }
        
//    }

//    public void game_Outcome()
//    {
//        /* This function will determine the outcome of the game, depending on the amount
//         * of eavesdrop or normal calls the player had */
//        int x_outcome = 5;
//        if (good_call_count > x_outcome)
//        {
//            /* good ending */
//        }
//        else
//        {
//            if (bad_call_count > x_outcome)
//            {
//                /* player had too many eavesdrop calls
//                /* bad ending */
//            }
//            else
//            {
//                /* player had equal amount or average amount of eavesdropping calls and normal calls */
//                /* average ending */
//            }
//        }

//    }
//    public void Good_Outcome()
//    {

//    }
//    public void Bad_Outcome()
//    {

//    }
//}
