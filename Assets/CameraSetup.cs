using UnityEngine;
using Vuforia;
using System.Collections;

public class CameraSetup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Starting script");
		VuforiaBehaviour.Instance.RegisterVuforiaStartedCallback(OnVuforiaStarted);
		VuforiaBehaviour.Instance.RegisterOnPauseCallback(OnPaused);
	}

	private void OnVuforiaStarted()
	{
		CameraDevice.Instance.SetFocusMode(
			CameraDevice.FocusMode.FOCUS_MODE_MACRO);
	}

	private void OnPaused(bool paused)
	{
		if (!paused) // resumed
		{
			// Set again autofocus mode when app is resumed
			CameraDevice.Instance.SetFocusMode(
				CameraDevice.FocusMode.FOCUS_MODE_MACRO);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
