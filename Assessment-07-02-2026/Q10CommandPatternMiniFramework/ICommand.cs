using System;

namespace Q10CommandPatternMiniFramework;

public interface ICommand
{
    void Execute();
    void Undo();

}
