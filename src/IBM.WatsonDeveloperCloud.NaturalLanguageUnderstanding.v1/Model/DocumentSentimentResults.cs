/**
* Copyright 2017 IBM Corp. All Rights Reserved.
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

namespace IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1.Model
{
    /// <summary>
    /// DocumentSentimentResults.
    /// </summary>
    public class DocumentSentimentResults
    {
        /// <summary>
        /// Indicates whether the sentiment is positive, neutral, or negative.
        /// </summary>
        /// <value>Indicates whether the sentiment is positive, neutral, or negative.</value>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }
        /// <summary>
        /// Sentiment score from -1 (negative) to 1 (positive).
        /// </summary>
        /// <value>Sentiment score from -1 (negative) to 1 (positive).</value>
        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public float? Score { get; set; }
    }

}
