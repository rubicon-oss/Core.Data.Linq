using System.Resources;

namespace System.Data.Linq
{
  internal sealed class SR
  {
    private static ResourceManager s_resourceManager;

    public static ResourceManager Resources
    {
      get
      {
        if (SR.s_resourceManager != null)
          return SR.s_resourceManager;
        SR.s_resourceManager = new ResourceManager("System.Data.Linq", typeof (SR).Assembly);
        return SR.s_resourceManager;
      }
    }

    public static string GetString(string name) => SR.Resources.GetString(name);

    public static string GetString(string name, params object[] args)
    {
      string format = SR.GetString(name);
      return args == null || args.Length == 0 ? format : string.Format(format, args);
    }
  }
}
