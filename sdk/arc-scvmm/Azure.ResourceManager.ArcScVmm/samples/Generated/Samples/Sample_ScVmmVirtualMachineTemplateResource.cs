// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ArcScVmm.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ArcScVmm.Samples
{
    public partial class Sample_ScVmmVirtualMachineTemplateResource
    {
        // GetVirtualMachineTemplate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetVirtualMachineTemplate()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/preview/2020-06-05-preview/examples/GetVirtualMachineTemplate.json
            // this example is just showing the usage of "VirtualMachineTemplates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmVirtualMachineTemplateResource created on azure
            // for more information of creating ScVmmVirtualMachineTemplateResource, please refer to the document of ScVmmVirtualMachineTemplateResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string virtualMachineTemplateName = "HRVirtualMachineTemplate";
            ResourceIdentifier scVmmVirtualMachineTemplateResourceId = ScVmmVirtualMachineTemplateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineTemplateName);
            ScVmmVirtualMachineTemplateResource scVmmVirtualMachineTemplate = client.GetScVmmVirtualMachineTemplateResource(scVmmVirtualMachineTemplateResourceId);

            // invoke the operation
            ScVmmVirtualMachineTemplateResource result = await scVmmVirtualMachineTemplate.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScVmmVirtualMachineTemplateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DeleteVirtualMachineTemplate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteVirtualMachineTemplate()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/preview/2020-06-05-preview/examples/DeleteVirtualMachineTemplate.json
            // this example is just showing the usage of "VirtualMachineTemplates_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmVirtualMachineTemplateResource created on azure
            // for more information of creating ScVmmVirtualMachineTemplateResource, please refer to the document of ScVmmVirtualMachineTemplateResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string virtualMachineTemplateName = "HRVirtualMachineTemplate";
            ResourceIdentifier scVmmVirtualMachineTemplateResourceId = ScVmmVirtualMachineTemplateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineTemplateName);
            ScVmmVirtualMachineTemplateResource scVmmVirtualMachineTemplate = client.GetScVmmVirtualMachineTemplateResource(scVmmVirtualMachineTemplateResourceId);

            // invoke the operation
            await scVmmVirtualMachineTemplate.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // UpdateVirtualMachineTemplate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateVirtualMachineTemplate()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/preview/2020-06-05-preview/examples/UpdateVirtualMachineTemplate.json
            // this example is just showing the usage of "VirtualMachineTemplates_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmVirtualMachineTemplateResource created on azure
            // for more information of creating ScVmmVirtualMachineTemplateResource, please refer to the document of ScVmmVirtualMachineTemplateResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string virtualMachineTemplateName = "HRVirtualMachineTemplate";
            ResourceIdentifier scVmmVirtualMachineTemplateResourceId = ScVmmVirtualMachineTemplateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineTemplateName);
            ScVmmVirtualMachineTemplateResource scVmmVirtualMachineTemplate = client.GetScVmmVirtualMachineTemplateResource(scVmmVirtualMachineTemplateResourceId);

            // invoke the operation
            ResourcePatch patch = new ResourcePatch()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            ArmOperation<ScVmmVirtualMachineTemplateResource> lro = await scVmmVirtualMachineTemplate.UpdateAsync(WaitUntil.Completed, patch);
            ScVmmVirtualMachineTemplateResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScVmmVirtualMachineTemplateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ListVirtualMachineTemplatesBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetScVmmVirtualMachineTemplates_ListVirtualMachineTemplatesBySubscription()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/preview/2020-06-05-preview/examples/ListVirtualMachineTemplatesBySubscription.json
            // this example is just showing the usage of "VirtualMachineTemplates_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ScVmmVirtualMachineTemplateResource item in subscriptionResource.GetScVmmVirtualMachineTemplatesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ScVmmVirtualMachineTemplateData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
