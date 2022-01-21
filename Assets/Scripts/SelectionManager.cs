using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///
///</summary>
public class SelectionManager : MonoBehaviour
{
    [SerializeField] protected string selectableTag = "Objects";
    //[SerializeField] private Material HighLightMaterial;
    //[SerializeField] private Material defaultMaterial;


    [SerializeField] private GameObject pickUpCanvas;
    private Transform selectionTrans;

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
            //var selectionRenderer = selectionTrans.GetComponent<Renderer>();
            //var selectionCanvas = selectionTrans.GetComponentInChildren<Canvas>();
            //selectionCanvas.enabled = false;
            //selectionRenderer.material = defaultMaterial;

            pickUpCanvas.SetActive(false);
            selectionTrans = null;

        }
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            distance = (transform.position - selection.position).sqrMagnitude;
            ItemOnWorld itemOnWorld = hit.transform.GetComponent<ItemOnWorld>();
            if (selection.CompareTag(selectableTag) && distance < 4)
            {
                //var selectionRender = selection.GetComponent<Renderer>();
                //var selectionCanvas = selection.GetComponentInChildren<Canvas>();
                //if (selectionRender != null)
                //{
                //    //selectionCanvas.enabled = true;
                //    //selectionRender.material = HighLightMaterial;
                //}
                if (Input.GetKeyDown(KeyCode.F))
                {
                    itemOnWorld.AddNewItem();
                    selection.gameObject.SetActive(false);
                    //Debug.Log("canPick");
                }
                pickUpCanvas.SetActive(true);
                selectionTrans = selection;
            }
        }
    }
}
