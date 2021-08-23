using MRTKExtensions.QRCodes;
using UnityEngine;
using UnityEngine.UI;

public class JetController : MonoBehaviour
{

    public GameObject triggerObj;
    public GameObject triggerObz;
    public GameObject triggerObj1f;
    public GameObject triggerObj2f;
    public GameObject triggerObj3f;
    public GameObject triggerObj4f;
    public GameObject triggerObj5f;
    public GameObject triggerObj6f;
    public GameObject triggerObj7f;
    public GameObject triggerObj8f;
    public GameObject triggerObj9f;
    public GameObject triggerObj10f;
    public GameObject triggerObj11f;
    public GameObject triggerObjb1f;
    public GameObject triggerObjb2f;
    public GameObject triggerObjrf;
    [SerializeField]
    private QRTrackerController trackerController;
    private QRTrackerController trackerController1;
    private QRTrackerController trackerController1f;
    private QRTrackerController trackerController2f;
    private QRTrackerController trackerController3f;
    private QRTrackerController trackerController4f;
    private QRTrackerController trackerController5f;
    private QRTrackerController trackerController6f;
    private QRTrackerController trackerController7f;
    private QRTrackerController trackerController8f;
    private QRTrackerController trackerController9f;
    private QRTrackerController trackerController10f;
    private QRTrackerController trackerController11f;
    private QRTrackerController trackerControllerb1f;
    private QRTrackerController trackerControllerb2f;
    private QRTrackerController trackerControllerrf;
    public GameObject[] tracker;
    public static Vector3 QRpose;
    public static Vector3 QRposero;
    public Text text;
    public Text text1;
    public int n = 0;
    public int i = 1;
    public GameObject tryyyy;
    //public GameObject Instantiate_Position; //物件的生成點。





