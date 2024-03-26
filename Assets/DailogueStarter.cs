using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class DailogueStarter : MonoBehaviour
{
    public NPCConversation myCon;
    public AudioSource myAudio;
    bool Accepted;
   

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;


            //if (Input.GetKeyDown(KeyCode.F))
         //  {
                ConversationManager.Instance.StartConversation(myCon);

          //  }
        }

      //  Debug.Log("the accepted bool is " + ConversationManager.Instance.GetInt("NumAccepted"));
    }

    private void OnTriggerExit(Collider other)
    {

        
    }

    private void ConversationStart()
    { 
       Debug.Log("A conversation has began.");
    }


    private void getAcceptedNum()
    {
        ConversationManager.Instance.GetInt("Accepted");
    }
}
