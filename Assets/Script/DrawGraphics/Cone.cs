// See Simple3D 2.js for another way of doing this that uses TextAsset.bytes instead.
// If the vector object doesn't appear, make sure the scene view isn't visible while in play mode
using UnityEngine;
using Vectrosity;
using System.Collections.Generic;

public class Cone : MonoBehaviour {
	void Start () {

        cone(1,2,12);
        //icosahedron();


    }

    void cone(int r, int h, int n)
    {
        var conePoints = new List<Vector3>();

        float fi;

        float dphi = 2*Mathf.PI / n;

        for (fi = 0; fi < 2 * Mathf.PI; fi += dphi)
        {
            conePoints.Add(new Vector3(0, 0, h));
            if (fi != 0)
            {
                conePoints.Add(new Vector3(r * Mathf.Cos(fi - dphi), r * Mathf.Sin(fi - dphi), 0));
                
            }
            conePoints.Add(new Vector3(r * Mathf.Cos(fi), r * Mathf.Sin(fi), 0));
            conePoints.Add(new Vector3(r * Mathf.Cos(fi + dphi), r * Mathf.Sin(fi + dphi), 0));

        }
        var line = new VectorLine(gameObject.name, conePoints, 2.0f);

        VectorManager.useDraw3D = true;
        VectorManager.ObjectSetup(gameObject, line, Visibility.Dynamic, Brightness.None);

    }

}