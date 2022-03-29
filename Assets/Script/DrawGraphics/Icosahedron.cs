using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vectrosity;

public class Icosahedron : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Isocahedron();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Isocahedron()
    {
        var isoPoints = new List<Vector3>{new Vector3(-0.02f, 0.841f, 0.449f), new Vector3(-0.02f, 0.841f, -0.551f), new Vector3(-0.02f, 0.841f, -0.551f), new Vector3(-0.829f, 0.532f, -0.051f), new Vector3(-0.829f, 0.532f, -0.051f), new Vector3(-0.02f, 0.841f, 0.449f), new Vector3(-0.02f, -0.777f, 0.449f), new Vector3(-0.829f, -0.468f, -0.051f), new Vector3(-0.829f, -0.468f, -0.051f), new Vector3(-0.829f, 0.532f, -0.051f), new Vector3(-0.02f, 0.841f, 0.449f), new Vector3(0.48f, 0.032f, 0.758f), new Vector3(0.48f, 0.032f, 0.758f), new Vector3(-0.02f, -0.777f, 0.449f), new Vector3(-0.02f, -0.777f, 0.449f), new Vector3(-0.02f, -0.777f, -0.551f), new Vector3(-0.02f, -0.777f, -0.551f), new Vector3(0.48f, 0.032f, -0.861f), new Vector3(0.48f, 0.032f, -0.861f), new Vector3(0.789f, 0.532f, -0.051f), new Vector3(0.789f, 0.532f, -0.051f), new Vector3(0.48f, 0.032f, 0.758f), new Vector3(-0.02f, -0.777f, 0.449f), new Vector3(0.789f, -0.468f, -0.051f), new Vector3(0.789f, -0.468f, -0.051f), new Vector3(0.48f, 0.032f, 0.758f), new Vector3(0.48f, 0.032f, 0.758f), new Vector3(-0.52f, 0.032f, 0.758f), new Vector3(-0.52f, 0.032f, 0.758f), new Vector3(-0.02f, -0.777f, 0.449f), new Vector3(-0.52f, 0.032f, 0.758f), new Vector3(-0.829f, -0.468f, -0.051f), new Vector3(-0.829f, -0.468f, -0.051f), new Vector3(-0.02f, -0.777f, -0.551f), new Vector3(-0.02f, -0.777f, -0.551f), new Vector3(0.789f, -0.468f, -0.051f), new Vector3(0.48f, 0.032f, -0.861f), new Vector3(0.789f, -0.468f, -0.051f), new Vector3(-0.52f, 0.032f, -0.861f), new Vector3(0.48f, 0.032f, -0.861f), new Vector3(-0.02f, -0.777f, -0.551f), new Vector3(-0.52f, 0.032f, -0.861f), new Vector3(-0.829f, -0.468f, -0.051f), new Vector3(-0.52f, 0.032f, -0.861f), new Vector3(-0.829f, 0.532f, -0.051f), new Vector3(-0.52f, 0.032f, -0.861f), new Vector3(-0.02f, 0.841f, -0.551f), new Vector3(-0.52f, 0.032f, -0.861f), new Vector3(-0.02f, 0.841f, -0.551f), new Vector3(0.48f, 0.032f, -0.861f), new Vector3(-0.02f, 0.841f, -0.551f), new Vector3(0.789f, 0.532f, -0.051f), new Vector3(0.789f, 0.532f, -0.051f), new Vector3(0.789f, -0.468f, -0.051f), new Vector3(0.789f, 0.532f, -0.051f), new Vector3(-0.02f, 0.841f, 0.449f), new Vector3(-0.02f, 0.841f, 0.449f), new Vector3(-0.52f, 0.032f, 0.758f), new Vector3(-0.829f, 0.532f, -0.051f), new Vector3(-0.52f, 0.032f, 0.758f)};

        // Make a line using the above points, with a width of 2 pixels
        var line = new VectorLine(gameObject.name, isoPoints, 2.0f);

        // Make this transform have the vector line object that's defined above
        // This object is a rigidbody, so the vector object will do exactly what this object does

        VectorManager.useDraw3D = true;
        VectorManager.ObjectSetup(gameObject, line, Visibility.Dynamic, Brightness.None);
    }
}
