using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class angry : MonoBehaviour
{
    bool isClicked = false;
    public Rigidbody2D rg;
    public SpringJoint2D sj;
    public GameObject Star;

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
        StartCoroutine(waitAngry());
    }
    IEnumerator wait()
    {
        yield return new WaitForSecondsRealtime(0.15f);
        sj.enabled = false;
    }
    IEnumerator waitAngry()
    {
        yield return new WaitForSecondsRealtime(2f);
        transform.position = Star.transform.position;
        sj.enabled = true;
    }



}
