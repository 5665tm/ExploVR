using UnityEngine;

public class RotatePoint : MonoBehaviour
{
	/// <summary>
	/// Скорость вращения объекта
	/// </summary>
	[SerializeField]
	private float _rotateAnglePerSecond;

	private void Update()
	{
		transform.Rotate(Vector3.up * _rotateAnglePerSecond * Time.deltaTime);
	}
}