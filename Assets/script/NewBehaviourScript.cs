using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    string teksts;
    public GameObject IevadesLauks;
    public GameObject Textlogs;

    public void uzglabāttekstu(){
        teksts = IevadesLauks.GetComponent<Text>().text;
        Textlogs.GetComponent<Text>().text = "Sveiks "+teksts.ToUpper() + "!";
    }
}
