using UnityEngine;

public class RotateAroundXYZ : MonoBehaviour {

	public float rotateSpeed = 10.0f;
	
	void Update () {
		transform.Rotate (new Vector3(1,1,1) * Time.deltaTime * rotateSpeed);
	}
}