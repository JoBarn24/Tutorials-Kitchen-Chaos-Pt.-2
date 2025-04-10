using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] private float shakeAmount = 0.02f;
    private Vector3 initialPos;
    private bool isShaking = false;

    void Awake()
    {
        initialPos = transform.position;
    }

    void Update()
    {
        if (isShaking)
        {
            transform.position = initialPos + Random.insideUnitSphere * shakeAmount;
        }
    }

    public void ShakeCamera()
    {
        isShaking = true;
        Invoke("StopShake", 0.5f);
    }

    private void StopShake()
    {
        isShaking = false;
        transform.position = initialPos;
    }
}