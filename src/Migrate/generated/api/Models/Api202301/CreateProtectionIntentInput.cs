// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Create protection intent input.</summary>
    public partial class CreateProtectionIntentInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.ICreateProtectionIntentInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.ICreateProtectionIntentInputInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.ICreateProtectionIntentProperties Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.ICreateProtectionIntentInputInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.CreateProtectionIntentProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProviderSpecificDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.ICreateProtectionIntentProviderSpecificDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.ICreateProtectionIntentInputInternal.ProviderSpecificDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.ICreateProtectionIntentPropertiesInternal)Property).ProviderSpecificDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.ICreateProtectionIntentPropertiesInternal)Property).ProviderSpecificDetail = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.ICreateProtectionIntentProperties _property;

        /// <summary>Create protection intent input properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.ICreateProtectionIntentProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.CreateProtectionIntentProperties()); set => this._property = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ProviderSpecificDetailInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.ICreateProtectionIntentPropertiesInternal)Property).ProviderSpecificDetailInstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.ICreateProtectionIntentPropertiesInternal)Property).ProviderSpecificDetailInstanceType = value ?? null; }

        /// <summary>Creates an new <see cref="CreateProtectionIntentInput" /> instance.</summary>
        public CreateProtectionIntentInput()
        {

        }
    }
    /// Create protection intent input.
    public partial interface ICreateProtectionIntentInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderSpecificDetailInstanceType { get; set; }

    }
    /// Create protection intent input.
    internal partial interface ICreateProtectionIntentInputInternal

    {
        /// <summary>Create protection intent input properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.ICreateProtectionIntentProperties Property { get; set; }
        /// <summary>
        /// The ReplicationProviderInput. For A2A provider, it will be A2ACreateProtectionIntentInput object.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.ICreateProtectionIntentProviderSpecificDetails ProviderSpecificDetail { get; set; }
        /// <summary>The class type.</summary>
        string ProviderSpecificDetailInstanceType { get; set; }

    }
}