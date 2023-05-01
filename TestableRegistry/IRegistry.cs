// <copyright file="IRegistry.cs" company="Brochet Ltd.">
// Copyright (c) Brochet Ltd.. All rights reserved.
// </copyright>

namespace TestableRegistry
{
    using System;
    using Microsoft.Win32;

    /// <summary>
    /// wrapper for <see cref="Registry"/> object.
    /// </summary>
    public interface IRegistry
    {
        IRegistryKey ClassesRoot { get; }

        IRegistryKey CurrentConfig { get; }

        IRegistryKey CurrentUser { get; }

        IRegistryKey LocalMachine { get; }

        IRegistryKey PerformanceData { get; }

        IRegistryKey Users { get; }

        object? GetValue(string keyName, string? valueName, object? defaultValue);

        void SetValue(string keyName, string? valueName, object value);

        void SetValue(string keyName, string? valueName, object value, RegistryValueKind valueKind);

    }
}
