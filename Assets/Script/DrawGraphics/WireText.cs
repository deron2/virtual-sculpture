using UnityEngine;
using Vectrosity;
using System.Collections.Generic;

public class WireText : MonoBehaviour {

	public string text = "Vectrosity!";
	public int textSize = 40;
	private VectorLine textLine;
	
	void Start () {
		textLine = new VectorLine("Text", new List<Vector3>(), 2.0f);
		textLine.drawTransform = transform;
		textLine.MakeText (text, this.transform.position,6.0f);

    }

    void Update () {
        textLine.Draw3D();

    }
}