﻿/*
* PROJECT:          Aura Operating System Development
* CONTENT:          Consoles
* PROGRAMMERS:      Valentin Charbonnier <valentinbreiz@gmail.com>
*/

using System;
using Aura_OS.System.Shell.VBE.CosmosGLGraphics;
using IL2CPU.API.Attribs;

namespace Aura_OS.System.Shell
{

    [Plug(Target = typeof(Cosmos.System.Console))]
    public abstract class Console
    {

        public Console()
        {
            
        }

        public string Name;

        public abstract int X { get; set; }
        public abstract int Y { get; set; }

        public abstract int Width { get; }
        public abstract int Height { get; }

        public abstract int Cols { get; }
        public abstract int Rows { get; }

        public abstract void Clear();

        public abstract void Write(byte[] aText);

        public abstract ConsoleColor Foreground { get; set; }

        public abstract ConsoleColor Background { get; set; }

        public abstract int CursorSize { get; set; }

        public abstract bool CursorVisible { get; set; }

        public abstract void DrawImage(ushort X, ushort Y, ushort Length, ushort height, Image image);

        public abstract void DisableGraphicMode();

    }
}
