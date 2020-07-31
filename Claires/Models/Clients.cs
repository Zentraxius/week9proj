using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Claires.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public int Price { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }

}
