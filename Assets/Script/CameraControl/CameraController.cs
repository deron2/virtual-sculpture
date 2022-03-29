using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject SerialDataProvider;

    public float center = 50;
    public float horizontalRange = 300;
    public float horizontaDataRange = 100;
    public float tiltRange = 30;
    public float tiltInputDataRange = 50;

    private SerialPortDataReceiver paddleData;
    private Quaternion prevRotation;
    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        paddleData = SerialDataProvider.GetComponent<SerialPortDataReceiver>();    }

    // Update is called once per frame
    void Update()
    {
        float horizontalData = paddleData.getPaddleDateHorizontal();
        float verticalDate = paddleData.getPaddleDateVertical();

        float rotationX = (verticalDate - center)*tiltRange/tiltInputDataRange;
        //Debug.Log(rotationX);
        float rotationY = -(horizontalData - center) * horizontalRange/horizontaDataRange;
        Quaternion newRotation = Quaternion.Euler(rotationX, rotationY, 0);
        transform.rotation = Quaternion.Lerp(prevRotation, newRotation, 0.03f);
        prevRotation = newRotation;   
    }
}
