// Copyright 2011 Chris Patterson
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace OdoyuleRules.Models.RuntimeModel
{
    using System;

    class StatefulActivationContext<T> :
        ActivationContext<T>
        where T : class
    {
        readonly T _fact;
        readonly StatefulSession _session;

        public StatefulActivationContext(StatefulSession session, T fact)
        {
            _session = session;
            _fact = fact;
        }

        public Session CurrentSession
        {
            get { return _session; }
        }

        public void Convert<TOutput>(Action<ActivationContext<TOutput>> callback)
            where TOutput : class
        {
            throw new NotImplementedException();
        }
    }
}