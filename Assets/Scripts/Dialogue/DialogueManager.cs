using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary>
///
///</summary>
public class DialogueManager : MonoBehaviour
{
    [SerializeField] private RectTransform DialogueBackGround;
    [SerializeField] private DialogueContent dialogueContent;
    private Text text;
    private bool isDialogueShowing = false;
    private bool isContenteShowing = false;
    private List<string> contentL;
    private int spaceCount = 0;
    private void Awake()
    {
        DialogueBackGround.gameObject.SetActive(false);
        isDialogueShowing = false;
        text = DialogueBackGround.GetComponentInChildren<Text>();
        text.text = "";
    }

    private void Update()
    {
        if (isContenteShowing)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                createText(contentL, 1);
                isDialogueShowing = true;
                spaceCount++;
                Debug.Log(spaceCount);
            }
        }
        if (isDialogueShowing && spaceCount == 2)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("关闭对话");
                DialogueBackGround.gameObject.SetActive(false);
                isDialogueShowing = false;
                isContenteShowing = false;
                spaceCount = 0;
            }
        }
    }

    public void DialogueJudge(string name)
    {
        Debug.Log(name);
        if(name == "ChuFaDan") {
            contentL = dialogueContent.getChuFaDan();
            contentBegin();
        }
        if (name == "TongZhiShu")
        {
            contentL = dialogueContent.getTongZhiShu();
            contentBegin();
        }
        if (name == "XiaoDao")
        {
            contentL = dialogueContent.getXiaoDao();
            contentBegin();
        }
        if (name == "XiaoGui")
        {
            contentL = dialogueContent.getXiaoGui();
            contentBegin();
        }
        if (name == "SuiPian")
        {
            contentL = dialogueContent.getSuipian();
            contentBegin();
        }
        if (name == "BaoZhi")
        {
            contentL = dialogueContent.getBaoZhi();
            contentBegin();
        }
    }

    private void contentBegin()
    {
        isContenteShowing = true;
        DialogueBackGround.gameObject.SetActive(true);
        createText(contentL, 0);
    }
    private void createText(List<string> contentL, int contenteNum)
    {
        Debug.Log(contentL.Count);
        text.text = contentL[contenteNum];
        Debug.Log(contentL[contenteNum]);
    }
}
