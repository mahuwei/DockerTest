using Newtonsoft.Json;
using SeedWork;

namespace WebApiServer.Models {
    public class Business : Entity {
        public string Name {get; set;}
        public string Address {get; set;}

        public override string ToString() {
            return JsonConvert.SerializeObject(this);
        }
    }
}