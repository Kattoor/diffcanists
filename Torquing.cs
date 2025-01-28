
using UnityEngine;

public class Torquing : MonoBehaviour
{
  internal float speed = 300f;
  public ZCreature creature;
  private int framesToStop;
  private Torquing.State state;
  public bool goback;
  private Vector3 curRotation;

  public void Moved()
  {
    this.state = Torquing.State.Moving;
    this.framesToStop = 5;
    this.curRotation.z += this.speed * Time.deltaTime;
    if ((double) this.curRotation.z > 360.0)
      this.curRotation.z -= 360f;
    this.transform.localEulerAngles = -this.curRotation;
  }

  private void Update()
  {
    if (this.creature.isMoving)
    {
      this.state = this.goback ? Torquing.State.GoBack : Torquing.State.Stopped;
    }
    else
    {
      switch (this.state)
      {
        case Torquing.State.GoBack:
          if ((double) this.curRotation.z > 180.0)
          {
            this.curRotation.z += 500f * Time.deltaTime;
            if ((double) this.curRotation.z >= 360.0)
            {
              this.curRotation.z = 0.0f;
              this.state = Torquing.State.Stopped;
            }
          }
          else
          {
            this.curRotation.z -= 500f * Time.deltaTime;
            if ((double) this.curRotation.z <= 0.0)
            {
              this.curRotation.z = 0.0f;
              this.state = Torquing.State.Stopped;
            }
          }
          this.transform.localEulerAngles = -this.curRotation;
          break;
        case Torquing.State.Moving:
          --this.framesToStop;
          if (this.framesToStop > 0)
            break;
          if (this.goback)
          {
            this.state = Torquing.State.GoBack;
            break;
          }
          this.state = Torquing.State.Stopped;
          break;
      }
    }
  }

  private enum State
  {
    Stopped,
    GoBack,
    Moving,
  }
}
