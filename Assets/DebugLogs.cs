using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DebugLogs : MonoBehaviour
{
    public GameObject TextGO;
    public GameObject LA;
    public GameObject RA;
    private TextMeshPro text;
    // Start is called before the first frame update
    void Start()
    {
        text = TextGO.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        string texts = "";
        texts += "LA Pos:" + LA.transform.position.ToString();
        texts += "LA Rot:" + LA.transform.rotation.ToString();
        texts += "RA Pos:" + RA.transform.position.ToString();
        texts += "RA Rot:" + RA.transform.rotation.ToString();
        text.text = texts;
    }
}
