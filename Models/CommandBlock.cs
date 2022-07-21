using System.Collections.Generic;

public class CommandBlock // блок дерева комманд
{
    public string Type;
    public List<CommandBlock> NextBlocks;
}