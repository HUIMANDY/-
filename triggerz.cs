using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerz : MonoBehaviour
{
    public  int x = 1;
    public GameObject triggerObj;
    // Start is called before the first frame update
    public void Start()
    {
        triggerObj = GameObject.Find("triggerObz");
    }
    public void triggering()
    {
        if (x == 1)
        {
            triggerObj.SendMessage("getbuttomdown");
            x++;
            print(2);
        }
        else if (x == 2)
        {
            closevis(GameObject.Find("1Fdpipe(Clone)").gameObject);
            x++;
            print(3);
        }
        else if (x == 3)
        {
            openvis(GameObject.Find("1Fdpipe(Clone)").gameObject);
            x = 2;
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
