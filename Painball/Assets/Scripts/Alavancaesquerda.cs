using UnityEngine;

public class Alavancaesquerda : MonoBehaviour
{
    public KeyCode inputKey = KeyCode.LeftArrow;
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
            motor.motorSpeed = -1000; // ou positivo, dependendo do lado
        }
        else
        {
            motor.motorSpeed = 1000; // volta ao ponto inicial
        }

        hinge.motor = motor;
    }
}
