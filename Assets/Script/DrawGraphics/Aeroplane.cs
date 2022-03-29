// See Simple3D 2.js for another way of doing this that uses TextAsset.bytes instead.
// If the vector object doesn't appear, make sure the scene view isn't visible while in play mode
using UnityEngine;
using Vectrosity;
using System.Collections.Generic;

public class Aeroplane : MonoBehaviour {
	void Start () {
		// Make a Vector3 array that contains points for a cube that's 1 unit in size
		var cubePoints = new List<Vector3>{
new Vector3 (   0   ,   0   ,   0       ),
new Vector3 (   0   ,   0.5f,   0       ),
new Vector3 (   0   ,   0   ,   0       ),
new Vector3 (   0.7f,   0   ,   0       ),
new Vector3 (   0   ,   0   ,   0       ),
new Vector3 (   0.1f,   -0.2f,  1       ),
new Vector3 (   0.7f,   0   ,   0       ),
new Vector3 (   0.7f,   0.5f,   0       ),
new Vector3 (   0.7f,   0   ,   0       ),
new Vector3 (   0.8f,   -0.2f,  1       ),
new Vector3 (   0   ,   0.5f,   0       ),
new Vector3 (   0.1f,   0.6f,   1       ),
new Vector3 (   0.7f,   0.5f,   0       ),
new Vector3 (   0.8f,   0.6f,   1       ),
new Vector3 (   0.1f,   -0.2f,  1       ),
new Vector3 (   0.8f,   -0.2f,  1       ),
new Vector3 (   0.8f,   0.6f,   1       ),
new Vector3 (   0.1f,   0.6f,   1       ),
new Vector3 (   0.1f,   0.6f,   1       ),
new Vector3 (   0.1f,   0.8f,   1.3f    ),
new Vector3 (   0.8f,   0.6f,   1       ),
new Vector3 (   0.8f,   0.8f,   1.3f    ),
new Vector3 (   0   ,   0.5f,   0       ),
new Vector3 (   0.7f,   0.5f,   0       ),
new Vector3 (   0.1f,   0.8f,   1.3f    ),
new Vector3 (   0.8f,   0.8f,   1.3f    ),
new Vector3 (   0.1f,   -0.2f,  1       ),
new Vector3 (   0.1f ,   -0.2f,  2f  ),
new Vector3 (   0.8f,   -0.2f,  1       ),
new Vector3 (   0.8f,   -0.2f,  2f  ),
new Vector3 (   0.1f,   -0.2f,  2f  ),
new Vector3 (   0.5f,   0.6f,   3       ),
new Vector3 (   0.8f,   -0.2f,  2f  ),
new Vector3 (   0.5f,   0.6f,   3       ),
new Vector3 (   0.5f,   0.6f,   3       ),
new Vector3 (   0.5f,   1   ,   3.1f    ),
new Vector3 (   0.5f,   1   ,   3.1f    ),
new Vector3 (   0.5f,   1   ,   3       ),
new Vector3 (   0.5f,   1   ,   3       ),
new Vector3 (   0.5f,   0.6f,   2.8f    ),
new Vector3 (   0.5f,   0.6f,   3f  ),
new Vector3 (   0   ,   0.6f,   3f  ),
new Vector3 (   0   ,   0.6f,   3       ),
new Vector3 (   0   ,   0.6f,   2.8f    ),
new Vector3 (   0.5f,   0.6f,   2.8f    ),
new Vector3 (   0   ,   0.6f,   2.8f    ),
new Vector3 (   0.5f,   0.6f,   3       ),
new Vector3 (   1   ,   0.6f,   3       ),
new Vector3 (   1   ,   0.6f,   3       ),
new Vector3 (   1   ,   0.6f,   2.8f    ),
new Vector3 (   0.5f,   0.6f,   3       ),
new Vector3 (   1   ,   0.6f,   3       ),
new Vector3 (   0.8f,   0.8f,   1.3f    ),
new Vector3 (   0.1f,   0.8f,   1.3f    ),
new Vector3 (   0.1f,   0.8f,   1.3f    ),
new Vector3 (   0.1f ,   0.8f,      2       ),
new Vector3 (   0.8f,   0.8f,   1.3f    ),
new Vector3 (   0.8f ,   0.8f,      2       ),
new Vector3 (   0.1f,   0.8f,   1.3f    ),
new Vector3 (   -3  ,   0.8f,   1.3f    ),
new Vector3 (   -3  ,   0.8f,   1.3f    ),
new Vector3 (   -3  ,   0.8f,   2       ),
new Vector3 (   -3  ,   0.8f,   2       ),
new Vector3 (   0.1f,   0.8f,   2f  ),
new Vector3 (   0.8f,   0.8f,   1.3f    ),
new Vector3 (   4.1f,   0.8f,   1.3f    ),
new Vector3 (   4.1f,   0.8f,   1.3f    ),
new Vector3 (   4.1f,   0.8f,   2f  ),
new Vector3 (   4.1f,   0.8f,   2f  ),
new Vector3 (   0.8f,   0.8f,   2       ),
new Vector3 (   0.5f,   0.6f,   2.8f    ),
new Vector3 (   1   ,   0.6f,   2.8f    ),
new Vector3 (   0.1f,   0.8f,   1.3f    ),
new Vector3 (   0.1f,   0.8f,   2       ),
new Vector3 (   0.8f,   0.8f,   2       ),
new Vector3 (   0.8f,   0.8f,   1.3f    ),
new Vector3 (   0.8f ,   0.8f,        2       ),
new Vector3 (   0.5f ,   0.6f ,   2.8f    ),
new Vector3 (   0.1f ,   0.8f,        2       ),
new Vector3 (   0.5f ,   0.6f ,   2.8f       )


        };
		
		// Make a line using the above points, with a width of 2 pixels
		var line = new VectorLine(gameObject.name, cubePoints, 2.0f);
		
		// Make this transform have the vector line object that's defined above
		// This object is a rigidbody, so the vector object will do exactly what this object does
		VectorManager.ObjectSetup (gameObject, line, Visibility.Always, Brightness.None);
        VectorManager.useDraw3D = true;

    }
}