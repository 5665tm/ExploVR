using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField] private float _rotateFromKeyboard;
	[SerializeField] private float _tiltFromKeyboard;
	[SerializeField] private Transform _head;

	private void Update()
	{
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(Vector3.down * _rotateFromKeyboard * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Rotate(Vector3.down * ( -_rotateFromKeyboard)  * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.UpArrow))
		{
			_head.Rotate(Vector3.left * _tiltFromKeyboard * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			_head.Rotate(Vector3.left * ( -_tiltFromKeyboard) * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.Space))
		{
			Fire();
		}
	}

	private void Fire()
	{
	}
}