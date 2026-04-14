using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    Rigidbody rb;
    public float initialHealth = 100f; //체력 기본값
    private float currentHealth; //현재 체력

    public float launchForce = 10f;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        currentHealth = initialHealth;
        Debug.Log("플레이어 컨트롤러 Awake 호출됨. 현재 체력 :" + currentHealth);

    }

    private void OnEnable()
    {
        Debug.Log("플레이어 컨트롤러 다시 호출됨. 현재 체력 :" + currentHealth);
    }

    private void Update()
    {
        rb.AddForce(Vector3.up*launchForce,ForceMode.Force);
    }

    private void OnDisable()
    {
        Debug.Log("힝");
    }
}
