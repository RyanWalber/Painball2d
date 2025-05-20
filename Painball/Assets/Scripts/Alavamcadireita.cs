using UnityEngine;

public class Alavancadireita: MonoBehaviour
{
    public KeyCode inputKey = KeyCode.RightArrow;
    private HingeJoint2D hinge;

    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
    }

    void Update()
    {
        JointMotor2D motor = hinge.motor;

        if (Input.GetKey(inputKey))
        {
            motor.motorSpeed = 500; // ou positivo, dependendo do lado
        }
        else
        {
            motor.motorSpeed = -1000; // volta ao ponto inicial
        }

        hinge.motor = motor;
    }
}
