using System.Reflection;

public static class Reflection
{
    public static readonly Assembly editorAssembly
    = Assembly.Load("UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
}