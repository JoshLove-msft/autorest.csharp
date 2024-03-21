// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using MgmtMockAndSample.Models;

namespace MgmtMockAndSample.Samples
{
    public partial class Sample_RoleAssignmentCollection
    {
        // Create role assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateRoleAssignment()
        {
            // Generated from example definition:
            // this example is just showing the usage of "RoleAssignments_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this RoleAssignmentResource
            string scope = "scope";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            RoleAssignmentCollection collection = client.GetRoleAssignments(scopeId);

            // invoke the operation
            string roleAssignmentName = "roleAssignmentName";
            RoleAssignmentCreateOrUpdateContent content = new RoleAssignmentCreateOrUpdateContent()
            {
                RoleDefinitionId = "/subscriptions/4004a9fd-d58e-48dc-aeb2-4a4aec58606f/providers/Microsoft.Authorization/roleDefinitions/de139f84-1756-47ae-9be6-808fbbe84772",
                PrincipalId = "d93a38bc-d029-4160-bfb0-fbda779ac214",
                CanDelegate = false,
            };
            ArmOperation<RoleAssignmentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, roleAssignmentName, content);
            RoleAssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RoleAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get role assignment by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRoleAssignmentByName()
        {
            // Generated from example definition:
            // this example is just showing the usage of "RoleAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this RoleAssignmentResource
            string scope = "scope";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            RoleAssignmentCollection collection = client.GetRoleAssignments(scopeId);

            // invoke the operation
            string roleAssignmentName = "roleAssignmentName";
            RoleAssignmentResource result = await collection.GetAsync(roleAssignmentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RoleAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get role assignment by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetRoleAssignmentByName()
        {
            // Generated from example definition:
            // this example is just showing the usage of "RoleAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this RoleAssignmentResource
            string scope = "scope";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            RoleAssignmentCollection collection = client.GetRoleAssignments(scopeId);

            // invoke the operation
            string roleAssignmentName = "roleAssignmentName";
            bool result = await collection.ExistsAsync(roleAssignmentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get role assignment by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetRoleAssignmentByName()
        {
            // Generated from example definition:
            // this example is just showing the usage of "RoleAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this RoleAssignmentResource
            string scope = "scope";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            RoleAssignmentCollection collection = client.GetRoleAssignments(scopeId);

            // invoke the operation
            string roleAssignmentName = "roleAssignmentName";
            NullableResponse<RoleAssignmentResource> response = await collection.GetIfExistsAsync(roleAssignmentName);
            RoleAssignmentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RoleAssignmentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // List role assignments for scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListRoleAssignmentsForScope()
        {
            // Generated from example definition:
            // this example is just showing the usage of "RoleAssignments_ListForScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this RoleAssignmentResource
            string scope = "scope";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            RoleAssignmentCollection collection = client.GetRoleAssignments(scopeId);

            // invoke the operation and iterate over the result
            await foreach (RoleAssignmentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RoleAssignmentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
