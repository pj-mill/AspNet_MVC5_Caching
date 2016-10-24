// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IoC.cs" company="Web Advanced">
// Copyright 2012 Web Advanced (www.webadvanced.com)
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace MemoryCacheExample.DependencyResolution
{
    using Cache;
    using Services;
    using StructureMap;
    using StructureMap.Graph;

    public static class IoC
    {
        public static IContainer Initialize()
        {
            return new Container(config =>
                {
                    config.Scan(scan =>
                    {
                        scan.TheCallingAssembly();
                        scan.WithDefaultConventions();
                    });

                    config.For<ICache>().Use<SystemMemoryCache>();
                    var customerService = config.For<ICustomerService>().Use<CustomerService>();
                    config.For<ICustomerService>().Use<InMemoryCachedCustomerService>().Ctor<ICustomerService>().Is(customerService);
                }
            );
        }
    }
}