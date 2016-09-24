﻿using System;
using PostSharp.Aspects;

namespace Nutshell.Aspects
{
        [Serializable]
        public sealed class LogMethodExceptionAttribute : OnMethodBoundaryAspect
        {
                public override void OnException(MethodExecutionArgs args)
                {
                        // This method is invoked upon exception in the method to which the current aspect is applied.
                        // It is equivelent to the 'catch' block.


                        // args.Instance contains the object whose method is being executed (null if the method is static).
                        // args.Arguments contains method arguments.
                        // args.Exception contains the current exception.

                        // By default, the exception will be rethrown after execution of the current advise.
                        // Set args.FlowBehavior = FlowBehavior.Return to return to the caller without executing an exception.
                        // In this case, set args.ReturnValue to a value that is compatible to the return type of the method (null for void methods).
                        // Set args.FlowBehavior = FlowBehavior.ThrowException to throw another exception.
                        // In this case, set args.Exception to the new exception.

                }

        }
}
