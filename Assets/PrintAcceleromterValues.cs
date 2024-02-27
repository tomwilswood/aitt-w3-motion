using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PrintAcceleromterValues : MonoBehaviour
{

    TextMeshProUGUI xValueText;
    TextMeshProUGUI yValueText;
    TextMeshProUGUI zValueText;

    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;

        xValueText = GameObject.Find("X Value").GetComponent<TextMeshProUGUI>();
        yValueText = GameObject.Find("Y Value").GetComponent<TextMeshProUGUI>();
        zValueText = GameObject.Find("Z Value").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        xValueText.text = Input.acceleration.x.ToString();
        yValueText.text = Input.acceleration.y.ToString();
        zValueText.text = Input.acceleration.z.ToString();
    }
}
