using UnityEngine;
using System.Collections;
public interface IDamageStrategy
{
    void Apply(Transform obj, int dps, float attackInterval);
}
