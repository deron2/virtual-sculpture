using UnityEngine;

public class RotateAroundXY : MonoBehaviour {

	public float rotateSpeed = 10.0f;
	
	void Update () {
		transform.Rotate (new Vector3(1,1,0) * Time.deltaTime * rotateSpeed);
	}
}