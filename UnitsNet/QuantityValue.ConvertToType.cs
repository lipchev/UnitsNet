// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using Fractions;

namespace UnitsNet;

public partial struct QuantityValue
{
    #region Implementation of IConvertible

    readonly TypeCode IConvertible.GetTypeCode()
    {
        return TypeCode.Object;
    }

    readonly bool IConvertible.ToBoolean(IFormatProvider? provider)
    {
        throw new InvalidCastException($"Converting {typeof(QuantityValue)} to bool is not supported.");
    }

    readonly byte IConvertible.ToByte(IFormatProvider? provider)
    {
        return (byte)this;
    }

    readonly char IConvertible.ToChar(IFormatProvider? provider)
    {
        throw new InvalidCastException($"Converting {typeof(QuantityValue)} to char is not supported.");
    }

    readonly DateTime IConvertible.ToDateTime(IFormatProvider? provider)
    {
        throw new InvalidCastException($"Converting {typeof(QuantityValue)} to DateTime is not supported.");
    }

    readonly decimal IConvertible.ToDecimal(IFormatProvider? provider)
    {
        return ToDecimal();
    }

    readonly double IConvertible.ToDouble(IFormatProvider? provider)
    {
        return ToDouble();
    }

    readonly short IConvertible.ToInt16(IFormatProvider? provider)
    {
        return (short)this;
    }

    readonly int IConvertible.ToInt32(IFormatProvider? provider)
    {
        return (int)this;
    }

    readonly long IConvertible.ToInt64(IFormatProvider? provider)
    {
        return (long)this;
    }

    readonly sbyte IConvertible.ToSByte(IFormatProvider? provider)
    {
        return (sbyte)this;
    }

    readonly float IConvertible.ToSingle(IFormatProvider? provider)
    {
        return (float)this;
    }

    readonly ushort IConvertible.ToUInt16(IFormatProvider? provider)
    {
        return (ushort)this;
    }

    readonly uint IConvertible.ToUInt32(IFormatProvider? provider)
    {
        return (uint)this;
    }

    readonly ulong IConvertible.ToUInt64(IFormatProvider? provider)
    {
        return (ulong)this;
    }

    readonly object IConvertible.ToType(Type conversionType, IFormatProvider? provider)
    {
        if (conversionType == null)
        {
            throw new ArgumentNullException(nameof(conversionType));
        }

        if (conversionType == typeof(string))
        {
            return ToString(provider);
        }

        if (conversionType == typeof(double))
        {
            return ToDouble();
        }

        if (conversionType == typeof(decimal))
        {
            return ToDecimal();
        }

        if (conversionType == typeof(float))
        {
            return (float)this;
        }

        if (conversionType == typeof(long))
        {
            return (long)this;
        }

        if (conversionType == typeof(ulong))
        {
            return (ulong)this;
        }

        if (conversionType == typeof(int))
        {
            return (int)this;
        }

        if (conversionType == typeof(uint))
        {
            return (uint)this;
        }

        if (conversionType == typeof(short))
        {
            return (short)this;
        }

        if (conversionType == typeof(ushort))
        {
            return (ushort)this;
        }

        if (conversionType == typeof(byte))
        {
            return (byte)this;
        }

        if (conversionType == typeof(Fraction))
        {
            return _fraction;
        }

        throw new InvalidCastException($"Converting {typeof(QuantityValue)} to {conversionType} is not supported.");
    }

    #endregion
}
