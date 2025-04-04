using UnityEngine;

public class BaseSpeed : MonoBehaviour
{
    [SerializeField] private float baseSpeed = 5f;

    public virtual float GetSpeed() => baseSpeed;
}

public class SpeedDecorator : BaseSpeed
{
    private BaseSpeed baseSpeed;

    public SpeedDecorator(BaseSpeed baseSpeed) => this.baseSpeed = baseSpeed;

    public override float GetSpeed() => baseSpeed.GetSpeed() * 1.5f; // Aumenta velocidad en 50%
}

public class Player : MonoBehaviour
{
    [SerializeField] private BaseSpeed speed; // Referencia a un componente BaseSpeed

    private void Start()
    {
        if (speed == null)
        {
            speed = GetComponent<BaseSpeed>();
            if (speed == null)
            {
                Debug.LogError("No se encontró un componente BaseSpeed en el GameObject del Player.");
            }
        }
    }

    public void IncreaseSpeed()
    {
        speed = new SpeedDecorator(speed);
        Debug.Log("🚀 Nueva velocidad: " + speed.GetSpeed());
    }
}