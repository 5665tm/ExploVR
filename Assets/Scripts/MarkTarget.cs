using UnityEngine;

public class MarkTarget : MonoBehaviour
{
	[SerializeField] private float _upSpeedMeterPerSecond;
	[SerializeField] private float _destroyTimeSecond;
	[SerializeField] private GameObject _explosion;

	private void Start()
	{
		Destroy(gameObject, _destroyTimeSecond);
	}

	private void Update()
	{
		transform.Translate(Vector3.up * _upSpeedMeterPerSecond * Time.deltaTime);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.name == "Laser")
		{
			Instantiate(_explosion, transform.position, transform.rotation);
			Destroy(gameObject);
		}
	}
}