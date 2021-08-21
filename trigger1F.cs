using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger1F : MonoBehaviour
{
    public int ii = 1;
    public GameObject triggerObj;
    public GameObject Fmenu;
    public GameObject QRmenu;
    public GameObject MDDD;
    // Start is called before the first frame update
    public void Start()
    {
        triggerObj = GameObject.Find("triggerObj1f");
        MDDD = GameObject.Find("MenuModelTools");
        Fmenu = MDDD.gameObject.transform.Find("1Fdownload").gameObject;
        QRmenu= MDDD.gameObject.transform.Find("subQR").gameObject;
    }
    public void triggering()  //控制面板開關 BOOLING值
    {
        if (ii == 1)
        {
            Debug.Log("i=1");
            Fmenu.SetActive(true);
            QRmenu.SetActive(false);
            ii++;
            print(2);
        }
        else if (ii == 2)
        {
            Fmenu.SetActive(false);
            QRmenu.SetActive(true);
            ii = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
