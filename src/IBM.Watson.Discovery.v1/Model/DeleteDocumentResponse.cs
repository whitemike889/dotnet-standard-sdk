/**
* (C) Copyright IBM Corp. 2017, 2019.
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

using Newtonsoft.Json;

namespace IBM.Watson.Discovery.v1.Model
{
    /// <summary>
    /// Information returned when a document is deleted.
    /// </summary>
    public class DeleteDocumentResponse
    {
        /// <summary>
        /// Status of the document. A deleted document has the status deleted.
        /// </summary>
        public class StatusEnumValue
        {
            /// <summary>
            /// Constant DELETED for deleted
            /// </summary>
            public const string DELETED = "deleted";
            
        }

        /// <summary>
        /// Status of the document. A deleted document has the status deleted.
        /// Constants for possible values can be found using DeleteDocumentResponse.StatusEnumValue
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
        /// <summary>
        /// The unique identifier of the document.
        /// </summary>
        [JsonProperty("document_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentId { get; set; }
    }

}
