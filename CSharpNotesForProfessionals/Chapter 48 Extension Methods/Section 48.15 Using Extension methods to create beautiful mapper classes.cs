using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_48_Extension_Methods_Section_48_15
{
    public class UserDTO
    {
        public AddressDTO Address { get; set; }
    }

    public class AddressDTO
    {
        public string Name { get; set; }
    }

    public class UserViewModel
    {
        public AddressViewModel address { get; set; }
    }

    public class AddressViewModel
    {
        public string Name { get; set; }
    }

    public static class ViewModelMapper
    {
        public static UserViewModel ToViewModel(this UserDTO user)
        {
            return user == null ?
                null :
                new UserViewModel()
                {
                    address = user.Address.ToViewModel()
                };
        }

        public static AddressViewModel ToViewModel(this AddressDTO address)
        {
            return address == null ?
                null : new AddressViewModel()
                {
                    Name = address.Name
                };
        }
    }

}
