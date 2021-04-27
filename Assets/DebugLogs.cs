using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using VRTK;

public class DebugLogs : MonoBehaviour
{
    public GameObject TextGO;
    public GameObject LA;
    public GameObject RA;
    private TextMeshPro text;
    StringBuilder logs=new StringBuilder();
    public VRTK_ControllerEvents controllerEvents;
    // Start is called before the first frame update
    void Start()
    {
        Application.logMessageReceived += HandleLog;
        text = TextGO.GetComponent<TextMeshPro>();
        controllerEvents.ButtonTwoPressed += DoButtonTwoPressed;
    }
    void HandleLog(string condition, string stackTrace, LogType type)
    {
        logs.Append(type.ToString()+":");
        logs.Append(condition + "\n");
        switch (type)
        {
            case LogType.Assert:
                break;
            case LogType.Error:
                break;
            case LogType.Log:
                break;
            case LogType.Exception:
                break;
            case LogType.Warning:
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        text.text = logs.ToString();
    }
    private void DoButtonTwoPressed(object sender, ControllerInteractionEventArgs e)
    {
        text.text = "";
    }

}
