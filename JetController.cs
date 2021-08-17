using MRTKExtensions.QRCodes;
using UnityEngine;
using UnityEngine.UI;

public class JetController : MonoBehaviour
{

    public GameObject triggerObj;
    public GameObject triggerObz;
    public GameObject triggerObj1f;
    [SerializeField]
    private QRTrackerController trackerController;
    private QRTrackerController trackerController1;
    private QRTrackerController trackerController1f;
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
        text = GameObject.Find("Text").GetComponent<Text>();
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
                Debug.Log(n+","+ QRpose);
            }
            if (tracker[n].name == "Tracker2")
            {
                //QRpose = new Vector3(0, 0, 0);
                //QRposero = new Vector3(0, 0, 0);
                trackerController1 = tracker[n].GetComponent<QRTrackerController>();
                tracker[n].GetComponent<QRTrackerController>().PositionSet += PoseFound;
                Debug.Log(n + "," +QRpose);
            }
            if (tracker[n].name == "Tracker3")
            {
                //QRpose = new Vector3(0, 0, 0);
                //QRposero = new Vector3(0, 0, 0);
                trackerController1f = tracker[n].GetComponent<QRTrackerController>();
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
            trackerController.IsTrackingActive = true;
            triggerObj = GameObject.Find("triggerObj");
            triggerObj.SendMessage("triggering"); 
            QRpose = pose.position;
            QRposero = pose.rotation.eulerAngles;
            text.text = (pose.position.x.ToString("#0.000") +","+pose.position.y.ToString("#0.000") +","+ pose.position.z.ToString("#0.000") );
            text1.text = ("地下管線模型");
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
            trackerController1.IsTrackingActive = true;
            triggerObz = GameObject.Find("triggerObj1f");
            triggerObz.SendMessage("triggering");
            QRpose = pose.position;
            QRposero = pose.rotation.eulerAngles;
            text.text = (pose.position.x.ToString("#0.000") + "," + pose.position.y.ToString("#0.000") + "," + pose.position.z.ToString("#0.000"));
            text1.text = ("生醫1F機電模型");
            //tryyyy.GetComponent<MeshRenderer>().material.color = Color.blue;
        }


        GameObject.Find("Tracker1").SendMessage("BEResetTracking");
        GameObject.Find("Tracker2").SendMessage("BEResetTracking");
        GameObject.Find("Tracker3").SendMessage("BEResetTracking");
        Debug.Log(QRposero);
            GameObject PointA = Instantiate(GameObject.Find("po3").gameObject);
            GameObject PointC = Instantiate(GameObject.Find("po3").gameObject);
            PointA.transform.position = QRpose + new Vector3(0.05f, 0.05f, 0f);
            PointC.transform.position = QRpose + new Vector3(-0.05f, -0.05f, 0f);
            //找到"triggerObj"後觸發/執行裡面的"getbuttomdown"函數
            /*  QRloading.go1.gameObject.transform.SetParent(GameObject.Find("JetHolder").transform);
              var childObj = transform.GetChild(0);
              childObj.SetPositionAndRotation(pose.position, pose.rotation);
              childObj.transform.Translate(-3.09f, -1.33f, -1.32f, Space.Self);
              childObj.transform.Rotate(90, 0, 0, Space.Self);

              //pose.position + new Vector3(-3.09f, -1.45f, -0.1f);
              //childObj.transform.Rotate(90, 0, 0);
            */
           
        

        

    }
}