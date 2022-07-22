using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public abstract class CommandBlock // блок дерева комманд
{
    public static Dictionary<string, Type> GetAllCommandBlockTypes() //пиоск всех унаследованных от блока комманд блоков
    {
        var result = new Dictionary<string, Type>();
        IEnumerable<Type> list = Assembly.GetAssembly(typeof(CommandBlock)).GetTypes().Where(type => type.IsSubclassOf(typeof(CommandBlock)));
        foreach (Type type in list)
        {
            result.Add(((CommandBlock)Activator.CreateInstance(type)).Keyword, type);
        }
        return result;
    }

    public string Keyword; // ключевое слово, которое в коде соответствует этому блоку
    public List<CommandBlock> NextBlocks;
}