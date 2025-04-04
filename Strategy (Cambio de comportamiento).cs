using UnityEngine;

public interface IMoveStrategy
{
    void Move(Transform transform);
}

public class WalkStrategy : IMoveStrategy
{
    public void Move(Transform transform) => transform.Translate(Vector3.forward * Time.deltaTime * 2);
}

public class RunStrategy : IMoveStrategy
{
    public void Move(Transform transform) => transform.Translate(Vector3.forward * Time.deltaTime * 5);
}

public class PlayerMovement : MonoBehaviour
{
    private IMoveStrategy moveStrategy;

    private void Start() => moveStrategy = new WalkStrategy();

    private void Update() => moveStrategy.Move(transform);

    public void SetRun()
    {
        moveStrategy = new RunStrategy();
        Debug.Log("🏃 Cambiado a correr.");
    }

    public void SetWalk()
    {
        moveStrategy = new WalkStrategy();
        Debug.Log("🚶 Cambiado a caminar.");
    }
}
