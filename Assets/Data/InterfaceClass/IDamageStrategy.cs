using UnityEngine;
using System.Collections;
public interface IDamageStrategy
{
    void Apply(DamageReceiver damageReceiver, int dps, float attackInterval);
}
