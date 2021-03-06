//    Copyright 2014 Productivity Apex Inc.
//        http://www.productivityapex.com/
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using System;
using System.Collections.Generic;

using Ninject;

namespace PAI.FRATIS.SFL.Infrastructure.Engine
{
    public partial class Engine : IEngine
    {
        public IKernel Kernel { get; set; }

        public Engine() 
            : this (new StandardKernel())
        {
            // Initialize with the standard Ninject kernel
        }

        public Engine(IKernel kernel)
        {
            this.Kernel = kernel;
            this.Kernel.Bind<IEngine>().ToConstant(this);
        }

        public virtual void Initialize()
        {
        }

        /// <summary>
        /// Gets an instance of the specified service.
        /// </summary>
        /// <typeparam name="T">The service to resolve.</typeparam>
        /// <returns>An instance of the service.</returns>
        public T Get<T>() where T : class
        {
            return this.Kernel.Get<T>();
        }

        /// <summary>
        /// Gets an instance of the specified service.
        /// </summary>
        /// <returns>An instance of the service.</returns>
        public object Get(Type type)
        {
            return this.Kernel.Get(type);
        }

        /// <summary>
        /// Gets all available instances of the specified service.
        /// </summary>
        /// <returns>A list of instances of the service.</returns>
        public IEnumerable<object> GetAll(Type serviceType)
        {
            return this.Kernel.GetAll(serviceType);
        }

        /// <summary>
        /// Gets all available instances of the specified service.
        /// </summary>
        /// <returns>A list of instances of the service.</returns>
        public IEnumerable<T> GetAll<T>()
        {
            return this.Kernel.GetAll<T>();
        }
        
    }
}