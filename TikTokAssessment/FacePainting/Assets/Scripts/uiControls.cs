using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiControls : MonoBehaviour
{
    public GameObject brushObject;
    public GameObject selectorIcon;
    public GameObject[] buttons;
    public GameObject textInst;
    // Start is called before the first frame update
    void Start()
    {
        brushObject.GetComponent<LineRenderer>().startColor = Color.red;
        brushObject.GetComponent<LineRenderer>().endColor = Color.red;
        brushObject.GetComponent<LineRenderer>().startWidth = 0.01f;
        selectorIcon.transform.position = buttons[0].transform.position;
        StartCoroutine(textInfo());
        textInst.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeToRed()
    {
        brushObject.GetComponent<LineRenderer>().startColor = Color.red;
        brushObject.GetComponent<LineRenderer>().endColor = Color.red;
        brushObject.GetComponent<LineRenderer>().startWidth = 0.01f;
        selectorIcon.transform.position = buttons[0].transform.position;
    }


    public void changeToGreen()
    {
        brushObject.GetComponent<LineRenderer>().startColor = Color.green;
        brushObject.GetComponent<LineRenderer>().endColor = Color.green;
        brushObject.GetComponent<LineRenderer>().startWidth = 0.01f;
        selectorIcon.transform.position = buttons[1].transform.position;
    }

    public void changeToBlue()
    {
        brushObject.GetComponent<LineRenderer>().startColor = Color.blue;
        brushObject.GetComponent<LineRenderer>().endColor = Color.blue;
        brushObject.GetComponent<LineRenderer>().startWidth = 0.01f;
        selectorIcon.transform.position = buttons[2].transform.position;
    }

    public void changeToYellow()
    {
        brushObject.GetComponent<LineRenderer>().startColor = Color.yellow;
        brushObject.GetComponent<LineRenderer>().endColor = Color.yellow;
        brushObject.GetComponent<LineRenderer>().startWidth = 0.01f;
        selectorIcon.transform.position = buttons[3].transform.position;
    }

    public void changeToWhite()
    {
        brushObject.GetComponent<LineRenderer>().startColor = Color.white;
        brushObject.GetComponent<LineRenderer>().endColor = Color.white;
        brushObject.GetComponent<LineRenderer>().startWidth = 0.1f;
        selectorIcon.transform.position = buttons[4].transform.position;
    }
  
    IEnumerator textInfo()
    {
        yield return new WaitForSeconds(5);
        {
            textInst.SetActive(false);
        }
    }
}
