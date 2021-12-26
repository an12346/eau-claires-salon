//MVC web application to help manage stylists and their clients
//Should be able to add a list of stylists working at the salon
//After clicking on a stylist, users should be able to see that stylist's clients 
//Must be able to see a stylist's details 
//Must have the ablity to add new stylists to the System
//Must have the ablity to to add new clients to a specific stylist
//Each client can only belong to one stylist

using System.Collections.Generic;

namespace Salon.Models
{

  public class Stylist
  {

    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }

    public int StylistId { get; set; }
    public string StylistName { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}