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
  public class DetailedClub : SummaryClub {
    /// <summary>
    /// The membership status of the logged-in athlete.
    /// </summary>
    /// <value>The membership status of the logged-in athlete.</value>
    [DataMember(Name="membership", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "membership")]
    public string Membership { get; set; }

    /// <summary>
    /// Whether the currently logged-in athlete is an administrator of this club.
    /// </summary>
    /// <value>Whether the currently logged-in athlete is an administrator of this club.</value>
    [DataMember(Name="admin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "admin")]
    public bool? Admin { get; set; }

    /// <summary>
    /// Whether the currently logged-in athlete is the owner of this club.
    /// </summary>
    /// <value>Whether the currently logged-in athlete is the owner of this club.</value>
    [DataMember(Name="owner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner")]
    public bool? Owner { get; set; }

    /// <summary>
    /// The number of athletes in the club that the logged-in athlete follows.
    /// </summary>
    /// <value>The number of athletes in the club that the logged-in athlete follows.</value>
    [DataMember(Name="following_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "following_count")]
    public int? FollowingCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DetailedClub {\n");
      sb.Append("  Membership: ").Append(Membership).Append("\n");
      sb.Append("  Admin: ").Append(Admin).Append("\n");
      sb.Append("  Owner: ").Append(Owner).Append("\n");
      sb.Append("  FollowingCount: ").Append(FollowingCount).Append("\n");
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
