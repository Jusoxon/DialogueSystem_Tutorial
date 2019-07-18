using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueMng : MonoBehaviour
{ 
    #region SINGLETON
    public static DialogueMng Ins;
    private void Awake()
    {
        Ins = this;
    }
    #endregion

    public Text nameTxt;
    public Text dialogueTxt;

    public Queue<string> qSetence = new Queue<string>();

    public void OnClickNextBtn()
    {
        if(qSetence.Count <= 0)
        {
            Debug.Log("End Dialogue");
        }
        dialogueTxt.text = qSetence.Dequeue();
    }


}
