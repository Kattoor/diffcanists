
using System;
using System.Collections.Generic;

namespace Educative
{
  public class CIntitializeVarible : Command
  {
    public List<CIntitializeVarible.ListVars> list = new List<CIntitializeVarible.ListVars>();

    public CIntitializeVarible()
    {
      this.type = Command.Type.IntitializeVariables;
    }

    [Serializable]
    public class ListVars
    {
      public int identifier = -1;
      public string name = "temp";
      public int value;
    }
  }
}
