using UnityEngine;

interface IInput
{
	Vector2 GetDir();
	Vector3 GetRot();
	bool GetFlash();
	bool GetAct();
	bool GetCamReset();
	bool GetPause();
}