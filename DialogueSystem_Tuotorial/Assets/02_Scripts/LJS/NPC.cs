using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Dialogue dialogue;

    public void OnClickNPCBtn()
    {
        DialogueMng.Ins.nameTxt.text = dialogue.npcName;

        foreach(string sentence in dialogue.sentences)
        {
            DialogueMng.Ins.qSetence.Enqueue(sentence);
        }

        DialogueMng.Ins.dialogueTxt.text = DialogueMng.Ins.qSetence.Dequeue();
    }
}
