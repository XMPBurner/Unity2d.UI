using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript1 : MonoBehaviour
{
    public GameObject bean;
    public GameObject lacuks;
    public GameObject tante;
    public GameObject masina;
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject Slideris;

public void binaAttelosana(bool vertiba){
    bean.SetActive(vertiba);
}
public void lacisAttelosana(bool vertiba){
    lacuks.SetActive(vertiba);
}
public void masinaAttelosana(bool vertiba){
    masina.SetActive(vertiba);
}
public void tanteAttelosana(bool vertiba){
    tante.SetActive(vertiba);
}
public void paKreisiBins()
{
    bean.transform.localScale = new Vector2(1, 1);
}
public void paLabiBins()
{
    bean.transform.localScale = new Vector2(-1, 1);
}
public void izkritosais(int skaitlis){
    if(skaitlis==0){
        mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
    }else if (skaitlis==1){
        mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
    }else if (skaitlis==2){
        mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[2];
    }
}

    public void mainitLielumu(){
        float pasreizejavertiba = Slideris.GetComponent<Slider>().value;
        mainigaisAttels.traansform.localScale = new Vector2(1F * pasreizejavertiba, 1F  pasreizejavertiba);
    }
}