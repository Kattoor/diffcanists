
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTestScene : MonoBehaviour
{
  public List<GameObject> towers = new List<GameObject>();
  public ZMyWorld world = new ZMyWorld();
  public CircleCollider2D circle;
}
