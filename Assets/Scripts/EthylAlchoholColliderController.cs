using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EthylAlchoholColliderController : MonoBehaviour {

    public GameObject water;
    public GameObject flame;

    void OnCollisionStay(Collision col)
    {
        if(ActionManager.ShowFirstMenu) return;
        if (col.gameObject.name == "Tap")
        {
			Debug.Log("OnCollisionEnter:" + col.collider.name + " | " + col.gameObject.name);
            //Debug.LogError("OnCollisionEnter");
            ActionManager.Bool_0 = true;
            ActionManager.contents[0].image = ActionManager.Instance.BoxTextureCompleted;
            water.SetActive(true);
        }


        if (col.gameObject.name == "Burner")
        {
            Debug.Log("OnCollisionEnter:" + col.collider.name + " | " + col.gameObject.name);
            //Debug.LogError("OnCollisionEnter");
            ActionManager.Bool_3 = true;
            ActionManager.contents[3].image = ActionManager.Instance.BoxTextureCompleted;
            water.SetActive(false);
            flame.SetActive(false);
        }
    }
}
