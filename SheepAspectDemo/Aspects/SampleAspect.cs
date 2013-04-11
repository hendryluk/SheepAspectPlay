using System;
using System.Diagnostics;
using SheepAspect.Framework;
using SheepAspect.Runtime;

namespace SheepAspectDemo.Aspects
{
    [Aspect]
    public class SampleAspect
    {
        [SelectMethods("Public & !InType:ThisAspect")]
        public void PublicMethods() { }

        [Around("PublicMethods")]
        public object LogAroundMethod(MethodJointPoint jp)
        {
            Console.WriteLine("Entering {0} on {1}. Args:{2}", jp.Method, jp.This, string.Join(",", jp.Args));
            try
            {
                var result = jp.Execute();

                Console.WriteLine("Exitting {0}. Result: {1}", jp.Method, jp.Method.ReturnType == typeof(void)? "{void}": result);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exitting {0} with exception: '{1}'", jp.Method, e);
                throw;
            }
        }
    }
}