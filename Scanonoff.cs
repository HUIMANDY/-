﻿
using UnityEngine;
using UnityEngine.UI;
using MRTKExtensions.QRCodes;

public class Scanonoff : MonoBehaviour
{
    public GameObject QRcodescan;
    //public GameObject qrcode;
    //public GameObject HandMenu;
    public GameObject JetHolder;
    public GameObject triggerObj;
    public Canvas Canvas01;
    //public GameObject QRcodescan1;
    //public GameObject TRYT;
    public bool QRonoff = false;
    public bool scann = true;
    public bool Modeldestroy = false;
    public Text textscan;
    public Text textt;
    public Text textt1;
    // Start is called before the first frame update
    void Start()
    {
        // qrcode = GameObject.Find("QRCODE");
        //HandMenu = GameObject.Find("HandMenu");
        JetHolder = GameObject.Find("JetHolder");
        triggerObj = GameObject.Find("triggerObj");
        QRcodescan = GameObject.Find("Trackers");
        QRcodescan.SetActive(false);
        //HandMenu.SetActive(false);
        JetHolder.SetActive(false);
        //triggerObj.SetActive(false);
        textt.text = "";
        textt1.text = "";
        textscan.text = "";
        //qrcode.SetActive(false);
    }
    public void scan()

    {
        textscan.text = "掃描開啟中";

        //QRcodescan1 = GameObject.Find("Tracker2");
        //TRYT = GameObject.Find("JetHolder");
        if (scann == true)
        {
            QRcodescan.SetActive(false);
            //QRcodescan1.GetComponent<QRTrackerController>().enabled = false;
            //TRYT.GetComponent<JetController>().enabled = false;
            //TRYT.GetComponent<JetController2>().enabled = false;
            scann = false;
            textscan.text = "掃描關閉中";
        }
        else
        {
            QRcodescan.SetActive(true);
            // QRcodescan1.GetComponent<QRTrackerController>().enabled = true;
            // TRYT.GetComponent<JetController>().enabled = true;
            //TRYT.GetComponent<JetController2>().enabled = true;
            scann = true;
            textscan.text = "掃描開啟中";
        }
    }
    public void QRONOFF()

    {

        if (QRonoff == true)
        {
            QRcodescan.SetActive(false);
            //HandMenu.SetActive(false);
            JetHolder.SetActive(false);
            //triggerObj.SetActive(false);
            textt.text = "";
            textt1.text = "";
            textscan.text = "";
            QRonoff = false;
           // closeviss(QRloading.go1);
        }
        else
        {
            JetController.QRpose = new Vector3(0, 0, 0);
            //JetController.QRposero = new Vector3(0, 0, 0);
            QRcodescan.SetActive(true);
            //HandMenu.SetActive(true);
            JetHolder.SetActive(true);
            //triggerObj.SetActive(true);
            textt.text = (JetController.QRpose.x.ToString()+","+JetController.QRpose.y.ToString() + "," + JetController.QRpose.z.ToString());
            textt1.text = (JetController.QRposero.x.ToString() + "," + JetController.QRposero.y.ToString() + "," + JetController.QRposero.z.ToString());
            textscan.text = "掃描開啟中";
            QRonoff = true; ;

        }
    }

    public void ModelDestroy()
    {
        GameObject MD = GameObject.Find("ModelManager").transform.GetChild(0).gameObject;
        Destroy(MD);
    }

    // Update is called once per frame
    void Update()
        {

        }
    
}
