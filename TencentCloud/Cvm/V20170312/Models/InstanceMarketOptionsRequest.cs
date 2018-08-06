/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceMarketOptionsRequest : AbstractModel
    {
        
        /// <summary>
        /// 市场选项类型，当前只支持取值：spot
        /// </summary>
        [JsonProperty("MarketType")]
        public string MarketType{ get; set; }

        /// <summary>
        /// 竞价相关选项
        /// </summary>
        [JsonProperty("SpotOptions")]
        public SpotMarketOptions SpotOptions{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MarketType", this.MarketType);
            this.SetParamObj(map, prefix + "SpotOptions.", this.SpotOptions);
        }
    }
}
