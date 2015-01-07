﻿/*
 * Copyright 2014, 2015 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using Autofac;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IdentityServer.Core.Extensions
{
    internal static class IContainerExtensions
    {
        internal static ILifetimeScope CreateScopeWithEmptyOwinContext(this IContainer container)
        {
            var ctx = new OwinContext();
            return container.BeginLifetimeScope(b =>
            {
                // this makes owin context resolvable in the scope
                b.RegisterInstance(ctx).As<IOwinContext>();
            });
        }
    }
}
