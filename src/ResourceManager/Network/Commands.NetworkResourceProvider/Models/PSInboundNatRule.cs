﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

namespace Microsoft.Azure.Commands.NetworkResourceProvider.Models
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class PSInboundNatRule : PSChildResource
    {
        public List<PSResourceId> FrontendIPConfigurations { get; set; }

        public PSResourceId BackendIPConfiguration { get; set; }

        public string Protocol { get; set; }

        public int FrontendPort { get; set; }

        public int BackendPort { get; set; }

        public int? IdleTimeoutInMinutes { get; set; }

        public bool EnableFloatingIP { get; set; }

        public string ProvisioningState { get; set; }

        [JsonIgnore]
        public string FrontendIPConfigurationsText
        {
            get { return JsonConvert.SerializeObject(FrontendIPConfigurations, Formatting.Indented); }
        }

        [JsonIgnore]
        public string BackendIPConfigurationText
        {
            get { return JsonConvert.SerializeObject(BackendIPConfiguration, Formatting.Indented); }
        }
    }
}
