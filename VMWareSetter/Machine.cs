﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace VMWareSetter
{
    public class Machine
    { 
        public string Name { get; set; }
        public string Path { get; set; }
        public string GetVMXFile()
        {
            return System.IO.Path.Combine(Path, Name) + ".vmx";
        }

        public static Machine CreateFromPath(String name, String path)
        {
            return new Machine() { Name = name, Path = path };
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Path: " + Path;
        }
    }
}
