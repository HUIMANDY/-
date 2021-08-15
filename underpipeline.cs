using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class underpipeline : MonoBehaviour
{
    // Start is called before the first frame update
    private float x = -3.44f;
    private float y = -1.1f;
    private float z = 1.02f;
    private float x1 = 0;
    private float y1 = 0;
    private float z1 = 0;
    public static GameObject go1;
    public BoundingBox bbox;
    public GameObject mdl;
    public Transform objpipe;
    public bool pipeline_1f = false;
    public static Vector3 QRpose;
    public static bool AimOn = false;
    public GameObject getpipe;
    public Text Pipee;
    public List<string> pipename = new List<string>();
    public List<string> pipenum = new List<string>();
    public MeshFilter meshA;
    public Vector3 LeftTopCornerA;
    public Vector3 Leftposition;
    public Vector3 RightTopCornerA;
    public Vector3 Rightposition;
    public static int i = 0;
    public int Length;
    public float Measureline;
    public float Pipeline;
    /*private void Awake()
    {
        instance = this;
    }*/
    public IEnumerator getmodelfromazure()
    {
        Debug.Log("準備下載");
        yield return new WaitForSeconds(2f);
        var uwr = UnityWebRequestAssetBundle.GetAssetBundle("https://firebasestorage.googleapis.com/v0/b/fir-5e991.appspot.com/o/123123123123?alt=media&token=5d90d046-972c-4bc6-aca5-fb52907e66fd");
        yield return uwr.SendWebRequest();

        // Get an asset from the bundle and instantiate it.
        AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(uwr);
        //var loadAsset = bundle.LoadAssetAsync<GameObject>("Assets/Players/MainPlayer.prefab");
        var loadAsset = bundle.LoadAsset("123123123123");
        yield return loadAsset;
        //Instantiate(loadAsset.asset);
        //Instantiate(loadAsset);
        //if (Instantiate(loadAsset)) = true;
        //yield return new WaitForSeconds(2f);
        go1 = Instantiate(loadAsset) as GameObject;
        Debug.Log(go1.transform.eulerAngles);
        //i++;
        Debug.Log("下載完畢"+i);
        //FGameObject.Find("123123123123(Clone)").name = "123123123123(Clone)" + i;
        /*go1.transform.position = new Vector3(0, 0, 0);
        go1.transform.localScale = new Vector3(1, 1, 1);
        go1.transform.eulerAngles = new Vector3(
            go1.transform.eulerAngles.x*0,
            go1.transform.eulerAngles.y*0 + 90,
            go1.transform.eulerAngles.z*0
        );*/
        go1.transform.parent = GameObject.Find("ModelManager").transform;
        go1.transform.SetAsFirstSibling();
        Debug.Log("有轉啦");
        Getrender(go1);

        GetChildmesh(go1);

        GetCollision(go1);
        ADDtag(go1);
        Getclickapp(go1);
        rotationaxis(go1);
        //grabbable(go1);
        Manipulator(go1);

        addobjname(go1);
        Cursorcontext(go1);
        Debug.Log(renewcolor.Loadmtl);
        renewcolor.Loadmtl = 1;
        Debug.Log(renewcolor.Loadmtl);
        setposition(GameObject.Find("ModelManager"));
        SplitList(go1);


        /*if (GameObject.Find("1fv1(Clone)") != null)
        {
            go1.transform.parent = GameObject.Find("1fv1(Clone)").transform;
        }*/
        ModelMaganer.Loadobj = 2;
    }
    public void planeonoff()
    {
        if (GameObject.Find("Plane").GetComponent<MeshRenderer>().enabled == true)
        {
            GameObject.Find("Plane").GetComponent<MeshRenderer>().enabled = false;
        }
        else
        {
            GameObject.Find("Plane").GetComponent<MeshRenderer>().enabled = true;
        }

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
            //Destroy(go1);
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
                child.gameObject.tag = "pipe";
            }
            ADDtag(child.gameObject);
        }

    }
    public void setposition(GameObject BIM123)
    {
        foreach (Transform BIM1234 in BIM123.transform)
        { 
        BIM1234.transform.position = new Vector3(0, 0, 0);
        BIM1234.transform.localScale = new Vector3(1, 1, 1);
            //BIM1234.transform.localRotation = Quaternion.Euler(x * 0, y*0, z*0);
            BIM1234.transform.rotation = Quaternion.Euler(0, JetController.QRposero.y, 0);
        }
        //Status.text = "已移動";
        Debug.Log("OK");
    }
    public void setpositionin(GameObject BIM123)
    {
        BIM123.transform.position = new Vector3(0, 0, 0);
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
            if (child.name != "qrimage")
            {
                if (child.gameObject.GetComponent<MinMaxScaleConstraint>().Equals(true))
                {
                    child.gameObject.GetComponent<MinMaxScaleConstraint>().enabled = false;

                }
                else
                {
                    child.gameObject.AddComponent<MinMaxScaleConstraint>();
                    child.gameObject.GetComponent<MinMaxScaleConstraint>().enabled = false;
                }
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
            if (child.name != "qrimage")
            {
                child.gameObject.AddComponent<CursorContextObjectManipulator>();
            }

            Cursorcontext(child.gameObject);
        }

    }
    public void Manipulator(GameObject www)
    {

        if (null == www)
            return;

        foreach (Transform child in www.transform)
        {
            if (child.name != "qrimage")
            {
                child.gameObject.gameObject.AddComponent<ObjectManipulator>();
                child.gameObject.gameObject.GetComponent<ObjectManipulator>().enabled = false;
            }
            Manipulator(child.gameObject);

        }
    }
    public void rotationaxis(GameObject wwww)
    {

        foreach (Transform child in wwww.transform)
        {

            if (child.name != "qrimage")
            {
                child.gameObject.gameObject.AddComponent<RotationAxisConstraint>();
            }
            rotationaxis(child.gameObject);
        }

    }
    public void addobjname(GameObject gg)
    {

        foreach (Transform child in gg.transform)
        {
            if (child.name != "qrimage")
            {
                if (child.gameObject.GetComponent<objnamesplit>())
                { }
                else
                {
                    child.gameObject.gameObject.AddComponent<objnamesplit>();
                }
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
            if (objectt.gameObject.name != "qrimage")
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
            if (child.name != "qrimage")
            {
                if (child.gameObject.GetComponent<MeshRenderer>())
                {
                    if (child.name != "Plane")
                    {
                        child.gameObject.GetComponent<MeshRenderer>().material = Resources.Load<Material>("orangepipe");
                    }
                }
                else if (child.gameObject.GetComponent<MeshRenderer>().Equals(false))
                {
                    child.gameObject.AddComponent<MeshRenderer>();

                }
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
    /*public void grabbable(GameObject wwwwww)
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

    }*/
    public void GetCollision(GameObject gameObject123)
    {
        if (null == gameObject123)
            return;

        foreach (Transform child in gameObject123.transform)
        {
            if (null == child)
                continue;
            if (child.name != "qrimage")
            {
                if (child.gameObject.GetComponent<collisionwall>())
                {
                }
                else
                {
                    child.gameObject.AddComponent<collisionwall>();

                }
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
            if (child.name != "qrimage")
            {
                if (child.gameObject.GetComponent<pointerevent>())
                {
                }
                else
                {
                    child.gameObject.AddComponent<pointerevent>();

                }
            }
            Getclickapp(child.gameObject);

        }


    }
        public void aimon()
    {
        if(AimOn.Equals(true))
        {
            AimOn = false;
        }
        else
        {
            AimOn = true;
        }    
    }
  
        public void rull(MixedRealityPointerEventData eventData)
    {
        if (AimOn.Equals(true))
        {
            var result = eventData.Pointer.Result;
            objpipe = result.CurrentPointerTarget.transform;
            if (objpipe.gameObject.tag == "pipe")
            {
                Debug.Log(objpipe.name);
                Pipee.text = objpipe.name;
                Debug.Log(Pipee.text);
            }
        }
    }
    public void rullRight()
    {
        GameObject b = GameObject.Find("forreplace");
        meshA = GameObject.Find(Pipee.text).GetComponent<MeshFilter>();
        Length = meshA.sharedMesh.vertices.Length;
        Debug.Log(Length);
        RightTopCornerA = GameObject.Find(Pipee.text).transform.TransformPoint(meshA.sharedMesh.vertices[50]);
        b.transform.position = RightTopCornerA;
        GameObject.Find(Pipee.text).transform.parent = b.transform;
        Debug.Log(b.transform.position);
    }
    public void rullLeft()
    {
        GameObject b = GameObject.Find("forreplace");
        meshA = GameObject.Find(Pipee.text).GetComponent<MeshFilter>();
        Length = meshA.sharedMesh.vertices.Length;
        LeftTopCornerA = GameObject.Find(Pipee.text).transform.TransformPoint(meshA.sharedMesh.vertices[3]);
        b.transform.position = LeftTopCornerA;
        GameObject.Find(Pipee.text).transform.parent = b.transform;
        Debug.Log(b.transform.position);
    }
    public void addscale()
    {
        GameObject.Find("forreplace").transform.localScale += new Vector3(0.1f, 0, 0);
        lengths();
    }
    public void minusscale()
    {
        GameObject.Find("forreplace").transform.localScale += new Vector3(-0.1f, 0, 0);
        lengths();
    }
    public void backo()
    {
        GameObject.Find("forreplace").transform.localScale= new Vector3(1, 1, 1);
    }
    public void scaleok()
    {
        GameObject.Find(Pipee.text).transform.parent = GameObject.Find("123123123123(Clone)").transform;
        GameObject.Find("forreplace").transform.localScale = new Vector3(1, 1, 1);
        GameObject.Find("forreplace").transform.position = new Vector3(0, 0, 0);
    }
    public void lengths()
    {
        GameObject b = GameObject.Find("forreplace");
        meshA = GameObject.Find(Pipee.text).GetComponent<MeshFilter>();
        Leftposition = GameObject.Find(Pipee.text).transform.TransformPoint(meshA.sharedMesh.vertices[3]);
        Rightposition= GameObject.Find(Pipee.text).transform.TransformPoint(meshA.sharedMesh.vertices[50]);
        Debug.Log("長度=" + ( Rightposition-Leftposition).x*100+"cm");
        Debug.Log("量測長度="+Measure.Distances.ToString("#0.0") + "cm");
        Measureline = Measure.Distances;
        Pipeline = (Rightposition - Leftposition).x * 100;
        Debug.Log((Measureline / Pipeline));

        GameObject.Find("forreplace").transform.localScale = new Vector3((Measureline / Pipeline), 1, 1);

    }
}
