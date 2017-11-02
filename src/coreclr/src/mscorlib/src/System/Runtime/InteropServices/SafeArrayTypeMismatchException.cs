// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*=============================================================================
**
**
** Purpose: This exception is thrown when the runtime type of an array
**            is different than the safe array sub type specified in the 
**            metadata.
**
=============================================================================*/


using System;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
    [Serializable]
    [System.Runtime.CompilerServices.TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    public class SafeArrayTypeMismatchException : SystemException
    {
        public SafeArrayTypeMismatchException()
            : base(SR.Arg_SafeArrayTypeMismatchException)
        {
            HResult = HResults.COR_E_SAFEARRAYTYPEMISMATCH;
        }

        public SafeArrayTypeMismatchException(String message)
            : base(message)
        {
            HResult = HResults.COR_E_SAFEARRAYTYPEMISMATCH;
        }

        public SafeArrayTypeMismatchException(String message, Exception inner)
            : base(message, inner)
        {
            HResult = HResults.COR_E_SAFEARRAYTYPEMISMATCH;
        }

        protected SafeArrayTypeMismatchException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
