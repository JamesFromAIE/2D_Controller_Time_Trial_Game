using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public static MoveCamera Instance;

    void Awake() => Instance = this;

    [SerializeField] Transform MovePoint = null;
    public Vector3 Offset;
    [SerializeField] float MoveSpeed;
    bool _isMoving = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 desiredPos = MovePoint.position + Offset;
        float moveDist = Vector3.Distance(transform.position, desiredPos);

        if (moveDist < 0.05f)
        {
            _isMoving = false;
        }
        else
        {
            _isMoving = true;
        }

        MoveTowardPoint();
            
    }


    void MoveTowardPoint()
    {
        if (_isMoving)
        {
            Vector3 desiredPos = MovePoint.position + Offset;
            Quaternion desiredRot = MovePoint.rotation;

            Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPos, MoveSpeed * Time.deltaTime);
            Quaternion smoothRotation = Quaternion.Lerp(transform.rotation, desiredRot, MoveSpeed * Time.deltaTime);



            transform.position = smoothPosition;
            transform.rotation = smoothRotation;


        }
    }

    public void FlipOffset()
    {
        Offset = new Vector3(Offset.x * -1,Offset.y, Offset.z);
    }
}
