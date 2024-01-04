using Myjson.json.MyAddress;
using Myjson.json.Phone;
using Myjson.MyAddress.MyGeo;


namespace Myjson.json
{
    public class MyJsone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        public string WebSite { get; set; }
        public Company Company { get; set; }
        public Location Location { get; set; }

    }
}
