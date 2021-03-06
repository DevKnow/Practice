using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorCube : MonoBehaviour
{
	CatmullRomSpline _curve;
	float _tCube = 0f;

	void Start()
	{
		_curve = gameObject.GetComponent<CatmullRomSpline>();
	}

	public void MoveUpdate()
	{
		_tCube += 0.1f * Time.deltaTime; _tCube = _tCube > 1.0f ? 0 : _tCube;
		gameObject.transform.position = _curve.GetSplinePosition(_tCube);
	}
}
