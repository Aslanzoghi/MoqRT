// Copyright 2004-2011 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	using System;
	using System.Reflection;
	using System.Reflection.Emit;

	using Castle.DynamicProxy.Tokens;
    using MoqRT;
    using MoqRT.Reflection;

	public class MethodTokenExpression : Expression
	{
		private readonly IMethodInfo method;
#if !MONO
		private readonly Type declaringType;
#endif

		public MethodTokenExpression(IMethodInfo method)
		{
			this.method = method;
#if !MONO
			declaringType = method.DeclaringType;
#endif
		}

		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
            // @mbrit - 2012-06-04 - can't do anything other than pass proper MethodInfo
            // instances down a this is all MSIL knows how to deal with...
			gen.Emit(OpCodes.Ldtoken, method.AsMethodInfo());
#if !MONO
			if (declaringType == null)
			{
				throw new GeneratorException("declaringType can't be null for this situation");
			}
			gen.Emit(OpCodes.Ldtoken, declaringType);
#endif

			var minfo = MethodBaseMethods.GetMethodFromHandle1;

#if !MONO
			minfo = MethodBaseMethods.GetMethodFromHandle2;
#endif

			gen.Emit(OpCodes.Call, minfo);
			gen.Emit(OpCodes.Castclass, typeof(MethodInfo));
		}
	}
}