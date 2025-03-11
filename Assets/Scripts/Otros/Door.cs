//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.Events;

//public class Door : MonoBehaviour
//{

//    [SerializeField]
//    Animator anim;
//    [SerializeField]
//    UnityEvent onEnter;
//    [SerializeField]
//    UnityEvent onExit;
//    [SerializeField]
//    string tagWhoActivate;

//    [SerializeField] GameObject vrCam03;

//    [SerializeField] InventoryManager.AllItems _requiredItem;

//    private void OnTriggerEnter(Collider other)
//    {


//        if (other.tag == tagWhoActivate)
//        {
//            if (HasRequiredItem(_requiredItem))
//            {
//                onEnter.Invoke();
//                //isLocked = false;
//                //canvasToActive.SetActive(true);
//                anim.SetBool("IsOpen", true);
//                //Debug.Log("Has entrado");
//            }

//        }
//    }

//    private void OnTriggerExit(Collider other)
//    {

//        if (other.tag == tagWhoActivate)
//        {
//            onExit.Invoke();
//            //  canvasToActive.SetActive(true);
//            anim.SetBool("IsOpen", false);
//            Debug.Log("Has salido");

//            vrCam03.SetActive(true);
//        }
//    }

//    public bool HasRequiredItem(InventoryManager.AllItems itemRequired)

//    {
//        if (InventoryManager.Instance._inventoryItems.Contains(itemRequired))
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }
//}
