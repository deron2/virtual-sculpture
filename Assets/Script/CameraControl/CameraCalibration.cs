using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class CameraCalibration : MonoBehaviour
{
    private int fov;
    private Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        ReadCameraParameter();
        camera = this.GetComponent<Camera>();
        camera.fieldOfView = fov;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            camera.fieldOfView--;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            camera.fieldOfView++;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveCameraParameters();
        }

    }

    void ReadCameraParameter()
    {
        string path = "Assets/Resources/camera.txt";

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        fov = int.Parse(reader.ReadLine());
        reader.Close();
    }

    void SaveCameraParameters()
    {
        string path = "Assets/Resources/camera.txt";

        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, false);
        writer.WriteLine(camera.fieldOfView);
        writer.Close();

    }
}