    public void Start()
    {
        tracker = GameObject.FindGameObjectsWithTag("tracker");
        for (n = 0; n < tracker.Length; n++)
        {
            //tracker[n].GetComponent<QRTrackerController>().PositionSet += PoseFound;
            if (tracker[n].name == "Tracker1")
            {
                //QRpose = new Vector3(0, 0, 0);
                //QRposero = new Vector3(0, 0, 0);
                trackerController = tracker[n].GetComponent<QRTrackerController>();
                tracker[n].GetComponent<QRTrackerController>().PositionSet += PoseFound;
                Debug.Log(n + "," + QRpose);
            }
            if (tracker[n].name == "Tracker2")
            {
                //QRpose = new Vector3(0, 0, 0);
                //QRposero = new Vector3(0, 0, 0);
                trackerController1 = tracker[n].GetComponent<QRTrackerController>();
                tracker[n].GetComponent<QRTrackerController>().PositionSet += PoseFound;
                Debug.Log(n + "," + QRpose);
            }
            if (tracker[n].name == "Tracker3")
            {
                //QRpose = new Vector3(0, 0, 0);
                //QRposero = new Vector3(0, 0, 0);
                trackerController1f = tracker[n].GetComponent<QRTrackerController>();
                tracker[n].GetComponent<QRTrackerController>().PositionSet += PoseFound;
                Debug.Log(n + "," + QRpose);
            }
            if (tracker[n].name == "Tracker4")
            {
                //QRpose = new Vector3(0, 0, 0);
                //QRposero = new Vector3(0, 0, 0);
                trackerController2f = tracker[n].GetComponent<QRTrackerController>();
                tracker[n].GetComponent<QRTrackerController>().PositionSet += PoseFound;
                Debug.Log(n + "," + QRpose);
            }
            if (tracker[n].name == "Tracker5")
            {
                //QRpose = new Vector3(0, 0, 0);
                //QRposero = new Vector3(0, 0, 0);
                trackerController3f = tracker[n].GetComponent<QRTrackerController>();
                tracker[n].GetComponent<QRTrackerController>().PositionSet += PoseFound;
                Debug.Log(n + "," + QRpose);
            }
            if (tracker[n].name == "Tracker6")
            {
                //QRpose = new Vector3(0, 0, 0);
                //QRposero = new Vector3(0, 0, 0);
                trackerController4f = tracker[n].GetComponent<QRTrackerController>();
                tracker[n].GetComponent<QRTrackerController>().PositionSet += PoseFound;
                Debug.Log(n + "," + QRpose);
            }
            if (tracker[n].name == "Tracker7")
            {
                //QRpose = new Vector3(0, 0, 0);
                //QRposero = new Vector3(0, 0, 0);
                trackerController5f = tracker[n].GetComponent<QRTrackerController>();
                tracker[n].GetComponent<QRTrackerController>().PositionSet += PoseFound;
                Debug.Log(n + "," + QRpose);
            }
            if (tracker[n].name == "Tracker8")
            {
                //QRpose = new Vector3(0, 0, 0);
                //QRposero = new Vector3(0, 0, 0);
                trackerController6f = tracker[n].GetComponent<QRTrackerController>();
                tracker[n].GetComponent<QRTrackerController>().PositionSet += PoseFound;
                Debug.Log(n + "," + QRpose);
            }
            if (tracker[n].name == "Tracker9")
            {
                //QRpose = new Vector3(0, 0, 0);
                //QRposero = new Vector3(0, 0, 0);
                trackerController7f = tracker[n].GetComponent<QRTrackerController>();
                tracker[n].GetComponent<QRTrackerController>().PositionSet += PoseFound;
                Debug.Log(n + "," + QRpose);
            }
            if (tracker[n].name == "Tracker10")
            {
                //QRpose = new Vector3(0, 0, 0);
                //QRposero = new Vector3(0, 0, 0);
                trackerController8f = tracker[n].GetComponent<QRTrackerController>();
                tracker[n].GetComponent<QRTrackerController>().PositionSet += PoseFound;
                Debug.Log(n + "," + QRpose);
            }
            if (tracker[n].name == "Tracker11")
            {
                //QRpose = new Vector3(0, 0, 0);
                //QRposero = new Vector3(0, 0, 0);
                trackerController9f = tracker[n].GetComponent<QRTrackerController>();
                tracker[n].GetComponent<QRTrackerController>().PositionSet += PoseFound;
                Debug.Log(n + "," + QRpose);
            }
            if (tracker[n].name == "Tracker12")
            {
                //QRpose = new Vector3(0, 0, 0);
                //QRposero = new Vector3(0, 0, 0);
                trackerController10f = tracker[n].GetComponent<QRTrackerController>();
                tracker[n].GetComponent<QRTrackerController>().PositionSet += PoseFound;
                Debug.Log(n + "," + QRpose);
            }
            if (tracker[n].name == "Tracker13")
            {
                //QRpose = new Vector3(0, 0, 0);
                //QRposero = new Vector3(0, 0, 0);
                trackerController11f = tracker[n].GetComponent<QRTrackerController>();
                tracker[n].GetComponent<QRTrackerController>().PositionSet += PoseFound;
                Debug.Log(n + "," + QRpose);
            }
            if (tracker[n].name == "Tracker14")
            {
                //QRpose = new Vector3(0, 0, 0);
                //QRposero = new Vector3(0, 0, 0);
                trackerControllerrf = tracker[n].GetComponent<QRTrackerController>();
                tracker[n].GetComponent<QRTrackerController>().PositionSet += PoseFound;
                Debug.Log(n + "," + QRpose);
            }
            if (tracker[n].name == "Tracker15")
            {
                //QRpose = new Vector3(0, 0, 0);
                //QRposero = new Vector3(0, 0, 0);
                trackerControllerb1f = tracker[n].GetComponent<QRTrackerController>();
                tracker[n].GetComponent<QRTrackerController>().PositionSet += PoseFound;
                Debug.Log(n + "," + QRpose);
            }
            if (tracker[n].name == "Tracker16")
            {
                //QRpose = new Vector3(0, 0, 0);
                //QRposero = new Vector3(0, 0, 0);
                trackerControllerb2f = tracker[n].GetComponent<QRTrackerController>();
                tracker[n].GetComponent<QRTrackerController>().PositionSet += PoseFound;
                Debug.Log(n + "," + QRpose);
            }
        }
        /*trackerController = GameObject.Find("Tracker1").GetComponent<QRTrackerController>();
        trackerController1 = GameObject.Find("Tracker2").GetComponent<QRTrackerController>();*/
    }

