using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///
///</summary>
public class SelectionManager : MonoBehaviour
{
    [SerializeField] protected string selectableTag = "Objects";


    [SerializeField] private GameObject pickUpCanvas;
    private Transform selectionTrans;
    public DialogueManager dialogueManager;

    private bool hasKey = false;
    private bool hasTape = false;
    public InventoryManager instance;
    private int keyTime = 1;
    private int tapeTime = 1;

    public GameObject ChuFaDan;
    public GameObject TongZhiShu;
    public GameObject XiaoDao;
    public GameObject XiaoGui;
    public GameObject SuiPian;
    public GameObject BaoZhi;
    public GameObject YuZhang;
    private bool showImage = false;

    protected bool isIntrigger = false;
    private void Start()
    {
        pickUpCanvas.SetActive(false);
    }
    private void Update()
    {
        float distance = 10000;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (selectionTrans != null)
        {
            pickUpCanvas.SetActive(false);
            selectionTrans = null;

        }
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            distance = (transform.position - selection.position).sqrMagnitude;
            ItemOnWorld itemOnWorld = hit.transform.GetComponent<ItemOnWorld>();
            if (selection.CompareTag(selectableTag) && distance < 4)//the object can be operated
            {

                if (Input.GetKeyDown(KeyCode.F))
                {

                    if (selection.gameObject.name == "key" && keyTime == 1)
                    {
                        itemOnWorld.AddNewItem();
                        selection.gameObject.SetActive(false);
                        hasKey = true;
                        keyTime = keyTime - 1;
                    }
                    if (selection.gameObject.name == "tape" && tapeTime == 1)
                    {
                        itemOnWorld.AddNewItem();
                        selection.gameObject.SetActive(false);
                        hasTape = true;
                        tapeTime = tapeTime - 1;

                    }
                    else
                    {
                        showImage = !showImage;
                        Debug.Log(selection.gameObject.name);
                        if (selection.gameObject.name == "ChuFaDan")
                        {
                            ChuFaDan.SetActive(showImage);
                        }
                        if (selection.gameObject.name == "TongZhiShu")
                        {
                            TongZhiShu.SetActive(showImage);
                        }
                        if (selection.gameObject.name == "XiaoDao")
                        {
                            XiaoDao.SetActive(showImage);
                        }
                        if (selection.gameObject.name == "XiaoGui")
                        {
                            XiaoGui.SetActive(showImage);
                        }
                        if (selection.gameObject.name == "SuiPian")
                        {
                            SuiPian.SetActive(showImage);
                        }
                        if (selection.gameObject.name == "BaoZhi")
                        {
                            BaoZhi.SetActive(showImage);
                        }
                        if (selection.gameObject.name == "YuZhang")
                        {
                            YuZhang.SetActive(showImage);
                        }
                    }

                }
                pickUpCanvas.SetActive(true);
                DialogueTrigger(selection.name);
                selectionTrans = selection;
            }
            //消耗掉钥匙并开门
            if (Input.GetKeyDown(KeyCode.G) && hasKey == true)
            {
                hasKey = false;
                //Debug.Log("OpenDoor");
                BasicDoor.inTrigger = true;//用钥匙开门
                                           //selection.gameObject.SetActive(false);
                                           //InventoryManager.deleteItem("key");//暂时还不能正确delete
            }
        }
    }


    private void DialogueTrigger(string name)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            dialogueManager.DialogueJudge(name);
        }
    }
}
