
namespace Win32Utilities
{
  internal class FlashWindowNoOp : IFlashWindow
  {
    public bool Flash()
    {
      return false;
    }

    public bool Flash(uint count)
    {
      return false;
    }

    public bool Start()
    {
      return false;
    }

    public bool Stop()
    {
      return false;
    }
  }
}
