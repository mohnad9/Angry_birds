using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class angry : MonoBehaviour
{
    bool isClicked = false;
    public Rigidbody2D rg;
    public SpringJoint2D sj;

    void Update()
    {
        if (isClicked)
        {
            rg.position =Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }
    private void OnMouseDown()
    {
        isClicked = true;
        rg.isKinematic = true;
    }
    private void OnMouseUp()
    {
        isClicked = false;
        rg.isKinematic = false;

        StartCoroutine(wait());
    
    }
    IEnumerator wait()
    {
        yield return new WaitForSecondsRealtime(0.15f);
        sj.enabled = false;
    }
    
 

}
