
using UnityEngine;

public class Effector : MonoBehaviour
{
  public int MaxTurnsAlive = 5;
  internal ZEffector serverObj;
  public MyCollider collider;
  public AudioClip soundClip;
  public bool effectWhileInactive;
  public EffectorType type;
  public DamageType damageType;
  public GameObject explosion;
  public int delayDeath;
  public int variable;
}
