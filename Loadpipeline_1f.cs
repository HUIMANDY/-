using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public class Loadpipeline_1f : MonoBehaviour
{
    /*
    private float x = -3.44f;
    private float y = -1.1f;
    private float z = 1.02f;
    */

    private float x = -3.44f;
    private float y = -1.1f;
    private float z = 1.02f;
    private float x1 = 0;
    private float y1 = 0;
    private float z1 = 0;
    public static GameObject go1;
    public BoundingBox bbox;
    public GameObject mdl;
    public bool pipeline_1f = false;
    public static Vector3 QRpose;   
    public List<string> pipename=new List<string>();
    public List<string> pipenum=new List<string>(); 

    /*private void Awake()
    {
        instance = this;
    }*/
    public IEnumerator getmodelfromazure()
    {
        //Status.text = "已點擊";
        yield return new WaitForSeconds(2f);
        var uwr = UnityWebRequestAssetBundle.GetAssetBundle("https://firebasestorage.googleapis.com/v0/b/bonbon-87e02-jiavs/o/1fpipe?alt=media&token=69c79c52-ed30-4df0-8d69-876dafc267c0");
        yield return uwr.SendWebRequest();

        // Get an asset from the bundle and instantiate it.
        AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(uwr);
        //var loadAsset = bundle.LoadAssetAsync<GameObject>("Assets/Players/MainPlayer.prefab");
        var loadAsset = bundle.LoadAsset("1fpipe");
        yield return loadAsset;
        //Instantiate(loadAsset.asset);
        //Instantiate(loadAsset);
        //if (Instantiate(loadAsset)) = true;
        //yield return new WaitForSeconds(2f);
        go1 = Instantiate(loadAsset) as GameObject;
        setposition(go1);
        Getrender(go1);
        GetChildmesh(go1);
        GetCollision(go1);
        ADDtag(go1);
        Getclickapp(go1);
        rotationaxis(go1);
        grabbable(go1);
        Manipulator(go1);

        addobjname(go1);
        Cursorcontext(go1);
        SplitList(go1);
        go1.transform.parent = GameObject.Find("ModelManager").transform;
        if ( GameObject.Find("1fv1(Clone)")!=null)
              {
            go1.transform.parent = GameObject.Find("1fv1(Clone)").transform;
        }
        ModelMaganer.Loadobj = 2;
    }
    public void getbuttomdown()
    {
        if (pipeline_1f.Equals(false))
        {

            StartCoroutine(getmodelfromazure());
            pipeline_1f = true;
        }
        else if (pipeline_1f.Equals(true))
        {
            pipeline_1f = false;
            Destroy(go1);
        }
    }

    public void ADDtag(GameObject s)
    {
        foreach (Transform child in s.transform)
        {

            if (child.gameObject.tag.Equals("pipe"))
            {
            }
            else
            {
                child.gameObject.tag="pipe";
            }
            ADDtag(child.gameObject);
        }

    }
    public void setposition(GameObject BIM123)
    {
        BIM123.transform.position = new Vector3(x, y, z);
        BIM123.transform.localScale = new Vector3(1f, 1f, 1f);
        BIM123.transform.localRotation = Quaternion.Euler(0f, 270f, 0f);
        //Status.text = "已移動";
        Debug.Log("OK");
    }
    public void setpositionin(GameObject BIM123)
    {
        BIM123.transform.position = new Vector3(x1, y1, z1);
        //Status.text = "已移動";
        Debug.Log("OK");
    }
    public void ADDrigin(GameObject wwwwwwww)
    {
        if (null == wwwwwwww)
            return;

        foreach (Transform child in wwwwwwww.transform)
        {
            if (null == child)
                continue;
            if (child.gameObject.GetComponent<Rigidbody>().Equals(true))
            {
                child.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                child.gameObject.GetComponent<Rigidbody>().useGravity = false;
            }
            else
            {
                child.gameObject.AddComponent<Rigidbody>();
                child.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                child.gameObject.GetComponent<Rigidbody>().useGravity = false;

            }
            ADDrigin(child.gameObject);
        }

    }


    public void MinMaxScale(GameObject wwwwwww)
    {
        foreach (Transform child in wwwwwww.transform)
        {
            if (child == null)
                continue;
            if (child.gameObject.GetComponent<MinMaxScaleConstraint>().Equals(true))
            {
                child.gameObject.GetComponent<MinMaxScaleConstraint>().enabled = false;

            }
            else
            {
                child.gameObject.AddComponent<MinMaxScaleConstraint>();
                child.gameObject.GetComponent<MinMaxScaleConstraint>().enabled = false;
            }
            MinMaxScale(child.gameObject);
        }
    }
 
    public void Cursorcontext(GameObject ww)
    {
        if (null == ww)
            return;

        foreach (Transform child in ww.transform)
        {

                child.gameObject.AddComponent<CursorContextObjectManipulator>();

            
            Cursorcontext(child.gameObject);
        }
            
    }
    public void Manipulator(GameObject www)
        {

            if (null == www)
                return;

            foreach (Transform child in www.transform)
            {
 
            child.gameObject.gameObject.AddComponent<ObjectManipulator>();
            child.gameObject.gameObject.GetComponent<ObjectManipulator>().enabled=false;

                Manipulator(child.gameObject);

            }
        }
    public void rotationaxis(GameObject wwww)
    {

            foreach (Transform child in wwww.transform)
            {


                child.gameObject.gameObject.AddComponent<RotationAxisConstraint>();
            
               rotationaxis(child.gameObject);
            }
        
    }
    public void addobjname(GameObject gg)
    {

        foreach (Transform child in gg.transform)
        {
            if (child.gameObject.GetComponent<objnamesplit>())
            { }
            else
            {
                child.gameObject.gameObject.AddComponent<objnamesplit>();
            }

            addobjname(child.gameObject);

        }
    }
    public void SplitList(GameObject mdll)//拆分場景名字
    {
        string[] elementid;
        string[] stringSeparators = new string[] { "[", "]" };
        foreach (Transform objectt in mdll.transform)
        {
            if (objectt == null)
            {
                continue;
            }
            if (objectt.gameObject.name != "qrimage" )
            {
                elementid = objectt.name.Split(stringSeparators, StringSplitOptions.None);
                objectt.name = elementid[1];

                objectt.GetComponent<objnamesplit>().objname = elementid[0];
                Debug.Log("有嗎有嗎");
                pipename.Add(elementid[0]);
                pipenum.Add(elementid[1]);
            }
            SplitList(objectt.gameObject);
        }
    }
    public void Getrender(GameObject gameObject1234)
    {
        foreach (Transform child in gameObject1234.transform)
        {
            if (null == child)
                continue;
            if (child.gameObject.GetComponent<MeshRenderer>())
            {
                child.gameObject.GetComponent<MeshRenderer>().material = Resources.Load<Material>("bluepipe");
            }
            else if (child.gameObject.GetComponent<MeshRenderer>().Equals(false))
            {
                child.gameObject.AddComponent<MeshRenderer>();

            }
            Getrender(child.gameObject);

        }


    }
    public void GetChildmesh(GameObject gameObject123)
    {
        if (null == gameObject123)
            return;

        foreach (Transform child in gameObject123.transform)
        {
            if (null == child)
                continue;
            if (child.name != "qrimage")
            {
                if (child.gameObject.GetComponent<MeshCollider>())
                { }
                else
                {
                    child.gameObject.AddComponent<MeshCollider>();
                }
            }
            GetChildmesh(child.gameObject);

        }


    }
    public void grabbable(GameObject wwwwww)
    {
        if (null == wwwwww)
            return;

        foreach (Transform child in wwwwww.transform)
        {
            if (null == child)
                continue;
            if (child.gameObject.GetComponent<NearInteractionGrabbable>())
            {
                child.gameObject.GetComponent<NearInteractionGrabbable>().enabled = false;

            }
            else
            {
                child.gameObject.AddComponent<NearInteractionGrabbable>();
                child.gameObject.GetComponent<NearInteractionGrabbable>().enabled = false;
            }
            grabbable(child.gameObject);
        }

    }
    public void GetCollision(GameObject gameObject123)
    {
        if (null == gameObject123)
            return;

        foreach (Transform child in gameObject123.transform)
        {
            if (null == child)
                continue;
            if (child.gameObject.GetComponent<collisionwall>())
            {
            }
            else
            {
                child.gameObject.AddComponent<collisionwall>();

            }
            GetCollision(child.gameObject);

        }


    }
    public void Getclickapp(GameObject gameObject456)
    {
        if (null == gameObject456)
            return;

        foreach (Transform child in gameObject456.transform)
        {
            if (null == child)
                continue;
            if (child.gameObject.GetComponent<pointerevent>())
            {
            }
            else
            {
                child.gameObject.AddComponent<pointerevent>();

            }
            Getclickapp(child.gameObject);

        }


    }

}
