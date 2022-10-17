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
  public class DetailedAthlete : SummaryAthlete {
    /// <summary>
    /// The athlete's follower count.
    /// </summary>
    /// <value>The athlete's follower count.</value>
    [DataMember(Name="follower_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "follower_count")]
    public int? FollowerCount { get; set; }

    /// <summary>
    /// The athlete's friend count.
    /// </summary>
    /// <value>The athlete's friend count.</value>
    [DataMember(Name="friend_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "friend_count")]
    public int? FriendCount { get; set; }

    /// <summary>
    /// The athlete's preferred unit system.
    /// </summary>
    /// <value>The athlete's preferred unit system.</value>
    [DataMember(Name="measurement_preference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "measurement_preference")]
    public string MeasurementPreference { get; set; }

    /// <summary>
    /// The athlete's FTP (Functional Threshold Power).
    /// </summary>
    /// <value>The athlete's FTP (Functional Threshold Power).</value>
    [DataMember(Name="ftp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ftp")]
    public int? Ftp { get; set; }

    /// <summary>
    /// The athlete's weight.
    /// </summary>
    /// <value>The athlete's weight.</value>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight")]
    public float? Weight { get; set; }

    /// <summary>
    /// The athlete's clubs.
    /// </summary>
    /// <value>The athlete's clubs.</value>
    [DataMember(Name="clubs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clubs")]
    public List<SummaryClub> Clubs { get; set; }

    /// <summary>
    /// The athlete's bikes.
    /// </summary>
    /// <value>The athlete's bikes.</value>
    [DataMember(Name="bikes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bikes")]
    public List<SummaryGear> Bikes { get; set; }

    /// <summary>
    /// The athlete's shoes.
    /// </summary>
    /// <value>The athlete's shoes.</value>
    [DataMember(Name="shoes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shoes")]
    public List<SummaryGear> Shoes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DetailedAthlete {\n");
      sb.Append("  FollowerCount: ").Append(FollowerCount).Append("\n");
      sb.Append("  FriendCount: ").Append(FriendCount).Append("\n");
      sb.Append("  MeasurementPreference: ").Append(MeasurementPreference).Append("\n");
      sb.Append("  Ftp: ").Append(Ftp).Append("\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
      sb.Append("  Clubs: ").Append(Clubs).Append("\n");
      sb.Append("  Bikes: ").Append(Bikes).Append("\n");
      sb.Append("  Shoes: ").Append(Shoes).Append("\n");
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
