using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; set; }
    private static List<Vendor> _instances = new List<Vendor> { };
    public List<Order> Orders { get; set; }

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> { };
    }
    public void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }
    public static void Delete(int id)
    {
      _instances.RemoveAt(id - 1);
      ReIndex();
    }
    public static void ReIndex()
    {
      for(int i = 0; i < _instances.Count; i++)
      {
        _instances[i].Id = i;
      }
    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}
