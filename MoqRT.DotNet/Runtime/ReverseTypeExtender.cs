﻿//
// WinRT Reflector Shim - a library to assist in porting frameworks from .NET to WinRT.
// https://github.com/mbrit/WinRTReflectionShim
//
// *** USE THIS FILE IN YOUR LEGACY PROJECT ***
//
// Copyright (c) 2012 Matthew Baxter-Reynolds 2012 (@mbrit)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoqRT.Reflection;

namespace System.Reflection
{
    public static class ReverseTypeExtender
    {
        public static bool IsClass(this Type type)
        {
            return type.IsClass;
        }

        public static bool IsAbstract(this Type type)
        {
            return type.IsAbstract;
        }

        public static bool IsInterface(this Type type)
        {
            return type.IsInterface;
        }

        public static bool IsPrimitive(this Type type)
        {
            return type.IsPrimitive;
        }

        public static bool IsValueType(this Type type)
        {
            return type.IsValueType;
        }

        public static bool IsGenericType(this Type type)
        {
            return type.IsGenericType;
        }

        public static bool IsEnum(this Type type)
        {
            return type.IsEnum;
        }

        public static bool IsSealed(this Type type)
        {
            return type.IsSealed;
        }

        public static bool IsPublic(this Type type)
        {
            return type.IsPublic;
        }

        public static bool IsNestedPublic(this Type type)
        {
            return type.IsNestedPublic;
        }

        public static bool IsNestedAssembly(this Type type)
        {
            return type.IsNestedAssembly;
        }

        public static bool IsNestedFamORAssem(this Type type)
        {
            return type.IsNestedFamORAssem;
        }

        public static bool IsVisible(this Type type)
        {
            return type.IsVisible;
        }

        public static bool IsGenericParameter(this Type type)
        {
            return type.IsGenericParameter;
        }

        public static bool IsGenericTypeDefinition(this Type type)
        {
            return type.IsGenericTypeDefinition;
        }

        public static bool ContainsGenericParameters(this Type type)
        {
            return type.ContainsGenericParameters;
        }

        public static bool IsArray(this Type type)
        {
            return type.IsArray;
        }

        public static Type BaseType(this Type type)
        {
            return type.BaseType;
        }

        public static Type UnderlyingSystemType(this Type type)
        {
            return type.UnderlyingSystemType;
        }

        public static GenericParameterAttributes GenericParameterAttributes(this Type type)
        {
            return type.GenericParameterAttributes;
        }

        public static Assembly Assembly(this Type type)
        {
            return type.Assembly;
        }

        public static IMethodInfo DeclaringMethod(this Type type)
        {
            return ReflectionWrapperFactory.Get<IMethodInfo>(type.DeclaringMethod);
        }
    }

    public static class MemberInfoExtender
    {
        public static MemberTypes MemberType(this MemberInfo member)
        {
            return member.MemberType;
        }

        public static Type ReflectedType(this MemberInfo member)
        {
            return member.ReflectedType;
        }
    }

    public static class ParameterInfoExtender
    {
        public static bool HasAttribute(this ParameterInfo param, Type type)
        {
            throw new NotImplementedException("This operation has not been implemented.");
        }
    }
}
