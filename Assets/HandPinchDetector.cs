using System;
using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction.Input;
using UnityEngine;

public class HandPinchDetector : MonoBehaviour
{
    // [SerializeField] private HandPointer handPointer;
    [SerializeField] private OVRHand hand;
    // [SerializeField] private AudioClip pinchSound;
    // [SerializeField] private AudioClip releaseSound;

    [SerializeField] private GameObject cube;

    private bool _hasPinched;
    private bool _isIndexFingerPinching;
    private float _pinchStrenght;
    private bool locked;
    // private OVRHand.TrackingConfidence _confidence;
    private Rigidbody _rigidbody;

    // void Update() => CheckPinch(handPointer.rightHand);
    void Update() {
        // UnityEngine.Debug.Log("kinnnnnnematic" + locked + " " +_rigidbody.isKinematic);
        // if (!locked && _rigidbody.isKinematic) { // unlocked    
        //     UnityEngine.Debug.Log("FORCE APPLIED" + locked + " " +_rigidbody.isKinematic);
        //     _rigidbody.AddForce(10, 10, 10, ForceMode.VelocityChange);
        // }
        if (locked && !_rigidbody.isKinematic) { // unlocked    
            UnityEngine.Debug.Log("FORCE APPLIED opp" + locked + " " +_rigidbody.isKinematic);
            Vector3 shootVel = hand.PointerPose.forward.normalized * 5;
            _rigidbody.AddForce(shootVel, ForceMode.VelocityChange);
        }
        locked = _rigidbody.isKinematic;
    }   

    void CheckPinch(OVRHand hand)
    {

        // _pinchStrenght = hand.GetFingerPinchStrength(OVRHand.HandFinger.Index);
        // _isIndexFingerPinching = hand.GetFingerIsPinching(OVRHand.HandFinger.Index);
        // _confidence = hand.GetFingerConfidence(OVRHand.HandFinger.Index);

        // if (handPointer.CurrentTarget) {
        //     Material currentMaterial = handPointer.CurrentTarget.GetComponent<Renderer>().material;
        //     currentMaterial.SetFloat("_Metallic", _pinchStrenght);
        // }
        // if (!_hasPinched && _isIndexFingerPinching && _confidence == OVRHand.TrackingConfidence.High && handPointer.CurrentTarget) {
        //     _hasPinched = true;
        //     handPointer.CurrentTarget.GetComponent<AudioSource>().PlayOneShot(pinchSound);
        // } else if (_hasPinched && !_isIndexFingerPinching) {
        //     _hasPinched = false;
        //     handPointer.CurrentTarget.GetComponent<AudioSource>().PlayOneShot(releaseSound);
        // }
    }

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = cube.GetComponent<Rigidbody>();
    }

}
