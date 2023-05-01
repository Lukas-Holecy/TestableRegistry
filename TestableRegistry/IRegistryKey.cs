namespace TestableRegistry
{
    using System;
    using System.Collections.Generic;
    using System.Security.AccessControl;
    using System.Text;
    using Microsoft.Win32;

    public interface IRegistryKey : IDisposable
    {
        string Name { get; }

        int SubKeyCount { get; }

        int ValueCount { get; }

        RegistryView RegistryView { get; }

        void Close();

        IRegistryKey CreateSubKey(string subkey);

        IRegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck);

        IRegistryKey CreateSubKey(string subkey, bool writable);

        IRegistryKey CreateSubKey(
            string subkey,
            RegistryKeyPermissionCheck permissionCheck,
            System.Security.AccessControl.RegistrySecurity? registrySecurity);

        IRegistryKey CreateSubKey(string subkey, bool writable, RegistryOptions options);

        IRegistryKey CreateSubKey(
            string subkey, RegistryKeyPermissionCheck permissionCheck, RegistryOptions registryOptions);

        IRegistryKey CreateSubKey(
            string subkey,
            RegistryKeyPermissionCheck permissionCheck,
            RegistryOptions registryOptions,
            System.Security.AccessControl.RegistrySecurity? registrySecurity);

        void DeleteSubKey(string subkey);

        void DeleteSubKey(string subkey, bool throwOnMissingSubKey);

        void DeleteSubKeyTree(string subkey, bool throwOnMissingSubKey);

        void DeleteSubKeyTree(string subkey);

        public void DeleteValue(string name);

        void DeleteValue(string name, bool throwOnMissingValue);

        /// <summary>
        /// Writes all the attributes of the specified open registry key into the registry.
        /// </summary>
        void Flush();

        RegistrySecurity GetAccessControl();

        RegistrySecurity GetAccessControl(AccessControlSections includeSections);

        string[] GetSubKeyNames();

        object? GetValue(string? name, object? defaultValue, RegistryValueOptions options);

        object? GetValue(string? name);

        object? GetValue(string? name, object? defaultValue);
    }
}
