using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterVelocity : MonoBehaviour
{
    public Transform Object; // gameobject
    private Vector3 _position; // last position of target

    private void OnEnable()
    {
        _position = Object.transform.position;
    }

    private void Update()
    {
        var dt = Time.deltaTime;
        var current = Object.transform.position;
        var delta = Vector3.Distance(current, _position);
        var velocity = delta / dt;
        Debug.Log((velocity).ToString("#,##0.000"));

        // replace current position
        _position = current;
    }
}
