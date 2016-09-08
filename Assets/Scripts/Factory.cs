using UnityEngine;

public class Factory : MonoBehaviour
{
	[SerializeField] private float _timeBetweenCreate;
	[SerializeField] private GameObject _createdObject;
	private float _accumTime;

	private void Update()
	{
		_accumTime -= Time.deltaTime;
		if (_accumTime <= 0)
		{
			_accumTime = _timeBetweenCreate;
			Instantiate(_createdObject, transform.position, transform.rotation);
		}
	}
}