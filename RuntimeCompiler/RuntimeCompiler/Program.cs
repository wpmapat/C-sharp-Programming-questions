using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;

namespace RuntimeCompiler
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToCompile = "using System; public class Mathematica { public int FirstPrime() { return (int)2;}}";
            string className = "Mathematica";
            string methodName = "FirstPrime";
            object result = Execute(stringToCompile, className, methodName);
        }
        public static object Execute(string stringToCompile, string className, string methodName)
        {
            //Dictionary<string, string> providerOptions = new Dictionary<string, string>
            //    {
            //        {"CompilerVersion", "v3.5"}
            //    };
            CSharpCodeProvider provider = new CSharpCodeProvider(); // (providerOptions);

            CompilerParameters compilerParams = new CompilerParameters
            {
                GenerateInMemory = true,
                GenerateExecutable = false
            };

            CompilerResults results = provider.CompileAssemblyFromSource(compilerParams, stringToCompile);

            if (results.Errors.Count != 0)
                throw new Exception("Mission failed!");

            object o = results.CompiledAssembly.CreateInstance(className);
            MethodInfo mi = o.GetType().GetMethod(methodName);
            object result=mi.Invoke(o, null);
            return result;
        }

    }
}

