﻿using System;

namespace ILCompilerConsole
{
    public interface IILBuilder
    {
        Type DummyType { get; }

        void Initialise();
        void GenerateExecutable();

        void EmitPushIntegerOnStack(char num);
        void EmitAdd();
    }
}
