using UnityEngine;

public class RotatePoint : MonoBehaviour
{
	[SerializeField] private float _rotateAnglePerSecond;

	private void Update()
	{
		transform.Rotate(Vector3.up * _rotateAnglePerSecond * Time.deltaTime);
	}
}