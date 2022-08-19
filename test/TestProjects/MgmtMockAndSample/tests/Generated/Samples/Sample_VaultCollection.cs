// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using System.Xml;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;
using MgmtMockAndSample.Models;

namespace MgmtMockAndSample
{
    public partial class Sample_VaultCollection
    {
        // Create a new vault or update an existing vault
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateANewVaultOrUpdateAnExistingVault()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "Vaults_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sample-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VaultResource
            MgmtMockAndSample.VaultCollection collection = resourceGroupResource.GetVaults();

            // invoke the operation
            string vaultName = "sample-vault";
            MgmtMockAndSample.Models.VaultCreateOrUpdateContent content = new VaultCreateOrUpdateContent(new AzureLocation("westus"), new VaultProperties(Guid.Parse("00000000-0000-0000-0000-000000000000"), new MgmtMockAndSampleSku(MgmtMockAndSampleSkuFamily.A, MgmtMockAndSampleSkuName.Standard))
            {
                Duration = XmlConvert.ToTimeSpan("P7D"),
                CreateOn = DateTimeOffset.Parse("2017-05-04T07:12:28.191Z"),
                AccessPolicies =
{
new AccessPolicyEntry(Guid.Parse("00000000-0000-0000-0000-000000000000"),"00000000-0000-0000-0000-000000000000",new Permissions()
{
Keys =
{
KeyPermission.Encrypt,KeyPermission.Decrypt,KeyPermission.WrapKey,KeyPermission.UnwrapKey,KeyPermission.Sign,KeyPermission.Verify,KeyPermission.Get,KeyPermission.List,KeyPermission.Create,KeyPermission.Update,KeyPermission.Import,KeyPermission.Delete,KeyPermission.Backup,KeyPermission.Restore,KeyPermission.Recover,KeyPermission.Purge
},
Secrets =
{
SecretPermission.Get,SecretPermission.List,SecretPermission.Set,SecretPermission.Delete,SecretPermission.Backup,SecretPermission.Restore,SecretPermission.Recover,SecretPermission.Purge
},
Certificates =
{
CertificatePermission.Get,CertificatePermission.List,CertificatePermission.Delete,CertificatePermission.Create,CertificatePermission.Import,CertificatePermission.Update,CertificatePermission.Managecontacts,CertificatePermission.Getissuers,CertificatePermission.Listissuers,CertificatePermission.Setissuers,CertificatePermission.Deleteissuers,CertificatePermission.Manageissuers,CertificatePermission.Recover,CertificatePermission.Purge
},
})
},
                EnabledForDiskEncryption = true,
                EnabledForTemplateDeployment = true,
                PublicNetworkAccess = "Enabled",
            })
            {
                Identity = new ManagedServiceIdentity("SystemAssigned"),
            };
            ArmOperation<MgmtMockAndSample.VaultResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, vaultName, content);
            MgmtMockAndSample.VaultResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MgmtMockAndSample.VaultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or update a vault with network acls
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateAVaultWithNetworkAcls()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "Vaults_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sample-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VaultResource
            MgmtMockAndSample.VaultCollection collection = resourceGroupResource.GetVaults();

            // invoke the operation
            string vaultName = "sample-vault";
            MgmtMockAndSample.Models.VaultCreateOrUpdateContent content = new VaultCreateOrUpdateContent(new AzureLocation("westus"), new VaultProperties(Guid.Parse("00000000-0000-0000-0000-000000000000"), new MgmtMockAndSampleSku(MgmtMockAndSampleSkuFamily.A, MgmtMockAndSampleSkuName.Standard))
            {
                EnabledForDiskEncryption = true,
                EnabledForTemplateDeployment = true,
                NetworkAcls = new NetworkRuleSet()
                {
                    Bypass = NetworkRuleBypassOption.AzureServices,
                    DefaultAction = NetworkRuleAction.Deny,
                    IpRules =
{
new IPRule("124.56.78.91"),new IPRule("'10.91.4.0/24'")
},
                    VirtualNetworkRules =
{
new VirtualNetworkRule("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/subnet1")
},
                },
                ReadWriteSingleStringPropertySomething = "test",
                DeepSomething = "deep-value",
            });
            ArmOperation<MgmtMockAndSample.VaultResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, vaultName, content);
            MgmtMockAndSample.VaultResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MgmtMockAndSample.VaultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Retrieve a vault
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_RetrieveAVault()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "Vaults_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sample-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VaultResource
            MgmtMockAndSample.VaultCollection collection = resourceGroupResource.GetVaults();

            // invoke the operation
            string vaultName = "sample-vault";
            MgmtMockAndSample.VaultResource result = await collection.GetAsync(vaultName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MgmtMockAndSample.VaultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Retrieve a vault
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_RetrieveAVault()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "Vaults_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sample-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VaultResource
            MgmtMockAndSample.VaultCollection collection = resourceGroupResource.GetVaults();

            // invoke the operation
            string vaultName = "sample-vault";
            bool result = await collection.ExistsAsync(vaultName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // List vaults in the specified resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListVaultsInTheSpecifiedResourceGroup()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "Vaults_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sample-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VaultResource
            MgmtMockAndSample.VaultCollection collection = resourceGroupResource.GetVaults();

            // invoke the operation and iterate over the result
            int? top = 1;
            await foreach (MgmtMockAndSample.VaultResource item in collection.GetAllAsync(top: top))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MgmtMockAndSample.VaultData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}