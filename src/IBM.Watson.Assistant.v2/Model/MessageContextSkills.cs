/**
* (C) Copyright IBM Corp. 2018, 2020.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using IBM.Cloud.SDK.Core.Model;

namespace IBM.Watson.Assistant.v2.Model
{
    /// <summary>
    /// Information specific to particular skills used by the Assistant.
    ///
    /// **Note:** Currently, only a single property named `main skill` is supported. This object contains variables that
    /// apply to the dialog skill used by the assistant.
    /// </summary>
    public class MessageContextSkills : DynamicModel<MessageContextSkill>
    {
    }

}
