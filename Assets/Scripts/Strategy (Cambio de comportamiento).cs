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

