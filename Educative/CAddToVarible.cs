
namespace Educative
{
  public class CAddToVarible : Command
  {
    public TutInt varible = new TutInt();
    public MyHeader VariableModification = new MyHeader();
    public TutInt add = new TutInt();
    public MyMaths algorithm;

    public CAddToVarible()
    {
      this.type = Command.Type.VariableMaths;
    }
  }
}
