using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class DetailedGear : SummaryGear {
    /// <summary>
    /// The gear's brand name.
    /// </summary>
    /// <value>The gear's brand name.</value>
    [DataMember(Name="brand_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brand_name")]
    public string BrandName { get; set; }

    /// <summary>
    /// The gear's model name.
    /// </summary>
    /// <value>The gear's model name.</value>
    [DataMember(Name="model_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "model_name")]
    public string ModelName { get; set; }

    /// <summary>
    /// The gear's frame type (bike only).
    /// </summary>
    /// <value>The gear's frame type (bike only).</value>
    [DataMember(Name="frame_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "frame_type")]
    public int? FrameType { get; set; }

    /// <summary>
    /// The gear's description.
    /// </summary>
    /// <value>The gear's description.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DetailedGear {\n");
      sb.Append("  BrandName: ").Append(BrandName).Append("\n");
      sb.Append("  ModelName: ").Append(ModelName).Append("\n");
      sb.Append("  FrameType: ").Append(FrameType).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
