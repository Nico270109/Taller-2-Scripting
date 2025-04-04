using UnityEngine;

public class BaseSpeed : MonoBehaviour
{
    public virtual float GetSpeed() => 5f;
}

public class SpeedDecorator : BaseSpeed
{
    private BaseSpeed baseSpeed;

    public SpeedDecorator(BaseSpeed baseSpeed)
    {
        this.baseSpeed = baseSpeed;
    }

    public override float GetSpeed()
    {
        return baseSpeed.GetSpeed() * 1.5f; // Aumenta la velocidad en un 50%
    }
}

public class Player : MonoBehaviour
{
    private BaseSpeed speed;

    private void Start()
    {
        speed = new BaseSpeed();
    }

    public void IncreaseSpeed()
    {
        speed = new SpeedDecorator(speed);
        Debug.Log("Nueva velocidad: " + speed.GetSpeed());
    }
}
