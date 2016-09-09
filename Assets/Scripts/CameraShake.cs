using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Camera
{
	public class CameraShake : MonoBehaviour
	{
		private static Vector3 originPosition;
		private static Quaternion originRotation;

		private static CameraShake _instance;

		private static bool _shaked;

		private static float _shakeDuration = 0.65f;
		private static float intensity = 0.05f;

		public void Start()
		{
			_instance = this;
			_shaked = false;
		}

		public static void Shake()
		{
			if (!_shaked)
			{
				_instance.StartCoroutine(_instance.ShakeCoroutine());
			}
		}

		private IEnumerator ShakeCoroutine()
		{
			_shaked = true;
			float time = 0;
			originPosition = transform.localPosition;
			originRotation = transform.localRotation;
			while (time <= _shakeDuration)
			{
				var timeFactor = 1 - time/_shakeDuration;

				Vector3 bias = Random.insideUnitSphere*intensity*timeFactor;

				transform.localPosition = originPosition + bias;

				transform.localRotation = new Quaternion(
					originRotation.x + Random.Range(-intensity, intensity)*timeFactor,
					originRotation.y + Random.Range(-intensity, intensity)*timeFactor,
					originRotation.z + Random.Range(-intensity, intensity)*timeFactor,
					originRotation.w + Random.Range(-intensity, intensity)*timeFactor);

				yield return null;
				time += Time.deltaTime;
			}
			yield return null;
			transform.localPosition = originPosition;
			transform.localRotation = originRotation;
			_shaked = false;
		}
	}
}
