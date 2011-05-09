﻿using System;
using JSIL.Meta;
using JSIL.Proxy;

namespace JSIL.Proxies {
    [JSProxy(
        typeof(Array),
        memberPolicy: JSProxyMemberPolicy.ReplaceDeclared
    )]
    public abstract class ArrayProxy {
        [JSChangeName("length")]
        [NeverReplace]
        abstract public int Length { get; }

        [JSReplacement("JSIL.Array.New($elementType, $size)")]
        public static System.Array CreateInstance (Type elementType, Int32 size) {
            throw new NotImplementedException();
        }

        [JSReplacement("JSIL.MultidimensionalArray.New.apply(null, [$elementType].concat($sizes))")]
        public static System.Array CreateInstance (Type elementType, AnyType[] sizes) {
            throw new NotImplementedException();
        }

        [JSReplacement("JSIL.MultidimensionalArray.New($elementType, $sizeX, $sizeY)")]
        public static System.Array CreateInstance (Type elementType, AnyType sizeX, AnyType sizeY) {
            throw new NotImplementedException();
        }

        [JSReplacement("JSIL.MultidimensionalArray.New($elementType, $sizeX, $sizeY, $sizeZ)")]
        public static System.Array CreateInstance (Type elementType, AnyType sizeX, AnyType sizeY, AnyType sizeZ) {
            throw new NotImplementedException();
        }

        [JSExternal]
        public abstract void Set (AnyType x, AnyType value);

        [JSExternal]
        public abstract void Set (AnyType x, AnyType y, AnyType value);

        [JSExternal]
        public abstract void Set (AnyType x, AnyType y, AnyType z, AnyType value);

        [JSExternal]
        public abstract AnyType Get (AnyType x);

        [JSExternal]
        public abstract AnyType Get (AnyType x, AnyType y);

        [JSExternal]
        public abstract AnyType Get (AnyType x, AnyType y, AnyType z);

        [JSReplacement("$this.Get.apply($this, $indices)")]
        public abstract AnyType GetValue (AnyType[] indices);

        [JSReplacement("$this.Set.apply($this, $indices.concat([$value]))")]
        public abstract void SetValue (AnyType value, AnyType[] indices);
    }
}
