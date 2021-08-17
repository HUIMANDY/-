using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger1F : MonoBehaviour
{
    public int i = 1;
    public GameObject triggerObj;
    // Start is called before the first frame update
    void Start()
    {
        triggerObj = GameObject.Find("triggerObj1f");
    }
    public void triggering()
    {
        if (i == 1)
        {
            triggerObj.SendMessage("getbuttomdown");
            i++;
            print(2);
        }
        else if (i == 2)
        {
            closevis(GameObject.Find("1Fpipe(Clone)").gameObject);
            i++;
            print(3);
        }
        else if (i == 3)
        {
            openvis(GameObject.Find("1Fpipe(Clone)").gameObject);
            i = 2;
            print(2);
        }

    }
    public void closevis(GameObject model)
    {
        foreach (Transform child in model.transform)
        {
            if (null == child)
                continue;
            if (child.gameObject.GetComponent<MeshRenderer>())
            {
                child.gameObject.GetComponent<MeshRenderer>().enabled = false;
            }
            else if (child.gameObject.GetComponent<SpriteRenderer>())
            {
                child.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            }

            closevis(child.gameObject);

        }
    }
    public void openvis(GameObject model)
    {
        model.transform.SetAsFirstSibling();
        foreach (Transform child in model.transform)
        {
            if (null == child)
                continue;
            if (child.gameObject.GetComponent<MeshRenderer>())
            {
                child.gameObject.GetComponent<MeshRenderer>().enabled = true;
            }
            else if (child.gameObject.GetComponent<SpriteRenderer>())
            {
                child.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            }

            openvis(child.gameObject);

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