    public void PoseFound(object sender, Pose pose)
    {

        if (trackerController.IsTrackingActive == false)
        {
            Debug.Log("我要說有沒有找到拉");
            trackerController.IsTrackingActive = true;
            triggerObj = GameObject.Find("triggerObj");
            triggerObj.SendMessage("triggering");
            QRpose = pose.position;
            QRposero = pose.rotation.eulerAngles;
            text.text = (pose.position.x.ToString("#0.000") + "," + pose.position.y.ToString("#0.000") + "," + pose.position.z.ToString("#0.000"));
            text1.text = ("地下管線模型");
            Debug.Log("我應該找到拉");
            //tryyyy.GetComponent<MeshRenderer>().material.color=Color.red;
        }
        if (trackerController1.IsTrackingActive == false)
        {
            trackerController1.IsTrackingActive = true;
            triggerObz = GameObject.Find("triggerObz");
            triggerObz.SendMessage("triggering");
            QRpose = pose.position;
            QRposero = pose.rotation.eulerAngles;
            text.text = (pose.position.x.ToString("#0.000") + "," + pose.position.y.ToString("#0.000") + "," + pose.position.z.ToString("#0.000"));
            text1.text = ("生醫給水模型");
            //tryyyy.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (trackerController1f.IsTrackingActive == false)
        {
            trackerController1f.IsTrackingActive = true;
            triggerObz = GameObject.Find("triggerObj1f");
            triggerObz.SendMessage("triggering");
            QRpose = pose.position;
            QRposero = pose.rotation.eulerAngles;
            text.text = (pose.position.x.ToString("#0.000") + "," + pose.position.y.ToString("#0.000") + "," + pose.position.z.ToString("#0.000"));
            text1.text = ("生醫1F機電模型");
            //tryyyy.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (trackerController2f.IsTrackingActive == false)
        {
            trackerController2f.IsTrackingActive = true;
            triggerObz = GameObject.Find("triggerObj2f");
            triggerObz.SendMessage("triggering");
            QRpose = pose.position;
            QRposero = pose.rotation.eulerAngles;
            text.text = (pose.position.x.ToString("#0.000") + "," + pose.position.y.ToString("#0.000") + "," + pose.position.z.ToString("#0.000"));
            text1.text = ("生醫2F機電模型");
            //tryyyy.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (trackerController3f.IsTrackingActive == false)
        {
            trackerController1f.IsTrackingActive = true;
            triggerObz = GameObject.Find("triggerObj3f");
            triggerObz.SendMessage("triggering");
            QRpose = pose.position;
            QRposero = pose.rotation.eulerAngles;
            text.text = (pose.position.x.ToString("#0.000") + "," + pose.position.y.ToString("#0.000") + "," + pose.position.z.ToString("#0.000"));
            text1.text = ("生醫3F機電模型");
            //tryyyy.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (trackerController4f.IsTrackingActive == false)
        {
            trackerController4f.IsTrackingActive = true;
            triggerObz = GameObject.Find("triggerObj4f");
            triggerObz.SendMessage("triggering");
            QRpose = pose.position;
            QRposero = pose.rotation.eulerAngles;
            text.text = (pose.position.x.ToString("#0.000") + "," + pose.position.y.ToString("#0.000") + "," + pose.position.z.ToString("#0.000"));
            text1.text = ("生醫4F機電模型");
            //tryyyy.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (trackerController5f.IsTrackingActive == false)
        {
            trackerController5f.IsTrackingActive = true;
            triggerObz = GameObject.Find("triggerObj5f");
            triggerObz.SendMessage("triggering");
            QRpose = pose.position;
            QRposero = pose.rotation.eulerAngles;
            text.text = (pose.position.x.ToString("#0.000") + "," + pose.position.y.ToString("#0.000") + "," + pose.position.z.ToString("#0.000"));
            text1.text = ("生醫5F機電模型");
            //tryyyy.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (trackerController6f.IsTrackingActive == false)
        {
            trackerController6f.IsTrackingActive = true;
            triggerObz = GameObject.Find("triggerObj6f");
            triggerObz.SendMessage("triggering");
            QRpose = pose.position;
            QRposero = pose.rotation.eulerAngles;
            text.text = (pose.position.x.ToString("#0.000") + "," + pose.position.y.ToString("#0.000") + "," + pose.position.z.ToString("#0.000"));
            text1.text = ("生醫6F機電模型");
            //tryyyy.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (trackerController7f.IsTrackingActive == false)
        {
            trackerController7f.IsTrackingActive = true;
            triggerObz = GameObject.Find("triggerObj7f");
            triggerObz.SendMessage("triggering");
            QRpose = pose.position;
            QRposero = pose.rotation.eulerAngles;
            text.text = (pose.position.x.ToString("#0.000") + "," + pose.position.y.ToString("#0.000") + "," + pose.position.z.ToString("#0.000"));
            text1.text = ("生醫7F機電模型");
            //tryyyy.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (trackerController8f.IsTrackingActive == false)
        {
            trackerController8f.IsTrackingActive = true;
            triggerObz = GameObject.Find("triggerObj8f");
            triggerObz.SendMessage("triggering");
            QRpose = pose.position;
            QRposero = pose.rotation.eulerAngles;
            text.text = (pose.position.x.ToString("#0.000") + "," + pose.position.y.ToString("#0.000") + "," + pose.position.z.ToString("#0.000"));
            text1.text = ("生醫8F機電模型");
            //tryyyy.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (trackerController9f.IsTrackingActive == false)
        {
            trackerController1f.IsTrackingActive = true;
            triggerObz = GameObject.Find("triggerObj9f");
            triggerObz.SendMessage("triggering");
            QRpose = pose.position;
            QRposero = pose.rotation.eulerAngles;
            text.text = (pose.position.x.ToString("#0.000") + "," + pose.position.y.ToString("#0.000") + "," + pose.position.z.ToString("#0.000"));
            text1.text = ("生醫9F機電模型");
            //tryyyy.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (trackerController10f.IsTrackingActive == false)
        {
            trackerController10f.IsTrackingActive = true;
            triggerObz = GameObject.Find("triggerObj10f");
            triggerObz.SendMessage("triggering");
            QRpose = pose.position;
            QRposero = pose.rotation.eulerAngles;
            text.text = (pose.position.x.ToString("#0.000") + "," + pose.position.y.ToString("#0.000") + "," + pose.position.z.ToString("#0.000"));
            text1.text = ("生醫10F機電模型");
            //tryyyy.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (trackerController11f.IsTrackingActive == false)
        {
            trackerController11f.IsTrackingActive = true;
            triggerObz = GameObject.Find("triggerObj11f");
            triggerObz.SendMessage("triggering");
            QRpose = pose.position;
            QRposero = pose.rotation.eulerAngles;
            text.text = (pose.position.x.ToString("#0.000") + "," + pose.position.y.ToString("#0.000") + "," + pose.position.z.ToString("#0.000"));
            text1.text = ("生醫11F機電模型");
            //tryyyy.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (trackerControllerb1f.IsTrackingActive == false)
        {
            trackerControllerb1f.IsTrackingActive = true;
            triggerObz = GameObject.Find("triggerObjB1f");
            triggerObz.SendMessage("triggering");
            QRpose = pose.position;
            QRposero = pose.rotation.eulerAngles;
            text.text = (pose.position.x.ToString("#0.000") + "," + pose.position.y.ToString("#0.000") + "," + pose.position.z.ToString("#0.000"));
            text1.text = ("生醫B1F機電模型");
            //tryyyy.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (trackerControllerb2f.IsTrackingActive == false)
        {
            trackerControllerb2f.IsTrackingActive = true;
            triggerObz = GameObject.Find("triggerObjB2f");
            triggerObz.SendMessage("triggering");
            QRpose = pose.position;
            QRposero = pose.rotation.eulerAngles;
            text.text = (pose.position.x.ToString("#0.000") + "," + pose.position.y.ToString("#0.000") + "," + pose.position.z.ToString("#0.000"));
            text1.text = ("生醫B2F機電模型");
            //tryyyy.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (trackerControllerrf.IsTrackingActive == false)
        {
            trackerControllerrf.IsTrackingActive = true;
            triggerObz = GameObject.Find("triggerObjRf");
            triggerObz.SendMessage("triggering");
            QRpose = pose.position;
            QRposero = pose.rotation.eulerAngles;
            text.text = (pose.position.x.ToString("#0.000") + "," + pose.position.y.ToString("#0.000") + "," + pose.position.z.ToString("#0.000"));
            text1.text = ("生醫RF機電模型");
            //tryyyy.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        GameObject.Find("Tracker1").SendMessage("BEResetTracking");
        GameObject.Find("Tracker2").SendMessage("BEResetTracking");
        GameObject.Find("Tracker3").SendMessage("BEResetTracking");
        GameObject.Find("Tracker4").SendMessage("BEResetTracking");
        GameObject.Find("Tracker5").SendMessage("BEResetTracking");
        GameObject.Find("Tracker6").SendMessage("BEResetTracking");
        GameObject.Find("Tracker7").SendMessage("BEResetTracking");
        GameObject.Find("Tracker8").SendMessage("BEResetTracking");
        GameObject.Find("Tracker9").SendMessage("BEResetTracking");
        GameObject.Find("Tracker10").SendMessage("BEResetTracking");
        GameObject.Find("Tracker11").SendMessage("BEResetTracking");
        GameObject.Find("Tracker12").SendMessage("BEResetTracking");
        GameObject.Find("Tracker13").SendMessage("BEResetTracking");
        GameObject.Find("Tracker14").SendMessage("BEResetTracking");
        GameObject.Find("Tracker15").SendMessage("BEResetTracking");
        GameObject.Find("Tracker16").SendMessage("BEResetTracking");
        Debug.Log(QRposero);
        GameObject PointA = Instantiate(GameObject.Find("po3").gameObject);
        GameObject PointC = Instantiate(GameObject.Find("po3").gameObject);
        PointA.transform.position = QRpose + new Vector3(0.05f, 0.05f, 0f);
        PointC.transform.position = QRpose + new Vector3(-0.05f, -0.05f, 0f);

    }
}