
namespace Educative
{
  public class CLoopWhileTrue : Command
  {
    public TutInt leftValue = new TutInt();
    public TutInt rightValue = new TutInt();
    public MyHeader Comparision = new MyHeader();
    public Comparison comparison;
    internal int indexEnded;

    public CLoopWhileTrue()
    {
      this.type = Command.Type.LoopWhileTrue;
    }

    public bool Evaulate()
    {
      switch (this.comparison)
      {
        case Comparison.Smaller:
          return this.leftValue.SmallerThen(this.rightValue);
        case Comparison.SmallerOrEqual:
          return this.leftValue.SmallerThenOrEqual(this.rightValue);
        case Comparison.Equal:
          return this.leftValue.EqualTo(this.rightValue);
        case Comparison.BiggerOrEqual:
          return this.leftValue.BiggerThenOrEqual(this.rightValue);
        case Comparison.Bigger:
          return this.leftValue.BiggerThen(this.rightValue);
        case Comparison.NotEqual:
          return this.leftValue.NotEqual(this.rightValue);
        default:
          return false;
      }
    }
  }
}
