using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject menupanel;
    public GameObject aboutpanel;
    public GameObject hurufhijaiyahpanel;
    public GameObject makhorijulhurufpanel;

    // makhorijul huruf
    public GameObject aqsalhalqipanel;
    public GameObject wasthulhalqipanel;
    public GameObject adnalhalqipanel;
    public GameObject aqsallisanqofpanel;
    public GameObject aqsallisankafpanel;
    public GameObject hafatullisandhodpanel;
    public GameObject tharfullisanrapanel;
    public GameObject tharfullisannunpanel;
    public GameObject hafatullisanlapanel;
    public GameObject tharfullisanthopanel;
    public GameObject tharfullisandhopanel;
    public GameObject tharfullisansodpanel;

    // wasthul lisan
    public GameObject wasthullisanpanel;
    public GameObject wasthullisanzasayapanel;
    public GameObject wasthullisanzapanel;
    public GameObject wasthullisansapanel;
    public GameObject wasthullisanyapanel;

    // asy - syafatain
    public GameObject asy_syafatainpanel;
    public GameObject asy_syafatainfawabamapanel;
    public GameObject asy_syafatainfapanel;
    public GameObject asy_syafatainwapanel;
    public GameObject asy_syafatainbapanel;
    public GameObject asy_syafatainmapanel;    
    
    // Start is called before the first frame update
    void Start()
    {
        menupanel.SetActive(true);
        aboutpanel.SetActive(false);
        hurufhijaiyahpanel.SetActive(false);
        makhorijulhurufpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartARButton(string scenename) {
        SceneManager.LoadScene(scenename);
    }
    
    public void AboutButton() {
        menupanel.SetActive(false);
        aboutpanel.SetActive(true);
        hurufhijaiyahpanel.SetActive(false);
        makhorijulhurufpanel.SetActive(false);    
    }

    public void HurufHijaiyah() {
        menupanel.SetActive(false);
        aboutpanel.SetActive(false);
        hurufhijaiyahpanel.SetActive(true);
        makhorijulhurufpanel.SetActive(false); 
    }
    public void MakhorijulHuruf() {
        menupanel.SetActive(false);
        aboutpanel.SetActive(false);
        hurufhijaiyahpanel.SetActive(false);
        makhorijulhurufpanel.SetActive(true);

        // makhorijul huruf
        aqsalhalqipanel.SetActive(true);
        wasthulhalqipanel.SetActive(false);
        adnalhalqipanel.SetActive(false);
        aqsallisanqofpanel.SetActive(false);
        aqsallisankafpanel.SetActive(false);
        wasthullisanpanel.SetActive(false);
        hafatullisandhodpanel.SetActive(false);
        tharfullisanrapanel.SetActive(false);
        tharfullisannunpanel.SetActive(false);
        hafatullisanlapanel.SetActive(false);
        tharfullisanthopanel.SetActive(false);
        tharfullisandhopanel.SetActive(false);
        tharfullisansodpanel.SetActive(false);
        asy_syafatainpanel.SetActive(false);
    }

    public void AqsalHalqi() {
        aqsalhalqipanel.SetActive(true);
        wasthulhalqipanel.SetActive(false);
        adnalhalqipanel.SetActive(false);
        aqsallisanqofpanel.SetActive(false);
        aqsallisankafpanel.SetActive(false);
        wasthullisanpanel.SetActive(false);
        hafatullisandhodpanel.SetActive(false);
        tharfullisanrapanel.SetActive(false);
        tharfullisannunpanel.SetActive(false);
        hafatullisanlapanel.SetActive(false);
        tharfullisanthopanel.SetActive(false);
        tharfullisandhopanel.SetActive(false);
        tharfullisansodpanel.SetActive(false);
        asy_syafatainpanel.SetActive(false);
    }

    public void WasthulHalqi() {
        aqsalhalqipanel.SetActive(false);
        wasthulhalqipanel.SetActive(true);
        adnalhalqipanel.SetActive(false);
        aqsallisanqofpanel.SetActive(false);
        aqsallisankafpanel.SetActive(false);
        wasthullisanpanel.SetActive(false);
        hafatullisandhodpanel.SetActive(false);
        tharfullisanrapanel.SetActive(false);
        tharfullisannunpanel.SetActive(false);
        hafatullisanlapanel.SetActive(false);
        tharfullisanthopanel.SetActive(false);
        tharfullisandhopanel.SetActive(false);
        tharfullisansodpanel.SetActive(false);
        asy_syafatainpanel.SetActive(false);
    }

    public void AdnalHalqi() {
        aqsalhalqipanel.SetActive(false);
        wasthulhalqipanel.SetActive(false);
        adnalhalqipanel.SetActive(true);
        aqsallisanqofpanel.SetActive(false);
        aqsallisankafpanel.SetActive(false);
        wasthullisanpanel.SetActive(false);
        hafatullisandhodpanel.SetActive(false);
        tharfullisanrapanel.SetActive(false);
        tharfullisannunpanel.SetActive(false);
        hafatullisanlapanel.SetActive(false);
        tharfullisanthopanel.SetActive(false);
        tharfullisandhopanel.SetActive(false);
        tharfullisansodpanel.SetActive(false);
        asy_syafatainpanel.SetActive(false);
    }

    public void AqsalLisanQof() {
        aqsalhalqipanel.SetActive(false);
        wasthulhalqipanel.SetActive(false);
        adnalhalqipanel.SetActive(false);
        aqsallisanqofpanel.SetActive(true);
        aqsallisankafpanel.SetActive(false);
        wasthullisanpanel.SetActive(false);
        hafatullisandhodpanel.SetActive(false);
        tharfullisanrapanel.SetActive(false);
        tharfullisannunpanel.SetActive(false);
        hafatullisanlapanel.SetActive(false);
        tharfullisanthopanel.SetActive(false);
        tharfullisandhopanel.SetActive(false);
        tharfullisansodpanel.SetActive(false);
        asy_syafatainpanel.SetActive(false);
    }

    public void AqsalLisanKaf() {
        aqsalhalqipanel.SetActive(false);
        wasthulhalqipanel.SetActive(false);
        adnalhalqipanel.SetActive(false);
        aqsallisanqofpanel.SetActive(false);
        aqsallisankafpanel.SetActive(true);
        wasthullisanpanel.SetActive(false);
        hafatullisandhodpanel.SetActive(false);
        tharfullisanrapanel.SetActive(false);
        tharfullisannunpanel.SetActive(false);
        hafatullisanlapanel.SetActive(false);
        tharfullisanthopanel.SetActive(false);
        tharfullisandhopanel.SetActive(false);
        tharfullisansodpanel.SetActive(false);
        asy_syafatainpanel.SetActive(false);
    }

    public void WasthulLisan() {
        aqsalhalqipanel.SetActive(false);
        wasthulhalqipanel.SetActive(false);
        adnalhalqipanel.SetActive(false);
        aqsallisanqofpanel.SetActive(false);
        aqsallisankafpanel.SetActive(false);
        wasthullisanpanel.SetActive(true);
        hafatullisandhodpanel.SetActive(false);
        tharfullisanrapanel.SetActive(false);
        tharfullisannunpanel.SetActive(false);
        hafatullisanlapanel.SetActive(false);
        tharfullisanthopanel.SetActive(false);
        tharfullisandhopanel.SetActive(false);
        tharfullisansodpanel.SetActive(false);
        asy_syafatainpanel.SetActive(false);
        
        // wasthul lisan
        wasthullisanzasayapanel.SetActive(true);
        wasthullisanyapanel.SetActive(false);
        wasthullisansapanel.SetActive(false);
        wasthullisanzapanel.SetActive(false);
    }

    public void WasthulLisanZaSaYa() {
        wasthullisanzasayapanel.SetActive(true);
        wasthullisanzapanel.SetActive(false);
        wasthullisansapanel.SetActive(false);
        wasthullisanyapanel.SetActive(false);
    }
    public void WasthulLisanZa() {
        wasthullisanzasayapanel.SetActive(false);
        wasthullisanzapanel.SetActive(true);
        wasthullisansapanel.SetActive(false);
        wasthullisanyapanel.SetActive(false); 
    }
    public void WasthulLisanSa() {
        wasthullisanzasayapanel.SetActive(false);
        wasthullisanzapanel.SetActive(false);
        wasthullisansapanel.SetActive(true);
        wasthullisanyapanel.SetActive(false);
    }
    public void WasthulLisanYa() {
        wasthullisanzasayapanel.SetActive(false);
        wasthullisanzapanel.SetActive(false);
        wasthullisansapanel.SetActive(false);
        wasthullisanyapanel.SetActive(true);
    }

    public void HafatulLisanDho() {
        aqsalhalqipanel.SetActive(false);
        wasthulhalqipanel.SetActive(false);
        adnalhalqipanel.SetActive(false);
        aqsallisanqofpanel.SetActive(false);
        aqsallisankafpanel.SetActive(false);
        wasthullisanpanel.SetActive(false);
        hafatullisandhodpanel.SetActive(true);
        tharfullisanrapanel.SetActive(false);
        tharfullisannunpanel.SetActive(false);
        hafatullisanlapanel.SetActive(false);
        tharfullisanthopanel.SetActive(false);
        tharfullisandhopanel.SetActive(false);
        tharfullisansodpanel.SetActive(false);
        asy_syafatainpanel.SetActive(false);
    }

    public void TharfulLisanRa() {
        aqsalhalqipanel.SetActive(false);
        wasthulhalqipanel.SetActive(false);
        adnalhalqipanel.SetActive(false);
        aqsallisanqofpanel.SetActive(false);
        aqsallisankafpanel.SetActive(false);
        wasthullisanpanel.SetActive(false);
        hafatullisandhodpanel.SetActive(false);
        tharfullisanrapanel.SetActive(true);
        tharfullisannunpanel.SetActive(false);
        hafatullisanlapanel.SetActive(false);
        tharfullisanthopanel.SetActive(false);
        tharfullisandhopanel.SetActive(false);
        tharfullisansodpanel.SetActive(false);
        asy_syafatainpanel.SetActive(false);
    }

    public void TharfullisanNun() {
        aqsalhalqipanel.SetActive(false);
        wasthulhalqipanel.SetActive(false);
        adnalhalqipanel.SetActive(false);
        aqsallisanqofpanel.SetActive(false);
        aqsallisankafpanel.SetActive(false);
        wasthullisanpanel.SetActive(false);
        hafatullisandhodpanel.SetActive(false);
        tharfullisanrapanel.SetActive(false);
        tharfullisannunpanel.SetActive(true);
        hafatullisanlapanel.SetActive(false);
        tharfullisanthopanel.SetActive(false);
        tharfullisandhopanel.SetActive(false);
        tharfullisansodpanel.SetActive(false);
        asy_syafatainpanel.SetActive(false);
    }

    public void HafatulLisanLa() {
        aqsalhalqipanel.SetActive(false);
        wasthulhalqipanel.SetActive(false);
        adnalhalqipanel.SetActive(false);
        aqsallisanqofpanel.SetActive(false);
        aqsallisankafpanel.SetActive(false);
        wasthullisanpanel.SetActive(false);
        hafatullisandhodpanel.SetActive(false);
        tharfullisanrapanel.SetActive(false);
        tharfullisannunpanel.SetActive(false);
        hafatullisanlapanel.SetActive(true);
        tharfullisanthopanel.SetActive(false);
        tharfullisandhopanel.SetActive(false);
        tharfullisansodpanel.SetActive(false);
        asy_syafatainpanel.SetActive(false);
    }

    public void TharfulLisanTho() {
        aqsalhalqipanel.SetActive(false);
        wasthulhalqipanel.SetActive(false);
        adnalhalqipanel.SetActive(false);
        aqsallisanqofpanel.SetActive(false);
        aqsallisankafpanel.SetActive(false);
        wasthullisanpanel.SetActive(false);
        hafatullisandhodpanel.SetActive(false);
        tharfullisanrapanel.SetActive(false);
        tharfullisannunpanel.SetActive(false);
        hafatullisanlapanel.SetActive(false);
        tharfullisanthopanel.SetActive(true);
        tharfullisandhopanel.SetActive(false);
        tharfullisansodpanel.SetActive(false);
        asy_syafatainpanel.SetActive(false);
    }

    public void TharfulLisanDho() {
        aqsalhalqipanel.SetActive(false);
        wasthulhalqipanel.SetActive(false);
        adnalhalqipanel.SetActive(false);
        aqsallisanqofpanel.SetActive(false);
        aqsallisankafpanel.SetActive(false);
        wasthullisanpanel.SetActive(false);
        hafatullisandhodpanel.SetActive(false);
        tharfullisanrapanel.SetActive(false);
        tharfullisannunpanel.SetActive(false);
        hafatullisanlapanel.SetActive(false);
        tharfullisanthopanel.SetActive(false);
        tharfullisandhopanel.SetActive(true);
        tharfullisansodpanel.SetActive(false);
        asy_syafatainpanel.SetActive(false);
    }

    public void TharfulLisanSod() {
        aqsalhalqipanel.SetActive(false);
        wasthulhalqipanel.SetActive(false);
        adnalhalqipanel.SetActive(false);
        aqsallisanqofpanel.SetActive(false);
        aqsallisankafpanel.SetActive(false);
        wasthullisanpanel.SetActive(false);
        hafatullisandhodpanel.SetActive(false);
        tharfullisanrapanel.SetActive(false);
        tharfullisannunpanel.SetActive(false);
        hafatullisanlapanel.SetActive(false);
        tharfullisanthopanel.SetActive(false);
        tharfullisandhopanel.SetActive(false);
        tharfullisansodpanel.SetActive(true);
        asy_syafatainpanel.SetActive(false);
    }

    public void Asy_Syafatain() {
        aqsalhalqipanel.SetActive(false);
        wasthulhalqipanel.SetActive(false);
        adnalhalqipanel.SetActive(false);
        aqsallisanqofpanel.SetActive(false);
        aqsallisankafpanel.SetActive(false);
        wasthullisanpanel.SetActive(false);
        hafatullisandhodpanel.SetActive(false);
        tharfullisanrapanel.SetActive(false);
        tharfullisannunpanel.SetActive(false);
        hafatullisanlapanel.SetActive(false);
        tharfullisanthopanel.SetActive(false);
        tharfullisandhopanel.SetActive(false);
        tharfullisansodpanel.SetActive(false);
        asy_syafatainpanel.SetActive(true);

        // asy-syafatain
        asy_syafatainfawabamapanel.SetActive(true);
        asy_syafatainfapanel.SetActive(false);
        asy_syafatainmapanel.SetActive(false);
        asy_syafatainwapanel.SetActive(false);
        asy_syafatainbapanel.SetActive(false);

    }

    public void Asy_SyafatainFaWaBaMa() {
        asy_syafatainfawabamapanel.SetActive(true);
        asy_syafatainfapanel.SetActive(false);
        asy_syafatainmapanel.SetActive(false);
        asy_syafatainwapanel.SetActive(false);
        asy_syafatainbapanel.SetActive(false);
    }

    public void Asy_SyafatainFa() {
        asy_syafatainfawabamapanel.SetActive(false);
        asy_syafatainfapanel.SetActive(true);
        asy_syafatainmapanel.SetActive(false);
        asy_syafatainwapanel.SetActive(false);
        asy_syafatainbapanel.SetActive(false);
    }

    public void Asy_SyafatainWa() {
        asy_syafatainfawabamapanel.SetActive(false);
        asy_syafatainfapanel.SetActive(false);
        asy_syafatainmapanel.SetActive(false);
        asy_syafatainwapanel.SetActive(true);
        asy_syafatainbapanel.SetActive(false);
    }

    public void Asy_SyafatainBa() {
        asy_syafatainfawabamapanel.SetActive(false);
        asy_syafatainfapanel.SetActive(false);
        asy_syafatainmapanel.SetActive(false);
        asy_syafatainwapanel.SetActive(false);
        asy_syafatainbapanel.SetActive(true);
    }

    public void Asy_SyafatainMa() {
        asy_syafatainfawabamapanel.SetActive(false);
        asy_syafatainfapanel.SetActive(false);
        asy_syafatainmapanel.SetActive(true);
        asy_syafatainwapanel.SetActive(false);
        asy_syafatainbapanel.SetActive(false);
    }
    
    public void BackButton() {
        menupanel.SetActive(true);
        aboutpanel.SetActive(false);
        hurufhijaiyahpanel.SetActive(false);
        makhorijulhurufpanel.SetActive(false); 
    }

    public void QuitButton() {
        Application.Quit();
        Debug.Log("Tombol Keluar Telah Ditekan!.. ");
    }

    public void BackAugmentedButton(string scenename) {
        SceneManager.LoadScene(scenename);
    }
}
